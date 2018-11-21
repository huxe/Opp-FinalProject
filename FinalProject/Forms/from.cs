using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace FinalProject
{
    public partial class frmLogin : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\c#\oop\FinalProject\FinalProject\bin\Debug\DBElectronicShop.accdb");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdoSaleMan.Checked == true)
            {
                using (Forms.formHome fd = new Forms.formHome())
                {
                    CheckSaleMan();
                }
            }
            
            else if (rdoOwner.Checked == true)
            {
                string query = "select name,Email,[password] from ownerInfo";
                OleDbCommand cmd = new OleDbCommand(query, con);

                DataTable dt = new DataTable();
                con.Open();
                OleDbDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if ((rdr[0].ToString() == txtUserName.Text || rdr[1].ToString() == txtUserName.Text) && (rdr[2].ToString() == txtPassword.Text))
                    {
                        Forms.frmAdminLogin fd = new Forms.frmAdminLogin();

                        fd.ShowDialog();

                    }

                    else
                    {
                        MessageBox.Show("Incorrect User Name or password\nClick on FORGET PASSWORD to reset the password");
                    }
                }
                con.Close();
                rdr.Close();
                cmd.Dispose();
            }

            else
            {
                MessageBox.Show("Incorrect User Name or password\nClick on FORGET PASSWORD to reset the password");
            }


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public void CheckSaleMan()
        {
            bool check = true;

            string query = "select name,[password] from tblSaleMans";
            OleDbCommand cmd = new OleDbCommand(query, con);

            DataTable dt = new DataTable();
            con.Open();
            OleDbDataReader rdr = cmd.ExecuteReader();
            
                while (rdr.Read())
                {
                    if ((rdr[0].ToString() == txtUserName.Text) && (rdr[1].ToString() == txtPassword.Text))
                    {
                    Forms.formHome fd = new Forms.formHome();
                    check = false;
                    fd.Show();
                    }
                    
            }

            if (check)
            {
                MessageBox.Show("Incorrect User Name or password\nClick on FORGET PASSWORD to reset the password\n");

            }


            con.Close();
            rdr.Close();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (rdoSaleMan.Checked==true)
            {
                lblwarning.Visible = true;
            }
            else
            {
                Forms.forgetPassword fd = new Forms.forgetPassword();
                fd.Show();

            }
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.Green;
        }
    }
}
