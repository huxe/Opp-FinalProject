namespace FinalProject.Forms
{
    partial class formHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnstocks = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnManageItems = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnlSaleMan = new System.Windows.Forms.Panel();
            this.btnRefreshCreateUser = new System.Windows.Forms.Button();
            this.dtaHome = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.RichTextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmboCatagery = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelLeft.SuspendLayout();
            this.PnlSaleMan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 58);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1230, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 58);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Electronics shop";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Blue;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(20, 63);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(191, 45);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "     Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 8);
            this.panel2.TabIndex = 4;
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.Blue;
            this.PanelLeft.Controls.Add(this.pnlMove);
            this.PanelLeft.Controls.Add(this.btnLogout);
            this.PanelLeft.Controls.Add(this.btnstocks);
            this.PanelLeft.Controls.Add(this.button9);
            this.PanelLeft.Controls.Add(this.button8);
            this.PanelLeft.Controls.Add(this.btnsettings);
            this.PanelLeft.Controls.Add(this.btnManageItems);
            this.PanelLeft.Controls.Add(this.btnRecords);
            this.PanelLeft.Controls.Add(this.btnHome);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 66);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(214, 654);
            this.PanelLeft.TabIndex = 5;
            this.PanelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLeft_Paint);
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.White;
            this.pnlMove.Location = new System.Drawing.Point(3, 63);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(7, 45);
            this.pnlMove.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Blue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(20, 316);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(191, 45);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "     Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnstocks
            // 
            this.btnstocks.BackColor = System.Drawing.Color.Blue;
            this.btnstocks.FlatAppearance.BorderSize = 0;
            this.btnstocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstocks.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstocks.ForeColor = System.Drawing.Color.White;
            this.btnstocks.Image = ((System.Drawing.Image)(resources.GetObject("btnstocks.Image")));
            this.btnstocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstocks.Location = new System.Drawing.Point(20, 216);
            this.btnstocks.Name = "btnstocks";
            this.btnstocks.Size = new System.Drawing.Size(191, 45);
            this.btnstocks.TabIndex = 3;
            this.btnstocks.Text = "     Stocks";
            this.btnstocks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstocks.UseVisualStyleBackColor = false;
            this.btnstocks.Click += new System.EventHandler(this.btnstocks_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Blue;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(12, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(41, 36);
            this.button9.TabIndex = 3;
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button8_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(170, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 36);
            this.button8.TabIndex = 3;
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.Blue;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Image = ((System.Drawing.Image)(resources.GetObject("btnsettings.Image")));
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(20, 265);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(191, 45);
            this.btnsettings.TabIndex = 3;
            this.btnsettings.Text = "     Settings";
            this.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnManageItems
            // 
            this.btnManageItems.BackColor = System.Drawing.Color.Blue;
            this.btnManageItems.FlatAppearance.BorderSize = 0;
            this.btnManageItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageItems.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageItems.ForeColor = System.Drawing.Color.White;
            this.btnManageItems.Image = ((System.Drawing.Image)(resources.GetObject("btnManageItems.Image")));
            this.btnManageItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageItems.Location = new System.Drawing.Point(20, 165);
            this.btnManageItems.Name = "btnManageItems";
            this.btnManageItems.Size = new System.Drawing.Size(191, 45);
            this.btnManageItems.TabIndex = 3;
            this.btnManageItems.Text = "     Manage items";
            this.btnManageItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageItems.UseVisualStyleBackColor = false;
            this.btnManageItems.Click += new System.EventHandler(this.btnManageItems_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.BackColor = System.Drawing.Color.Blue;
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.ForeColor = System.Drawing.Color.White;
            this.btnRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnRecords.Image")));
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.Location = new System.Drawing.Point(20, 114);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(191, 45);
            this.btnRecords.TabIndex = 3;
            this.btnRecords.Text = "     Records";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecords.UseVisualStyleBackColor = false;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // PnlSaleMan
            // 
            this.PnlSaleMan.Controls.Add(this.btnRefreshCreateUser);
            this.PnlSaleMan.Controls.Add(this.dtaHome);
            this.PnlSaleMan.Controls.Add(this.txtName);
            this.PnlSaleMan.Controls.Add(this.txtQuantity);
            this.PnlSaleMan.Controls.Add(this.txtID);
            this.PnlSaleMan.Controls.Add(this.txtPrice);
            this.PnlSaleMan.Controls.Add(this.label7);
            this.PnlSaleMan.Controls.Add(this.label3);
            this.PnlSaleMan.Controls.Add(this.label6);
            this.PnlSaleMan.Controls.Add(this.label5);
            this.PnlSaleMan.Controls.Add(this.button6);
            this.PnlSaleMan.Controls.Add(this.button4);
            this.PnlSaleMan.Controls.Add(this.button7);
            this.PnlSaleMan.Controls.Add(this.button5);
            this.PnlSaleMan.Controls.Add(this.button3);
            this.PnlSaleMan.Controls.Add(this.cmboCatagery);
            this.PnlSaleMan.Controls.Add(this.label1);
            this.PnlSaleMan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSaleMan.Location = new System.Drawing.Point(214, 66);
            this.PnlSaleMan.Name = "PnlSaleMan";
            this.PnlSaleMan.Size = new System.Drawing.Size(1086, 654);
            this.PnlSaleMan.TabIndex = 6;
            this.PnlSaleMan.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSaleMan_Paint);
            // 
            // btnRefreshCreateUser
            // 
            this.btnRefreshCreateUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefreshCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCreateUser.Image")));
            this.btnRefreshCreateUser.Location = new System.Drawing.Point(29, 41);
            this.btnRefreshCreateUser.Name = "btnRefreshCreateUser";
            this.btnRefreshCreateUser.Size = new System.Drawing.Size(67, 66);
            this.btnRefreshCreateUser.TabIndex = 10;
            this.btnRefreshCreateUser.UseVisualStyleBackColor = true;
            this.btnRefreshCreateUser.Click += new System.EventHandler(this.btnRefreshCreateUser_Click);
            // 
            // dtaHome
            // 
            this.dtaHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaHome.Location = new System.Drawing.Point(29, 144);
            this.dtaHome.Name = "dtaHome";
            this.dtaHome.Size = new System.Drawing.Size(475, 381);
            this.dtaHome.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(627, 216);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 96);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(627, 424);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(136, 27);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(627, 358);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 27);
            this.txtPrice.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(322, 565);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 33);
            this.button6.TabIndex = 2;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(692, 492);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 33);
            this.button4.TabIndex = 2;
            this.button4.Text = "Print";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(188, 565);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 33);
            this.button7.TabIndex = 2;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(65, 565);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 33);
            this.button5.TabIndex = 2;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(540, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cmboCatagery
            // 
            this.cmboCatagery.FormattingEnabled = true;
            this.cmboCatagery.Items.AddRange(new object[] {
            "ac",
            "tv",
            "generator"});
            this.cmboCatagery.Location = new System.Drawing.Point(300, 61);
            this.cmboCatagery.Name = "cmboCatagery";
            this.cmboCatagery.Size = new System.Drawing.Size(121, 29);
            this.cmboCatagery.TabIndex = 1;
            this.cmboCatagery.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catagery";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(627, 144);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 27);
            this.txtID.TabIndex = 6;
            // 
            // formHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.PnlSaleMan);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(0)))), ((int)(((byte)(178)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHome";
            this.Text = "frmHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelLeft.ResumeLayout(false);
            this.PnlSaleMan.ResumeLayout(false);
            this.PnlSaleMan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnstocks;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnManageItems;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel PnlSaleMan;
        private System.Windows.Forms.RichTextBox txtName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmboCatagery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtaHome;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRefreshCreateUser;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
    }
}