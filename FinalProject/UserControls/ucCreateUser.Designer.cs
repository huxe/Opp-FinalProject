namespace FinalProject.UserControls
{
    partial class ucCreateUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCreateUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConformPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCnic = new System.Windows.Forms.TextBox();
            this.dtagrdUserInformation = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreateUserSingUp = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRefreshCreateUser = new System.Windows.Forms.Button();
            this.btnCreateUserUpdate1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdUserInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUser.Location = new System.Drawing.Point(181, 70);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(216, 27);
            this.txtUser.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(181, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(216, 27);
            this.txtPassword.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Conform Password";
            // 
            // txtConformPassword
            // 
            this.txtConformPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConformPassword.Location = new System.Drawing.Point(181, 174);
            this.txtConformPassword.Name = "txtConformPassword";
            this.txtConformPassword.Size = new System.Drawing.Size(216, 27);
            this.txtConformPassword.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Home Address";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "CNIC";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtContact.Location = new System.Drawing.Point(181, 232);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(216, 27);
            this.txtContact.TabIndex = 4;
            // 
            // txtCnic
            // 
            this.txtCnic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCnic.Location = new System.Drawing.Point(181, 386);
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(216, 27);
            this.txtCnic.TabIndex = 6;
            // 
            // dtagrdUserInformation
            // 
            this.dtagrdUserInformation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtagrdUserInformation.BackgroundColor = System.Drawing.Color.White;
            this.dtagrdUserInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagrdUserInformation.GridColor = System.Drawing.Color.Blue;
            this.dtagrdUserInformation.Location = new System.Drawing.Point(442, 87);
            this.dtagrdUserInformation.Name = "dtagrdUserInformation";
            this.dtagrdUserInformation.Size = new System.Drawing.Size(591, 351);
            this.dtagrdUserInformation.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(656, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Current User Accounts";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(431, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 510);
            this.panel1.TabIndex = 5;
            // 
            // btnCreateUserSingUp
            // 
            this.btnCreateUserSingUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCreateUserSingUp.BackColor = System.Drawing.Color.Blue;
            this.btnCreateUserSingUp.FlatAppearance.BorderSize = 0;
            this.btnCreateUserSingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUserSingUp.ForeColor = System.Drawing.Color.White;
            this.btnCreateUserSingUp.Location = new System.Drawing.Point(21, 453);
            this.btnCreateUserSingUp.Name = "btnCreateUserSingUp";
            this.btnCreateUserSingUp.Size = new System.Drawing.Size(162, 45);
            this.btnCreateUserSingUp.TabIndex = 7;
            this.btnCreateUserSingUp.Text = "Sing Up";
            this.btnCreateUserSingUp.UseVisualStyleBackColor = false;
            this.btnCreateUserSingUp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(181, 288);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(216, 69);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(509, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(785, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 36);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRefreshCreateUser
            // 
            this.btnRefreshCreateUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefreshCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCreateUser.Image")));
            this.btnRefreshCreateUser.Location = new System.Drawing.Point(966, 3);
            this.btnRefreshCreateUser.Name = "btnRefreshCreateUser";
            this.btnRefreshCreateUser.Size = new System.Drawing.Size(67, 66);
            this.btnRefreshCreateUser.TabIndex = 9;
            this.btnRefreshCreateUser.UseVisualStyleBackColor = true;
            this.btnRefreshCreateUser.Click += new System.EventHandler(this.btnRefreshCreateUser_Click);
            // 
            // btnCreateUserUpdate1
            // 
            this.btnCreateUserUpdate1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCreateUserUpdate1.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateUserUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUserUpdate1.ForeColor = System.Drawing.Color.White;
            this.btnCreateUserUpdate1.Location = new System.Drawing.Point(241, 453);
            this.btnCreateUserUpdate1.Name = "btnCreateUserUpdate1";
            this.btnCreateUserUpdate1.Size = new System.Drawing.Size(146, 45);
            this.btnCreateUserUpdate1.TabIndex = 8;
            this.btnCreateUserUpdate1.Text = "Update";
            this.btnCreateUserUpdate1.UseVisualStyleBackColor = false;
            this.btnCreateUserUpdate1.Click += new System.EventHandler(this.btnCreateUserUpdate1_Click);
            // 
            // ucCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCreateUserUpdate1);
            this.Controls.Add(this.btnRefreshCreateUser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnCreateUserSingUp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtagrdUserInformation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCnic);
            this.Controls.Add(this.txtConformPassword);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucCreateUser";
            this.Size = new System.Drawing.Size(1054, 513);
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdUserInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConformPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.DataGridView dtagrdUserInformation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateUserSingUp;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRefreshCreateUser;
        private System.Windows.Forms.Button btnCreateUserUpdate1;
    }
}
