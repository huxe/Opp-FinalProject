using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalProject.UserControls
{

    public partial class ucCreateUser : UserControl
    {
        DatabaseDB DB = new DatabaseDB();
        //Globel Variables
        string SelectedId;

        OleDbCommand delcmd = new OleDbCommand();
        bool dataCheckButtunCheck = false;
        bool dataCheckUpadteData = false;


        //Main Connection TO database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\oop\FinalProject\FinalProject\bin\Debug\DBElectronicShop.accdb");
        public ucCreateUser()
        {
            InitializeComponent();
            
        }

        //Check All Requirements for update or insert data


        public void CheckRequirements()
        {
            string[] information = { txtUser.Text, txtPassword.Text, txtContact.Text, txtConformPassword.Text, txtCnic.Text, txtAddress.Text };
            for (int i = 0; i < information.Length; i++)
            {
                if (information[i] == "")
                {
                    MessageBox.Show("FIll all the feilds");
                    break;
                }
                else if (i==5)
                {

                    if (information[1] != information[3])
                    {
                        MessageBox.Show("password does not match");
                        break;
                    }

                    else if (information[i] != "" && information[1] == information[3] && dataCheckButtunCheck == true)

                    {
                        DB.RunQuery("insert into tblSaleMans (name,[password],[ConformPassword],contact,address,cnic) values ('" + txtUser.Text + "' , '" + txtPassword.Text + "' , '" + txtConformPassword.Text + "' , '" + txtContact.Text + "' , '" + txtAddress.Text + "' , '" + txtCnic.Text + "')");
                        MessageBox.Show("Data has been inserted");
                        break;
                    }

                    else if (information[i] != "" && information[1] == information[3] && dataCheckUpadteData == true)

                    {
                        DB.RunQuery("update tblSaleMans set name='" + txtUser.Text + "',[password]='" + txtPassword.Text + "',[ConformPassword]='" + txtConformPassword.Text + "',contact='" + txtContact.Text + "',address='" + txtAddress.Text + "',cnic='" + txtCnic.Text + "' where ID=" + SelectedId + "");
                        break;
                    }
                }
            }

        }


        // Get Selected Value


        public void GetSelectedDataValue()
        {

            int rowindex = dtagrdUserInformation.CurrentCell.RowIndex;

            SelectedId = dtagrdUserInformation.Rows[rowindex].Cells[0].Value.ToString();

        }


        //Add data to dataGrirdView

        public void dataviewCreateuser()
        {
            OleDbCommand cmd = new OleDbCommand("select * from tblSaleMans", con);
            OleDbDataAdapter adb = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adb.Fill(dt);
            dtagrdUserInformation.DataSource = dt;
            con.Close();
        }


        //Reset Data


        private void btnRefreshCreateUser_Click(object sender, EventArgs e)
        {
            dataviewCreateuser();
            btnCreateUserUpdate1.Enabled = true;
            btnCreateUserSingUp.Enabled = true;
            resetData();

        }

        public void resetData()
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtConformPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtCnic.Text = "";

        }
        

        //Insert Data


        
        private void button1_Click_1(object sender, EventArgs e)
        {
            btnCreateUserSingUp.Enabled = true;
            btnCreateUserUpdate1.Enabled = false;

            dataCheckButtunCheck = true;
            CheckRequirements();
        }


        

        private void button3_Click(object sender, EventArgs e)
        {
                
            
                con.Open();
                
                        try
                        {

                GetSelectedDataValue();

                DB.RunQuery("DELETE FROM tblSaleMans WHERE ID=" + int.Parse(SelectedId) + "");
                dtagrdUserInformation.Rows.RemoveAt(this.dtagrdUserInformation.SelectedRows[0].Index);
                MessageBox.Show("Data Has Been Deleted");

            }

            catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

    
        //Update data


        private void button2_Click(object sender, EventArgs e)
        {
            dataCheckButtunCheck = false;
            btnCreateUserSingUp.Enabled = false;
            btnCreateUserUpdate1.Enabled = true;

            string[] a=new string[7] ;
            for (int i = 0; i < 7; i++)
            {

            int rowindex = dtagrdUserInformation.CurrentCell.RowIndex;
            a[i] = dtagrdUserInformation.Rows[rowindex].Cells[i].Value.ToString();
                
                switch (i)
                {
                    case 1:txtUser.Text=a[i]; break;
                    case 2: txtPassword.Text = a[i]; break;
                    case 3: txtConformPassword.Text = a[i]; break;
                    case 4: txtContact.Text = a[i]; break;
                    case 5: txtAddress.Text = a[i]; break;
                    case 6: txtCnic.Text = a[i]; break;
                }

            }
            this.Refresh();

        }


        
        private void btnCreateUserUpdate1_Click(object sender, EventArgs e)
        {
            GetSelectedDataValue();
            dataCheckUpadteData = true;
            CheckRequirements();

        }
        
    }
}
 