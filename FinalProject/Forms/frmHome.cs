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

namespace FinalProject.Forms
{
    public partial class formHome : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\oop\FinalProject\FinalProject\bin\Debug\DBElectronicShop.accdb");
        string SelectedId;
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            PnlSaleMan.Controls.Clear();
            PnlSaleMan.Controls.Add(c);
        }



        int PanelWidth;
        bool iscollapse;
        public formHome()
        {
            InitializeComponent();
            PanelWidth = PanelLeft.Width;
            iscollapse = false;
            dataviewCreateuser();

        }

        public void GetSelectedDataValue()
        {

            int rowindex = dtaHome.CurrentCell.RowIndex;

            SelectedId = dtaHome.Rows[rowindex].Cells[0].Value.ToString();

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (iscollapse)
            {
                PanelLeft.Width = PanelLeft.Width + 150;



                button9.Visible = false;
                timer1.Stop();
                iscollapse = false;
                this.Refresh();

            }
            else
            {
                PanelLeft.Width = PanelLeft.Width - 150;



                button9.Visible = true;
                timer1.Stop();
                iscollapse = true;
                this.Refresh();



            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MovePanle(btnLogout);
            frmLogin ff = new frmLogin();
            ff.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MovePanle(btnHome);
        }
        private void MovePanle(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {

            MovePanle(btnRecords);
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            MovePanle(btnManageItems);
        }

        private void btnstocks_Click(object sender, EventArgs e)
        {
            MovePanle(btnstocks);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            MovePanle(btnsettings);

            UserControls.Settings uc = new UserControls.Settings();
            addControlsToPanel(uc);
        }

        private void PanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        string query;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboCatagery.Text == "ac")
            {
                query = "select * from Items where catagery='ac'";
            }

            else if (cmboCatagery.Text == "tv")
            {
                query = "select * from Items where catagery='tv'";
            }
            else if (cmboCatagery.Text == "generator")
            {
                query = "select * from Items where catagery='generator'";
            }

            con.Open();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter adb = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adb.Fill(dt);
            dtaHome.DataSource = dt;
            con.Close();
        }

        public void dataviewCreateuser()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Items", con);
            OleDbDataAdapter adb = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adb.Fill(dt);
            dtaHome.DataSource = dt;
            con.Close();
        }

        public void resetData()
        {
            dataviewCreateuser();


            txtName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            
        }

        private void PnlSaleMan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void btnRefreshCreateUser_Click(object sender, EventArgs e)
        {
            resetData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetSelectedDataValue();
            CheckRequirements();

        }

        DatabaseDB DB = new DatabaseDB();
        int num = 0001;
        DateTime dt = DateTime.Now;
        bool dataCheckButtunCheck;
        bool dataCheckUpadteData;
        public void CheckRequirements()
        {
            string[] information = { txtName.Text, txtPrice.Text, txtQuantity.Text };
            for (int i = 0; i < information.Length; i++)
            {
                if (information[i] == "")
                {
                    MessageBox.Show("FIll all the feilds");
                    break;
                }
                else if (i == 5)
                {
                    

                     if (information[i] != "" && dataCheckButtunCheck == true)

                    {
                        DB.RunQuery("insert into Record (ID,[name],[price],[date],quantity) values ('" + num + "' , '" + txtName.Text + "' , '" + txtPrice.Text + "' , '" + dt + "' , '" + txtQuantity.Text + "' )");
                        MessageBox.Show("Data has been inserted");
                        dataCheckButtunCheck = false;
                        break;
                    }

                    else if (information[i] != "" && dataCheckUpadteData == true)

                    {
                        DB.RunQuery("update Record set name='" + txtName.Text + "',[price]='" + txtPrice.Text + "',[quantity]='" + txtQuantity.Text + "')");
                        MessageBox.Show("Data has been updated");
                        dataCheckUpadteData = false;
                        break;
                    }
                }
            } 

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            GetSelectedDataValue();
            CheckRequirements();
        }
    }


}
