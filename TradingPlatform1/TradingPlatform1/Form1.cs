using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using IBApi;

namespace TradingPlatform1
{
    public partial class Form1 : Form
    {
        // This delegate enables asynchronous calls for setting
        // the text property on a ListBox control.
        delegate void SetTextCallback(string text);
        delegate void SetTextCallbackTickPrice(string _tickPrice);

        int order_id = 0;
        int timer1_counter = 5;

        public void AddListBoxItem(string text)
        {
            // See if a new invocation is required form a different thread            
            if (this.lbData.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AddListBoxItem);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // Add the text string to the list box
                this.lbData.Items.Add(text);
            }
        }

        // Create the ibClient object to represent the connection
        EWrapperImpl ibClient;

        public Form1()
        {
            InitializeComponent();

            // instantiate the ibClient
            ibClient = new EWrapperImpl();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Connect to the IB Server through TWS. Parameters are:
            // host       - Host name or IP address of the host running TWS
            // port       - The port TWS listens through for connections
            // clientId   - The identifier of the client application
            ibClient.ClientSocket.eConnect("127.0.0.1", 7496, 0);


            // For IB TWS API version 9.72 and higher, implement this
            // signal-handling code. Otherwise comment it out.

            var reader = new EReader(ibClient.ClientSocket, ibClient.Signal);
            reader.Start();
            new Thread(() => {
                while (ibClient.ClientSocket.IsConnected())
                {
                    ibClient.Signal.waitForSignal();
                    reader.processMsgs();
                }
            })
            { IsBackground = true }.Start();

            // Pause here until the connection is complete 
            while (ibClient.NextOrderId <= 0) { }

            // Set up the form object in the EWrapper
            ibClient.myform = (Form1)Application.OpenForms[0];


            // gets the next order id and puts it in the textbox 
            tbValid_Id.Text = ibClient.NextOrderId.ToString();
            // updates the order_id value
            order_id = ibClient.NextOrderId;



            getData();
        }        


        public void AddTextBoxItemTickPrice(string _tickPrice)
        {
            if (this.tbLast.InvokeRequired)
            {
                SetTextCallbackTickPrice d = new SetTextCallbackTickPrice(AddTextBoxItemTickPrice);
                try
                {
                    this.Invoke(d, new object[] { _tickPrice });
                }
                catch (Exception e)
                {
                    Console.WriteLine("This is from tickPrice", e);
                }
            }
            else
            {

                string[] tickerPrice = new string[] { _tickPrice };
                tickerPrice = _tickPrice.Split(',');

                if (Convert.ToInt32(tickerPrice[0]) == 1)
                {
                    if (Convert.ToInt32(tickerPrice[1]) == 4)// Delayed Last quote 68, if you want realtime use tickerPrice == 4
                    {
                        // Add the text string to the list box

                        this.tbLast.Text = tickerPrice[2];

                    }
                    else if (Convert.ToInt32(tickerPrice[1]) == 2)  // Delayed Ask quote 67, if you want realtime use tickerPrice == 2
                    {
                        // Add the text string to the list box

                        this.tbAsk.Text = tickerPrice[2];

                    }
                    else if (Convert.ToInt32(tickerPrice[1]) == 1)  // Delayed Bid quote 66, if you want realtime use tickerPrice == 1
                    {
                        // Add the text string to the list box

                        this.tbBid.Text = tickerPrice[2];

                    }
                }
            }
        }

