﻿namespace CUESYSv._01
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserPass = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserPass = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.panClock = new System.Windows.Forms.Panel();
            this.lbClockSeconds = new System.Windows.Forms.Label();
            this.lbClockDate = new System.Windows.Forms.Label();
            this.lbClockTime = new System.Windows.Forms.Label();
            this.timeClock = new System.Windows.Forms.Timer(this.components);
            this.dgRoomBookingsSummary = new System.Windows.Forms.DataGridView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDevLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btRoomB = new System.Windows.Forms.Button();
            this.panFloorLayout = new System.Windows.Forms.Panel();
            this.btRoomG = new System.Windows.Forms.Button();
            this.btRoomE = new System.Windows.Forms.Button();
            this.btRoomC = new System.Windows.Forms.Button();
            this.btRoomA = new System.Windows.Forms.Button();
            this.btRoomH = new System.Windows.Forms.Button();
            this.btRoomF = new System.Windows.Forms.Button();
            this.btRoomD = new System.Windows.Forms.Button();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.lbCustContact = new System.Windows.Forms.Label();
            this.tbCustContact = new System.Windows.Forms.TextBox();
            this.tbCustEmail = new System.Windows.Forms.TextBox();
            this.lbCustEmail = new System.Windows.Forms.Label();
            this.tbCustTel = new System.Windows.Forms.TextBox();
            this.lbCustTel = new System.Windows.Forms.Label();
            this.tbCustTownCity = new System.Windows.Forms.TextBox();
            this.lbCustTownCity = new System.Windows.Forms.Label();
            this.tbCustAdd2 = new System.Windows.Forms.TextBox();
            this.lbCustAdd2 = new System.Windows.Forms.Label();
            this.tbCustAdd1 = new System.Windows.Forms.TextBox();
            this.lbCustAdd1 = new System.Windows.Forms.Label();
            this.tbCustPostcode = new System.Windows.Forms.TextBox();
            this.lbCustPostcode = new System.Windows.Forms.Label();
            this.lbCustTitle = new System.Windows.Forms.Label();
            this.btCustSave = new System.Windows.Forms.Button();
            this.btCustUpdate = new System.Windows.Forms.Button();
            this.btCustDelete = new System.Windows.Forms.Button();
            this.btBook = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lbBookingInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomBookingsSummary)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.panFloorLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(303, 217);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(148, 26);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // tbUserPass
            // 
            this.tbUserPass.Location = new System.Drawing.Point(303, 271);
            this.tbUserPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUserPass.Name = "tbUserPass";
            this.tbUserPass.Size = new System.Drawing.Size(148, 26);
            this.tbUserPass.TabIndex = 1;
            this.tbUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserPass_KeyDown);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(200, 226);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(83, 20);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Username";
            // 
            // lbUserPass
            // 
            this.lbUserPass.AutoSize = true;
            this.lbUserPass.Location = new System.Drawing.Point(204, 280);
            this.lbUserPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserPass.Name = "lbUserPass";
            this.lbUserPass.Size = new System.Drawing.Size(78, 20);
            this.lbUserPass.TabIndex = 3;
            this.lbUserPass.Text = "Password";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(303, 414);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(112, 35);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panClock
            // 
            this.panClock.BackColor = System.Drawing.SystemColors.Control;
            this.panClock.Controls.Add(this.lbClockSeconds);
            this.panClock.Controls.Add(this.lbClockDate);
            this.panClock.Controls.Add(this.lbClockTime);
            this.panClock.Location = new System.Drawing.Point(969, 14);
            this.panClock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panClock.Name = "panClock";
            this.panClock.Size = new System.Drawing.Size(213, 85);
            this.panClock.TabIndex = 6;
            // 
            // lbClockSeconds
            // 
            this.lbClockSeconds.AutoSize = true;
            this.lbClockSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lbClockSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockSeconds.Location = new System.Drawing.Point(183, 35);
            this.lbClockSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClockSeconds.Name = "lbClockSeconds";
            this.lbClockSeconds.Size = new System.Drawing.Size(0, 15);
            this.lbClockSeconds.TabIndex = 0;
            // 
            // lbClockDate
            // 
            this.lbClockDate.AutoSize = true;
            this.lbClockDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbClockDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockDate.Location = new System.Drawing.Point(213, 0);
            this.lbClockDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClockDate.Name = "lbClockDate";
            this.lbClockDate.Size = new System.Drawing.Size(0, 25);
            this.lbClockDate.TabIndex = 2;
            // 
            // lbClockTime
            // 
            this.lbClockTime.AutoSize = true;
            this.lbClockTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockTime.Location = new System.Drawing.Point(98, 35);
            this.lbClockTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClockTime.Name = "lbClockTime";
            this.lbClockTime.Size = new System.Drawing.Size(0, 40);
            this.lbClockTime.TabIndex = 1;
            // 
            // timeClock
            // 
            this.timeClock.Enabled = true;
            this.timeClock.Interval = 1000;
            this.timeClock.Tick += new System.EventHandler(this.timeClock_Tick);
            // 
            // dgRoomBookingsSummary
            // 
            this.dgRoomBookingsSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoomBookingsSummary.Location = new System.Drawing.Point(18, 150);
            this.dgRoomBookingsSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgRoomBookingsSummary.Name = "dgRoomBookingsSummary";
            this.dgRoomBookingsSummary.RowHeadersWidth = 62;
            this.dgRoomBookingsSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRoomBookingsSummary.Size = new System.Drawing.Size(1164, 540);
            this.dgRoomBookingsSummary.TabIndex = 7;
            this.dgRoomBookingsSummary.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgRoomBookingsSummary_CellMouseDoubleClick);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1200, 33);
            this.mainMenu.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDevLogsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewDevLogsToolStripMenuItem
            // 
            this.viewDevLogsToolStripMenuItem.Name = "viewDevLogsToolStripMenuItem";
            this.viewDevLogsToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.viewDevLogsToolStripMenuItem.Text = "View DevLogs";
            this.viewDevLogsToolStripMenuItem.Click += new System.EventHandler(this.viewDevLogsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.customerToolStripMenuItem.Text = "Customers";
            // 
            // createCustomerToolStripMenuItem
            // 
            this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.createCustomerToolStripMenuItem.Text = "Create Customer";
            this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.createCustomerToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookRoomToolStripMenuItem,
            this.viewBookingsToolStripMenuItem});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.roomsToolStripMenuItem.Text = "Flights";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // bookRoomToolStripMenuItem
            // 
            this.bookRoomToolStripMenuItem.Name = "bookRoomToolStripMenuItem";
            this.bookRoomToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.bookRoomToolStripMenuItem.Text = "Book Flight";
            this.bookRoomToolStripMenuItem.Click += new System.EventHandler(this.bookRoomToolStripMenuItem_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(230, 34);
            this.viewBookingsToolStripMenuItem.Text = "View Bookings";
            this.viewBookingsToolStripMenuItem.Click += new System.EventHandler(this.viewBookingsToolStripMenuItem_Click);
            // 
            // btRoomB
            // 
            this.btRoomB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRoomB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRoomB.Location = new System.Drawing.Point(232, 8);
            this.btRoomB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoomB.Name = "btRoomB";
            this.btRoomB.Size = new System.Drawing.Size(165, 154);
            this.btRoomB.TabIndex = 9;
            this.btRoomB.UseVisualStyleBackColor = true;
            this.btRoomB.Click += new System.EventHandler(this.btRoomB_Click);
            // 
            // panFloorLayout
            // 
            this.panFloorLayout.BackgroundImage = global::CUESYSv._01.Properties.Resources.GROUND_FLOOR;
            this.panFloorLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panFloorLayout.Controls.Add(this.btRoomG);
            this.panFloorLayout.Controls.Add(this.btRoomE);
            this.panFloorLayout.Controls.Add(this.btRoomC);
            this.panFloorLayout.Controls.Add(this.btRoomA);
            this.panFloorLayout.Controls.Add(this.btRoomH);
            this.panFloorLayout.Controls.Add(this.btRoomF);
            this.panFloorLayout.Controls.Add(this.btRoomD);
            this.panFloorLayout.Controls.Add(this.btRoomB);
            this.panFloorLayout.Location = new System.Drawing.Point(129, 142);
            this.panFloorLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panFloorLayout.Name = "panFloorLayout";
            this.panFloorLayout.Size = new System.Drawing.Size(903, 480);
            this.panFloorLayout.TabIndex = 10;
            // 
            // btRoomG
            // 
            this.btRoomG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRoomG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRoomG.Location = new System.Drawing.Point(616, 317);
            this.btRoomG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoomG.Name = "btRoomG";
            this.btRoomG.Size = new System.Drawing.Size(165, 154);
            this.btRoomG.TabIndex = 16;
            this.btRoomG.UseVisualStyleBackColor = true;
            this.btRoomG.Click += new System.EventHandler(this.btRoomG_Click);
            // 
            // btRoomE
            // 
            this.btRoomE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRoomE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRoomE.Location = new System.Drawing.Point(450, 317);
            this.btRoomE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoomE.Name = "btRoomE";
            this.btRoomE.Size = new System.Drawing.Size(165, 154);
            this.btRoomE.TabIndex = 15;
            this.btRoomE.UseVisualStyleBackColor = true;
            this.btRoomE.Click += new System.EventHandler(this.btRoomE_Click);
            // 
            // btRoomC
            // 
            this.btRoomC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRoomC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRoomC.Location = new System.Drawing.Point(286, 317);
            this.btRoomC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoomC.Name = "btRoomC";
            this.btRoomC.Size = new System.Drawing.Size(165, 154);
            this.btRoomC.TabIndex = 14;
            this.btRoomC.UseVisualStyleBackColor = true;
            this.btRoomC.Click += new System.EventHandler(this.btRoomC_Click);
            // 
            // btRoomA
            // 
            this.btRoomA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRoomA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRoomA.Location = new System.Drawing.Point(120, 317);
            this.btRoomA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoomA.Name = "btRoomA";
            this.btRoomA.Size = new System.Drawing.Size(165, 154);
            this.btRoomA.TabIndex = 13;
            this.btRoomA.UseVisualStyleBackColor = true;
            this.btRoomA.Click += new System.EventHandler(this.btRoomA_Click);
            // 
            // btRoomH
            // 
            this.btRoomH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRoomH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRoomH.Location = new System.Drawing.Point(729, 8);
            this.btRoomH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoomH.Name = "btRoomH";
            this.btRoomH.Size = new System.Drawing.Size(165, 154);
            this.btRoomH.TabIndex = 12;
            this.btRoomH.UseVisualStyleBackColor = true;
            this.btRoomH.Click += new System.EventHandler(this.btRoomH_Click);
            // 
            // btRoomF
            // 
            this.btRoomF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRoomF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRoomF.Location = new System.Drawing.Point(562, 8);
            this.btRoomF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoomF.Name = "btRoomF";
            this.btRoomF.Size = new System.Drawing.Size(165, 154);
            this.btRoomF.TabIndex = 11;
            this.btRoomF.UseVisualStyleBackColor = true;
            this.btRoomF.Click += new System.EventHandler(this.btRoomF_Click);
            // 
            // btRoomD
            // 
            this.btRoomD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btRoomD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRoomD.Location = new System.Drawing.Point(399, 8);
            this.btRoomD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRoomD.Name = "btRoomD";
            this.btRoomD.Size = new System.Drawing.Size(165, 154);
            this.btRoomD.TabIndex = 10;
            this.btRoomD.UseVisualStyleBackColor = true;
            this.btRoomD.Click += new System.EventHandler(this.btRoomD_Click);
            // 
            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "Ground",
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.cbFloor.Location = new System.Drawing.Point(555, 138);
            this.cbFloor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(180, 28);
            this.cbFloor.TabIndex = 11;
            // 
            // cbBuilding
            // 
            this.cbBuilding.FormattingEnabled = true;
            this.cbBuilding.Items.AddRange(new object[] {
            "Armstrong Siddeley",
            "Jaguar",
            "William Lyons"});
            this.cbBuilding.Location = new System.Drawing.Point(364, 138);
            this.cbBuilding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(180, 28);
            this.cbBuilding.TabIndex = 12;
            // 
            // lbCustContact
            // 
            this.lbCustContact.AutoSize = true;
            this.lbCustContact.Location = new System.Drawing.Point(542, 237);
            this.lbCustContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustContact.Name = "lbCustContact";
            this.lbCustContact.Size = new System.Drawing.Size(138, 20);
            this.lbCustContact.TabIndex = 13;
            this.lbCustContact.Text = "Customer Contact";
            // 
            // tbCustContact
            // 
            this.tbCustContact.Location = new System.Drawing.Point(687, 232);
            this.tbCustContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustContact.Name = "tbCustContact";
            this.tbCustContact.Size = new System.Drawing.Size(148, 26);
            this.tbCustContact.TabIndex = 14;
            // 
            // tbCustEmail
            // 
            this.tbCustEmail.Location = new System.Drawing.Point(687, 271);
            this.tbCustEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustEmail.Name = "tbCustEmail";
            this.tbCustEmail.Size = new System.Drawing.Size(148, 26);
            this.tbCustEmail.TabIndex = 16;
            // 
            // lbCustEmail
            // 
            this.lbCustEmail.AutoSize = true;
            this.lbCustEmail.Location = new System.Drawing.Point(542, 275);
            this.lbCustEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustEmail.Name = "lbCustEmail";
            this.lbCustEmail.Size = new System.Drawing.Size(108, 20);
            this.lbCustEmail.TabIndex = 15;
            this.lbCustEmail.Text = "Contact Email";
            // 
            // tbCustTel
            // 
            this.tbCustTel.Location = new System.Drawing.Point(687, 311);
            this.tbCustTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustTel.Name = "tbCustTel";
            this.tbCustTel.Size = new System.Drawing.Size(148, 26);
            this.tbCustTel.TabIndex = 18;
            // 
            // lbCustTel
            // 
            this.lbCustTel.AutoSize = true;
            this.lbCustTel.Location = new System.Drawing.Point(542, 315);
            this.lbCustTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustTel.Name = "lbCustTel";
            this.lbCustTel.Size = new System.Drawing.Size(144, 20);
            this.lbCustTel.TabIndex = 17;
            this.lbCustTel.Text = "Contact Telephone";
            // 
            // tbCustTownCity
            // 
            this.tbCustTownCity.Location = new System.Drawing.Point(687, 429);
            this.tbCustTownCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustTownCity.Name = "tbCustTownCity";
            this.tbCustTownCity.Size = new System.Drawing.Size(148, 26);
            this.tbCustTownCity.TabIndex = 24;
            // 
            // lbCustTownCity
            // 
            this.lbCustTownCity.AutoSize = true;
            this.lbCustTownCity.Location = new System.Drawing.Point(542, 434);
            this.lbCustTownCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustTownCity.Name = "lbCustTownCity";
            this.lbCustTownCity.Size = new System.Drawing.Size(85, 20);
            this.lbCustTownCity.TabIndex = 23;
            this.lbCustTownCity.Text = "Town / City";
            // 
            // tbCustAdd2
            // 
            this.tbCustAdd2.Location = new System.Drawing.Point(687, 389);
            this.tbCustAdd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustAdd2.Name = "tbCustAdd2";
            this.tbCustAdd2.Size = new System.Drawing.Size(148, 26);
            this.tbCustAdd2.TabIndex = 22;
            // 
            // lbCustAdd2
            // 
            this.lbCustAdd2.AutoSize = true;
            this.lbCustAdd2.Location = new System.Drawing.Point(542, 394);
            this.lbCustAdd2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustAdd2.Name = "lbCustAdd2";
            this.lbCustAdd2.Size = new System.Drawing.Size(115, 20);
            this.lbCustAdd2.TabIndex = 21;
            this.lbCustAdd2.Text = "Address Line 2";
            // 
            // tbCustAdd1
            // 
            this.tbCustAdd1.Location = new System.Drawing.Point(687, 351);
            this.tbCustAdd1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustAdd1.Name = "tbCustAdd1";
            this.tbCustAdd1.Size = new System.Drawing.Size(148, 26);
            this.tbCustAdd1.TabIndex = 20;
            // 
            // lbCustAdd1
            // 
            this.lbCustAdd1.AutoSize = true;
            this.lbCustAdd1.Location = new System.Drawing.Point(542, 355);
            this.lbCustAdd1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustAdd1.Name = "lbCustAdd1";
            this.lbCustAdd1.Size = new System.Drawing.Size(115, 20);
            this.lbCustAdd1.TabIndex = 19;
            this.lbCustAdd1.Text = "Address Line 1";
            // 
            // tbCustPostcode
            // 
            this.tbCustPostcode.Location = new System.Drawing.Point(687, 469);
            this.tbCustPostcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustPostcode.Name = "tbCustPostcode";
            this.tbCustPostcode.Size = new System.Drawing.Size(148, 26);
            this.tbCustPostcode.TabIndex = 26;
            // 
            // lbCustPostcode
            // 
            this.lbCustPostcode.AutoSize = true;
            this.lbCustPostcode.Location = new System.Drawing.Point(542, 474);
            this.lbCustPostcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustPostcode.Name = "lbCustPostcode";
            this.lbCustPostcode.Size = new System.Drawing.Size(76, 20);
            this.lbCustPostcode.TabIndex = 25;
            this.lbCustPostcode.Text = "Postcode";
            // 
            // lbCustTitle
            // 
            this.lbCustTitle.AutoSize = true;
            this.lbCustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustTitle.Location = new System.Drawing.Point(612, 192);
            this.lbCustTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustTitle.Name = "lbCustTitle";
            this.lbCustTitle.Size = new System.Drawing.Size(0, 29);
            this.lbCustTitle.TabIndex = 27;
            // 
            // btCustSave
            // 
            this.btCustSave.Location = new System.Drawing.Point(687, 511);
            this.btCustSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCustSave.Name = "btCustSave";
            this.btCustSave.Size = new System.Drawing.Size(150, 35);
            this.btCustSave.TabIndex = 28;
            this.btCustSave.Text = "Save";
            this.btCustSave.UseVisualStyleBackColor = true;
            this.btCustSave.Click += new System.EventHandler(this.btCustSave_Click);
            // 
            // btCustUpdate
            // 
            this.btCustUpdate.Location = new System.Drawing.Point(686, 512);
            this.btCustUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCustUpdate.Name = "btCustUpdate";
            this.btCustUpdate.Size = new System.Drawing.Size(150, 35);
            this.btCustUpdate.TabIndex = 29;
            this.btCustUpdate.Text = "Update";
            this.btCustUpdate.UseVisualStyleBackColor = true;
            // 
            // btCustDelete
            // 
            this.btCustDelete.Location = new System.Drawing.Point(686, 557);
            this.btCustDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCustDelete.Name = "btCustDelete";
            this.btCustDelete.Size = new System.Drawing.Size(150, 35);
            this.btCustDelete.TabIndex = 30;
            this.btCustDelete.Text = "Delete";
            this.btCustDelete.UseVisualStyleBackColor = true;
            // 
            // btBook
            // 
            this.btBook.Location = new System.Drawing.Point(776, 635);
            this.btBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(112, 35);
            this.btBook.TabIndex = 43;
            this.btBook.Text = "BOOK";
            this.btBook.UseVisualStyleBackColor = true;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(548, 526);
            this.tbTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTime.Mask = "00:00";
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(58, 26);
            this.tbTime.TabIndex = 42;
            this.tbTime.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 569);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 37);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cost       £";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 37);
            this.label4.TabIndex = 40;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 517);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 37);
            this.label3.TabIndex = 39;
            this.label3.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 635);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 37);
            this.label2.TabIndex = 38;
            this.label2.Text = "Paid (Y/N)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Customer";
            // 
            // mcDate
            // 
            this.mcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcDate.Location = new System.Drawing.Point(548, 262);
            this.mcDate.Margin = new System.Windows.Forms.Padding(14);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 36;
            // 
            // cbPaid
            // 
            this.cbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaid.Location = new System.Drawing.Point(558, 635);
            this.cbPaid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(38, 38);
            this.cbPaid.TabIndex = 35;
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(548, 200);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(338, 40);
            this.tbCustomer.TabIndex = 34;
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(548, 566);
            this.tbCost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(338, 40);
            this.tbCost.TabIndex = 33;
            // 
            // lbBookingInfo
            // 
            this.lbBookingInfo.AutoSize = true;
            this.lbBookingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingInfo.Location = new System.Drawing.Point(552, 148);
            this.lbBookingInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookingInfo.Name = "lbBookingInfo";
            this.lbBookingInfo.Size = new System.Drawing.Size(182, 37);
            this.lbBookingInfo.TabIndex = 32;
            this.lbBookingInfo.Text = "xxxxxxxxxxx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 50);
            this.button1.TabIndex = 44;
            this.button1.Text = "Delete selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 50);
            this.button2.TabIndex = 45;
            this.button2.Text = "Delete Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBook);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lbBookingInfo);
            this.Controls.Add(this.btCustDelete);
            this.Controls.Add(this.btCustUpdate);
            this.Controls.Add(this.btCustSave);
            this.Controls.Add(this.lbCustTitle);
            this.Controls.Add(this.tbCustPostcode);
            this.Controls.Add(this.lbCustPostcode);
            this.Controls.Add(this.tbCustTownCity);
            this.Controls.Add(this.lbCustTownCity);
            this.Controls.Add(this.tbCustAdd2);
            this.Controls.Add(this.lbCustAdd2);
            this.Controls.Add(this.tbCustAdd1);
            this.Controls.Add(this.lbCustAdd1);
            this.Controls.Add(this.tbCustTel);
            this.Controls.Add(this.lbCustTel);
            this.Controls.Add(this.tbCustEmail);
            this.Controls.Add(this.lbCustEmail);
            this.Controls.Add(this.tbCustContact);
            this.Controls.Add(this.lbCustContact);
            this.Controls.Add(this.cbBuilding);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.panFloorLayout);
            this.Controls.Add(this.dgRoomBookingsSummary);
            this.Controls.Add(this.panClock);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbUserPass);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUserPass);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panClock.ResumeLayout(false);
            this.panClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomBookingsSummary)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panFloorLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserPass;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panClock;
        private System.Windows.Forms.Label lbClockSeconds;
        private System.Windows.Forms.Label lbClockDate;
        private System.Windows.Forms.Label lbClockTime;
        private System.Windows.Forms.Timer timeClock;
        private System.Windows.Forms.DataGridView dgRoomBookingsSummary;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDevLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Button btRoomB;
        private System.Windows.Forms.ToolStripMenuItem bookRoomToolStripMenuItem;
        private System.Windows.Forms.Panel panFloorLayout;
        private System.Windows.Forms.Button btRoomG;
        private System.Windows.Forms.Button btRoomE;
        private System.Windows.Forms.Button btRoomC;
        private System.Windows.Forms.Button btRoomA;
        private System.Windows.Forms.Button btRoomH;
        private System.Windows.Forms.Button btRoomF;
        private System.Windows.Forms.Button btRoomD;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.ComboBox cbBuilding;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
        private System.Windows.Forms.Label lbCustContact;
        private System.Windows.Forms.TextBox tbCustContact;
        private System.Windows.Forms.TextBox tbCustEmail;
        private System.Windows.Forms.Label lbCustEmail;
        private System.Windows.Forms.TextBox tbCustTel;
        private System.Windows.Forms.Label lbCustTel;
        private System.Windows.Forms.TextBox tbCustTownCity;
        private System.Windows.Forms.Label lbCustTownCity;
        private System.Windows.Forms.TextBox tbCustAdd2;
        private System.Windows.Forms.Label lbCustAdd2;
        private System.Windows.Forms.TextBox tbCustAdd1;
        private System.Windows.Forms.Label lbCustAdd1;
        private System.Windows.Forms.TextBox tbCustPostcode;
        private System.Windows.Forms.Label lbCustPostcode;
        private System.Windows.Forms.Label lbCustTitle;
        private System.Windows.Forms.Button btCustSave;
        private System.Windows.Forms.Button btCustUpdate;
        private System.Windows.Forms.Button btCustDelete;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.MaskedTextBox tbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lbBookingInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

