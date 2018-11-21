using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;

namespace FinalProject.Forms
{
    public partial class forgetPassword : Form
    {
        Random rnd = new Random();
      public int code ;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\oop\FinalProject\FinalProject\bin\Debug\DBElectronicShop.accdb");

        public forgetPassword()
        {
            InitializeComponent();
        }

        private void forgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void mail()
        {

            code = rnd.Next(123123, 999999);
            const string p = "uxe.ahmed2@gmail.com";


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress("huxe.ahmed9@gmail.com");
            message.To.Add(new MailAddress("m.umar7288@gmail.com"));
            message.Subject = "change password";
            message.Body = "Write this given code on text box\n" + code + "\nThank you!";

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("huxe.ahmed9@gmail.com", p);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
            MessageBox.Show("Email has been sent");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            

            string query = "select Email from ownerInfo";
            OleDbCommand cmd = new OleDbCommand(query, con);

            DataTable dt = new DataTable();
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            string txtboxEmail = txtForgetPasswordEmail.Text;
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    if (txtboxEmail ==  dr[dc].ToString())
                    {
                        lblNextStep1.Visible = true;
                        imgNextStep1.Visible = true;

                        txtForgrtPassswordCode.Enabled = true;
                        btnForgetPassordNextStep.Enabled = true;
                        btnForgetPassordSendAgain.Enabled = true;
                        btnForgetPasswordSendMail.Enabled = false;

                        mail();
                    }
                    else
                    {
                        MessageBox.Show("This email is not exisit in the given data");

                    }


                }
            }
            


        }

        

        private void btnForgetPassordNextStep_Click(object sender, EventArgs e)
        {

            if (code.ToString() == txtForgrtPassswordCode.Text)
            {
                lblNextStep2.Visible = true;
                imgNextStep2.Visible = true;

                txtForgetPasswordConformPassword.Enabled = true;
                txtForgetPasswordNewPassword.Enabled = true;
                btnForgetPasswordChange.Enabled = true;
                btnForgetPassordNextStep.Enabled = false;
                btnForgetPassordSendAgain.Enabled = false;
            }

            else
            {
                MessageBox.Show("Code doesent Match");
            }
        }

        private void btnForgetPassordSendAgain_Click(object sender, EventArgs e)
        {
            mail();
            
        }

        private void btnForgetPasswordChange_Click(object sender, EventArgs e)
        {
            if (txtForgetPasswordNewPassword.Text==txtForgetPasswordConformPassword.Text)
            {
                string query = "update ownerInfo set [password]='"+txtForgetPasswordConformPassword.Text+"' where ID=1";
                OleDbCommand cmd = new OleDbCommand(query,con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Pasword changes succussfully");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("password dosent match");
            }
        }


        }
    }

