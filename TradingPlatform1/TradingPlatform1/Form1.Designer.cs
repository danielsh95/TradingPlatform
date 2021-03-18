
namespace TradingPlatform1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSymbol = new System.Windows.Forms.ComboBox();
            this.lbData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.cbMarket = new System.Windows.Forms.ComboBox();
            this.cbOrderType = new System.Windows.Forms.ComboBox();
            this.tbVisible = new System.Windows.Forms.TextBox();
            this.tbPrimaryEx = new System.Windows.Forms.TextBox();
            this.cbTif = new System.Windows.Forms.ComboBox();
            this.tbBid = new System.Windows.Forms.TextBox();
            this.tbAsk = new System.Windows.Forms.TextBox();
            this.tbLast = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.chkOutside = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listViewTns = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(11, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSymbol
            // 
            this.cbSymbol.FormattingEnabled = true;
            this.cbSymbol.Location = new System.Drawing.Point(11, 93);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(121, 21);
            this.cbSymbol.TabIndex = 1;
            this.cbSymbol.Text = "MSFT";
            this.cbSymbol.SelectedIndexChanged += new System.EventHandler(this.cbSymbol_SelectedIndexChanged);
            this.cbSymbol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSymbol_KeyDown);
            this.cbSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSymbol_KeyPress);
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(61, 411);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(585, 199);
            this.lbData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Limit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Market";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Visible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Primary Ex";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "TIF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Bid";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ask";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Last";
            // 
            // numQuantity
            // 
            this.numQuantity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numQuantity.Location = new System.Drawing.Point(208, 93);
            this.numQuantity.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(77, 20);
            this.numQuantity.TabIndex = 14;
            this.numQuantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPrice.Location = new System.Drawing.Point(331, 93);
            this.numPrice.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(77, 20);
            this.numPrice.TabIndex = 15;
            // 
            // cbMarket
            // 
            this.cbMarket.FormattingEnabled = true;
            this.cbMarket.Items.AddRange(new object[] {
            "SMART",
            "ARCA",
            "BATS",
            "ISLAND"});
            this.cbMarket.Location = new System.Drawing.Point(434, 92);
            this.cbMarket.Name = "cbMarket";
            this.cbMarket.Size = new System.Drawing.Size(82, 21);
            this.cbMarket.TabIndex = 16;
            this.cbMarket.Text = "SMART";
            // 
            // cbOrderType
            // 
            this.cbOrderType.FormattingEnabled = true;
            this.cbOrderType.Items.AddRange(new object[] {
            "LMT",
            "MKT",
            "STP",
            "MOC"});
            this.cbOrderType.Location = new System.Drawing.Point(34, 191);
            this.cbOrderType.Name = "cbOrderType";
            this.cbOrderType.Size = new System.Drawing.Size(72, 21);
            this.cbOrderType.TabIndex = 17;
            this.cbOrderType.Text = "LMT";
            // 
            // tbVisible
            // 
            this.tbVisible.Location = new System.Drawing.Point(208, 191);
            this.tbVisible.Name = "tbVisible";
            this.tbVisible.Size = new System.Drawing.Size(77, 20);
            this.tbVisible.TabIndex = 18;
            this.tbVisible.Text = "100";
            // 
            // tbPrimaryEx
            // 
            this.tbPrimaryEx.Location = new System.Drawing.Point(331, 192);
            this.tbPrimaryEx.Name = "tbPrimaryEx";
            this.tbPrimaryEx.Size = new System.Drawing.Size(77, 20);
            this.tbPrimaryEx.TabIndex = 19;
            this.tbPrimaryEx.Text = "NASDAQ";
            // 
            // cbTif
            // 
            this.cbTif.FormattingEnabled = true;
            this.cbTif.Items.AddRange(new object[] {
            "DAY",
            "GTC"});
            this.cbTif.Location = new System.Drawing.Point(462, 189);
            this.cbTif.Name = "cbTif";
            this.cbTif.Size = new System.Drawing.Size(72, 21);
            this.cbTif.TabIndex = 20;
            this.cbTif.Text = "DAY";
            // 
            // tbBid
            // 
            this.tbBid.Location = new System.Drawing.Point(208, 273);
            this.tbBid.Name = "tbBid";
            this.tbBid.Size = new System.Drawing.Size(61, 20);
            this.tbBid.TabIndex = 21;
            this.tbBid.Text = "0.00";
            this.tbBid.Click += new System.EventHandler(this.tbBid_Click);
            // 
            // tbAsk
            // 
            this.tbAsk.Location = new System.Drawing.Point(331, 273);
            this.tbAsk.Name = "tbAsk";
            this.tbAsk.Size = new System.Drawing.Size(64, 20);
            this.tbAsk.TabIndex = 22;
            this.tbAsk.Text = "0.00";
            this.tbAsk.Click += new System.EventHandler(this.tbAsk_Click);
            // 
            // tbLast
            // 
            this.tbLast.Location = new System.Drawing.Point(262, 357);
            this.tbLast.Name = "tbLast";
            this.tbLast.Size = new System.Drawing.Size(64, 20);
            this.tbLast.TabIndex = 23;
            this.tbLast.Text = "0.00";
            this.tbLast.Click += new System.EventHandler(this.tbLast_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(434, 13);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 26;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.Red;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSell.Location = new System.Drawing.Point(96, 267);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(84, 29);
            this.btnSell.TabIndex = 27;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Lime;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBuy.Location = new System.Drawing.Point(424, 267);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 29);
            this.btnBuy.TabIndex = 28;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // chkOutside
            // 
            this.chkOutside.AutoSize = true;
            this.chkOutside.Location = new System.Drawing.Point(51, 359);
            this.chkOutside.Name = "chkOutside";
            this.chkOutside.Size = new System.Drawing.Size(85, 17);
            this.chkOutside.TabIndex = 29;
            this.chkOutside.Text = "OutsideRTH";
            this.chkOutside.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // listViewTns
            // 
            this.listViewTns.BackColor = System.Drawing.Color.Black;
            this.listViewTns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewTns.ForeColor = System.Drawing.Color.White;
            this.listViewTns.HideSelection = false;
            this.listViewTns.Location = new System.Drawing.Point(670, 76);
            this.listViewTns.Name = "listViewTns";
            this.listViewTns.Size = new System.Drawing.Size(335, 533);
            this.listViewTns.TabIndex = 30;
            this.listViewTns.UseCompatibleStateImageBehavior = false;
            this.listViewTns.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Price";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Shares";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 685);
            this.Controls.Add(this.listViewTns);
            this.Controls.Add(this.chkOutside);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.tbLast);
            this.Controls.Add(this.tbAsk);
            this.Controls.Add(this.tbBid);
            this.Controls.Add(this.cbTif);
            this.Controls.Add(this.tbPrimaryEx);
            this.Controls.Add(this.tbVisible);
            this.Controls.Add(this.cbOrderType);
            this.Controls.Add(this.cbMarket);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.cbSymbol);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbSymbol;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.ComboBox cbMarket;
        private System.Windows.Forms.ComboBox cbOrderType;
        private System.Windows.Forms.TextBox tbVisible;
        private System.Windows.Forms.TextBox tbPrimaryEx;
        private System.Windows.Forms.ComboBox cbTif;
        private System.Windows.Forms.TextBox tbBid;
        private System.Windows.Forms.TextBox tbAsk;
        private System.Windows.Forms.TextBox tbLast;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.CheckBox chkOutside;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listViewTns;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

