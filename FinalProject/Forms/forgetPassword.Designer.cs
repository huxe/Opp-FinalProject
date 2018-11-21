namespace FinalProject.Forms
{
    partial class forgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgetPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.txtForgetPasswordEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForgetPasswordNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtForgetPasswordConformPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnForgetPasswordChange = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnForgetPasswordSendMail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtForgrtPassswordCode = new System.Windows.Forms.TextBox();
            this.btnForgetPassordNextStep = new System.Windows.Forms.Button();
            this.btnForgetPassordSendAgain = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNextStep2 = new System.Windows.Forms.Label();
            this.imgNextStep2 = new System.Windows.Forms.Button();
            this.lblNextStep1 = new System.Windows.Forms.Label();
            this.imgNextStep1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your Email";
            // 
            // txtForgetPasswordEmail
            // 
            this.txtForgetPasswordEmail.Location = new System.Drawing.Point(194, 34);
            this.txtForgetPasswordEmail.Name = "txtForgetPasswordEmail";
            this.txtForgetPasswordEmail.Size = new System.Drawing.Size(244, 20);
            this.txtForgetPasswordEmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(32, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Password";
            // 
            // txtForgetPasswordNewPassword
            // 
            this.txtForgetPasswordNewPassword.Enabled = false;
            this.txtForgetPasswordNewPassword.Location = new System.Drawing.Point(194, 364);
            this.txtForgetPasswordNewPassword.Name = "txtForgetPasswordNewPassword";
            this.txtForgetPasswordNewPassword.PasswordChar = '*';
            this.txtForgetPasswordNewPassword.Size = new System.Drawing.Size(244, 20);
            this.txtForgetPasswordNewPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(32, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Conform Password";
            // 
            // txtForgetPasswordConformPassword
            // 
            this.txtForgetPasswordConformPassword.Enabled = false;
            this.txtForgetPasswordConformPassword.Location = new System.Drawing.Point(194, 406);
            this.txtForgetPasswordConformPassword.Name = "txtForgetPasswordConformPassword";
            this.txtForgetPasswordConformPassword.Size = new System.Drawing.Size(244, 20);
            this.txtForgetPasswordConformPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(131, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "This Email is not exist in data base";
            this.label4.Visible = false;
            // 
            // btnForgetPasswordChange
            // 
            this.btnForgetPasswordChange.BackColor = System.Drawing.Color.Blue;
            this.btnForgetPasswordChange.Enabled = false;
            this.btnForgetPasswordChange.FlatAppearance.BorderSize = 0;
            this.btnForgetPasswordChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPasswordChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPasswordChange.ForeColor = System.Drawing.Color.White;
            this.btnForgetPasswordChange.Location = new System.Drawing.Point(166, 450);
            this.btnForgetPasswordChange.Name = "btnForgetPasswordChange";
            this.btnForgetPasswordChange.Size = new System.Drawing.Size(125, 37);
            this.btnForgetPasswordChange.TabIndex = 2;
            this.btnForgetPasswordChange.Text = "Change";
            this.btnForgetPasswordChange.UseVisualStyleBackColor = false;
            this.btnForgetPasswordChange.Click += new System.EventHandler(this.btnForgetPasswordChange_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(481, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "_______________________________________________________________________________";
            // 
            // btnForgetPasswordSendMail
            // 
            this.btnForgetPasswordSendMail.BackColor = System.Drawing.Color.Red;
            this.btnForgetPasswordSendMail.FlatAppearance.BorderSize = 0;
            this.btnForgetPasswordSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPasswordSendMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPasswordSendMail.ForeColor = System.Drawing.Color.White;
            this.btnForgetPasswordSendMail.Location = new System.Drawing.Point(166, 84);
            this.btnForgetPasswordSendMail.Name = "btnForgetPasswordSendMail";
            this.btnForgetPasswordSendMail.Size = new System.Drawing.Size(125, 37);
            this.btnForgetPasswordSendMail.TabIndex = 2;
            this.btnForgetPasswordSendMail.Text = "Send Mail";
            this.btnForgetPasswordSendMail.UseVisualStyleBackColor = false;
            this.btnForgetPasswordSendMail.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(32, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Four Digit Code";
            // 
            // txtForgrtPassswordCode
            // 
            this.txtForgrtPassswordCode.Enabled = false;
            this.txtForgrtPassswordCode.Location = new System.Drawing.Point(194, 194);
            this.txtForgrtPassswordCode.Name = "txtForgrtPassswordCode";
            this.txtForgrtPassswordCode.Size = new System.Drawing.Size(244, 20);
            this.txtForgrtPassswordCode.TabIndex = 1;
            // 
            // btnForgetPassordNextStep
            // 
            this.btnForgetPassordNextStep.BackColor = System.Drawing.Color.Blue;
            this.btnForgetPassordNextStep.Enabled = false;
            this.btnForgetPassordNextStep.FlatAppearance.BorderSize = 0;
            this.btnForgetPassordNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPassordNextStep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassordNextStep.ForeColor = System.Drawing.Color.White;
            this.btnForgetPassordNextStep.Location = new System.Drawing.Point(99, 238);
            this.btnForgetPassordNextStep.Name = "btnForgetPassordNextStep";
            this.btnForgetPassordNextStep.Size = new System.Drawing.Size(125, 37);
            this.btnForgetPassordNextStep.TabIndex = 2;
            this.btnForgetPassordNextStep.Text = "Next Step";
            this.btnForgetPassordNextStep.UseVisualStyleBackColor = false;
            this.btnForgetPassordNextStep.Click += new System.EventHandler(this.btnForgetPassordNextStep_Click);
            // 
            // btnForgetPassordSendAgain
            // 
            this.btnForgetPassordSendAgain.BackColor = System.Drawing.Color.SeaGreen;
            this.btnForgetPassordSendAgain.Enabled = false;
            this.btnForgetPassordSendAgain.FlatAppearance.BorderSize = 0;
            this.btnForgetPassordSendAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgetPassordSendAgain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassordSendAgain.ForeColor = System.Drawing.Color.White;
            this.btnForgetPassordSendAgain.Location = new System.Drawing.Point(297, 238);
            this.btnForgetPassordSendAgain.Name = "btnForgetPassordSendAgain";
            this.btnForgetPassordSendAgain.Size = new System.Drawing.Size(125, 37);
            this.btnForgetPassordSendAgain.TabIndex = 2;
            this.btnForgetPassordSendAgain.Text = "Send Again";
            this.btnForgetPassordSendAgain.UseVisualStyleBackColor = false;
            this.btnForgetPassordSendAgain.Click += new System.EventHandler(this.btnForgetPassordSendAgain_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(12, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(481, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "_______________________________________________________________________________";
            // 
            // lblNextStep2
            // 
            this.lblNextStep2.AutoSize = true;
            this.lblNextStep2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNextStep2.Location = new System.Drawing.Point(11, 311);
            this.lblNextStep2.Name = "lblNextStep2";
            this.lblNextStep2.Size = new System.Drawing.Size(81, 19);
            this.lblNextStep2.TabIndex = 4;
            this.lblNextStep2.Text = "Next Step";
            this.lblNextStep2.Visible = false;
            // 
            // imgNextStep2
            // 
            this.imgNextStep2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgNextStep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgNextStep2.ForeColor = System.Drawing.Color.White;
            this.imgNextStep2.Image = ((System.Drawing.Image)(resources.GetObject("imgNextStep2.Image")));
            this.imgNextStep2.Location = new System.Drawing.Point(87, 303);
            this.imgNextStep2.Name = "imgNextStep2";
            this.imgNextStep2.Size = new System.Drawing.Size(38, 33);
            this.imgNextStep2.TabIndex = 5;
            this.imgNextStep2.UseVisualStyleBackColor = true;
            this.imgNextStep2.Visible = false;
            // 
            // lblNextStep1
            // 
            this.lblNextStep1.AutoSize = true;
            this.lblNextStep1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextStep1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblNextStep1.Location = new System.Drawing.Point(11, 136);
            this.lblNextStep1.Name = "lblNextStep1";
            this.lblNextStep1.Size = new System.Drawing.Size(81, 19);
            this.lblNextStep1.TabIndex = 4;
            this.lblNextStep1.Text = "Next Step";
            this.lblNextStep1.Visible = false;
            // 
            // imgNextStep1
            // 
            this.imgNextStep1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgNextStep1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgNextStep1.ForeColor = System.Drawing.Color.White;
            this.imgNextStep1.Image = ((System.Drawing.Image)(resources.GetObject("imgNextStep1.Image")));
            this.imgNextStep1.Location = new System.Drawing.Point(87, 128);
            this.imgNextStep1.Name = "imgNextStep1";
            this.imgNextStep1.Size = new System.Drawing.Size(38, 33);
            this.imgNextStep1.TabIndex = 5;
            this.imgNextStep1.UseVisualStyleBackColor = true;
            this.imgNextStep1.Visible = false;
            // 
            // forgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 500);
            this.Controls.Add(this.imgNextStep1);
            this.Controls.Add(this.imgNextStep2);
            this.Controls.Add(this.lblNextStep1);
            this.Controls.Add(this.lblNextStep2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnForgetPasswordSendMail);
            this.Controls.Add(this.btnForgetPassordSendAgain);
            this.Controls.Add(this.btnForgetPassordNextStep);
            this.Controls.Add(this.btnForgetPasswordChange);
            this.Controls.Add(this.txtForgrtPassswordCode);
            this.Controls.Add(this.txtForgetPasswordConformPassword);
            this.Controls.Add(this.txtForgetPasswordNewPassword);
            this.Controls.Add(this.txtForgetPasswordEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "forgetPassword";
            this.Text = "Password Rest";
            this.Load += new System.EventHandler(this.forgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForgetPasswordEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForgetPasswordNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtForgetPasswordConformPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnForgetPasswordChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnForgetPasswordSendMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtForgrtPassswordCode;
        private System.Windows.Forms.Button btnForgetPassordNextStep;
        private System.Windows.Forms.Button btnForgetPassordSendAgain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNextStep2;
        private System.Windows.Forms.Button imgNextStep2;
        private System.Windows.Forms.Label lblNextStep1;
        private System.Windows.Forms.Button imgNextStep1;
    }
}