        private void getData()
        {
            ibClient.ClientSocket.cancelMktData(1); // cancel market data

            // Create a new contract to specify the security we are searching for
            IBApi.Contract contract = new IBApi.Contract();
            // Create a new TagValueList object (for API version 9.71 and later) 
            List<TagValue> mktDataOptions = new List<TagValue>();

            // Set the underlying stock symbol from the cbSymbol combobox
            contract.Symbol = cbSymbol.Text;
            // Set the Security type to STK for a Stock
            contract.SecType = "STK";
            // Use "SMART" as the general exchange
            contract.Exchange = "SMART";
            // Set the primary exchange (sometimes called Listing exchange)
            // Use either NYSE or ISLAND
            contract.PrimaryExch = "ISLAND";
            // Set the currency to USD
            contract.Currency = "USD";

            // If using delayed market data subscription
            // in the line below to make sure parameter is 3 not 1 
            ibClient.ClientSocket.reqMarketDataType(1);  // delayed data = 3 live = 1

            // Kick off the subscription for real-time data (add the mktDataOptions list for API v9.71)
            //ibClient.ClientSocket.reqMktData(1, contract, "", false, mktDataOptions);
            // For API v9.72 and higher, add one more parameter for regulatory snapshot
            ibClient.ClientSocket.reqMktData(1, contract, "", false, false, mktDataOptions);

            timer1.Start();

        }

        public void send_order(string side)
        {
            // Create a new contract to specify the security we are searching for
            IBApi.Contract contract = new IBApi.Contract();

            // Set the underlying stock symbol from the cbSymbol combobox
            contract.Symbol = cbSymbol.Text;
            // Set the Security type to STK for a Stock
            contract.SecType = "STK";
            // Use "SMART" as the general exchange
            contract.Exchange = cbMarket.Text;
            // Set the primary exchange (sometimes called Listing exchange)
            // Use either NYSE or ISLAND
            contract.PrimaryExch = "ISLAND";
            // Set the currency to USD
            contract.Currency = "USD";

            IBApi.Order order = new IBApi.Order();
            // gets the next order id from the text box
            order.OrderId = order_id;
            // gets the side of the order (BUY, or SELL)
            order.Action = side;
            // gets order type from combobox market or limit order(MKT, or LMT)
            order.OrderType = cbOrderType.Text;
            // number of shares from Quantity
            order.TotalQuantity = Convert.ToDouble(numQuantity.Value);
            // Value from limit price
            order.LmtPrice = Convert.ToDouble(numPrice.Value);
            // checks for a stop order
            if (cbOrderType.Text == "STP")
            {
                // Stop order value from the limit textbox
                order.AuxPrice = Convert.ToDouble(numPrice.Value);
            }
            //Visible shares to the market
            order.DisplaySize = Convert.ToInt32(tbVisible.Text);
            //order.OutsideRth = cbOutsideRTH.Checked;
            order.OutsideRth = chkOutside.Checked;

            // Place the order
            ibClient.ClientSocket.placeOrder(order_id, contract, order);

            // increase the order id value
            order_id++;
            tbValid_Id.Text = Convert.ToString(order_id);
        }

        private void cbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void cbSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void cbSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbSymbol.SelectionStart = 0;
                cbSymbol.SelectionLength = cbSymbol.Text.Length;

                e.SuppressKeyPress = true;

                string name = cbSymbol.Text;


                // adds the security symbol to the dropdown list in the symbol combobox
                if (!cbSymbol.Items.Contains(name))
                {
                    cbSymbol.Items.Add(name);
                }
                cbSymbol.SelectAll();

                getData();
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ibClient.ClientSocket.eDisconnect();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string side = "BUY";
            send_order(side);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string side = "Sell";
            send_order(side);
        }

        private void tbBid_Click(object sender, EventArgs e)
        {
            numPrice.Value = Convert.ToDecimal(tbBid.Text);
        }

        private void tbAsk_Click(object sender, EventArgs e)
        {
            numPrice.Value = Convert.ToDecimal(tbAsk.Text);
        }

        private void tbLast_Click(object sender, EventArgs e)
        {
            numPrice.Value = Convert.ToDecimal(tbLast.Text);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timer1_counter == 0)
            {
                timer1.Stop(); // stop the timer
                //add the bid price to the limit box
                numPrice.Value = Convert.ToDecimal(tbBid.Text);
                timer1_counter = 5;// resets timer counter back to 5
            }
            timer1_counter--; // subtract 1 every time their is a tick
        }
    }
}
