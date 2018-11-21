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
    public partial class ucManageItems : UserControl
    {
        //Globel Variables
        string SelectedId;

        bool checkinsert = false;
        bool checkUpdate = false;


        //Main Connection TO database
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\oop\FinalProject\FinalProject\bin\Debug\DBElectronicShop.accdb");


        //Check Requirements
        public void CheckRequirements()
        {
            
            string[] information = {txtCatagery.Text, txtBrand.Text, txtName.Text, txtPPrice.Text, txtSPrice.Text, txtQuantity.Text };
            for (int i = 0; i < information.Length; i++)
            {
                if (information[i] == "")
                {
                    MessageBox.Show("FIll all the feilds");
                    break;
                }
                else if (i == 5)
                {
                     if (information[i] != "" && checkinsert == true)

                    {
                        InsertData();
                        break;
                    }

                    else if (information[i] != ""  && checkUpdate == true)

                    {
                        UpdateData();
                        break;
                    }
                } 
            }

        }


        // Get Selected Value


        public void GetSelectedDataValue()
        {

            int rowindex = dtaManageItems.CurrentCell.RowIndex;

            SelectedId = dtaManageItems.Rows[rowindex].Cells[0].Value.ToString();

        }


        //Add data to dataGrirdView

        public void dataviewCreateuser()
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Items", con);
            OleDbDataAdapter adb = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adb.Fill(dt);
            dtaManageItems.DataSource = dt;
            con.Close();
        }


        //Reset Data


        private void btnRefresh_Click(object sender, EventArgs e)
        {
                        resetData();

        }

        public void resetData()
        {
            dataviewCreateuser();
            btnUpdate.Enabled = true;
            btnAdd.Enabled = true;

            txtCatagery.Text = "";
            txtBrand.Text = "";
            txtName.Text = "";
            txtSPrice.Text = "";
            txtPPrice.Text = "";
            txtQuantity.Text = "";

        }



        //Insert Data


        public void InsertData()
        {

            string query = "insert into Items (catagery,brand,name,sprice,pprice,quantity) values ('" + txtCatagery.Text + "' , '" + txtBrand.Text + "' , '" + txtName.Text + "' , '" + txtSPrice.Text + "' , '" + txtPPrice.Text + "' , '" + txtQuantity.Text + "')";
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been inserted");
            this.Refresh();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;

            checkinsert = true;
            CheckRequirements();
        }


        //Delete data


        private void button4_Click_1(object sender, EventArgs e)
        {
            OleDbCommand delcmd = new OleDbCommand();

            con.Open();

            try
            {

                GetSelectedDataValue();

                delcmd.CommandText = "DELETE FROM Items WHERE ID=" + int.Parse(SelectedId) + "";
                delcmd.Connection = con;
                int count = delcmd.ExecuteNonQuery();

                con.Close();

                dtaManageItems.Rows.RemoveAt(this.dtaManageItems.SelectedRows[0].Index);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //Update data


        private void button3_Click_1(object sender, EventArgs e)
        {
            checkinsert = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;

            string[] a = new string[7];
            for (int i = 0; i < 7; i++)
            {

                int rowindex = dtaManageItems.CurrentCell.RowIndex;
                a[i] = dtaManageItems.Rows[rowindex].Cells[i].Value.ToString();

                switch (i)
                {
                    case 1: txtCatagery.Text = a[i]; break;
                    case 2: txtBrand.Text = a[i]; break;
                    case 3: txtName.Text = a[i]; break;
                    case 4: txtSPrice.Text = a[i]; break;
                    case 5: txtPPrice.Text = a[i]; break;
                    case 6: txtQuantity.Text = a[i]; break;
                }

            }
            this.Refresh();

        }



        public void UpdateData()
        {

            string UpdateQuery = "update Items set catagery='" + txtCatagery.Text + "',brand='" + txtBrand.Text + "',name='" + txtName.Text + "',sprice='" + txtPPrice.Text + "',pprice='" + txtSPrice.Text + "',quantity='" + txtQuantity.Text + "' where ID=" + SelectedId + "";
            OleDbCommand cmd = new OleDbCommand(UpdateQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Has Been Updated");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetSelectedDataValue();
            checkUpdate = true;
            CheckRequirements();

        }



        public ucManageItems()
        {
            InitializeComponent();
        }
        string query;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmboSearchItems.Text=="ac")
            {
                query = "select * from Items where catagery='ac'";
            }

            else if (cmboSearchItems.Text=="tv")
            {
                query = "select * from Items where catagery='tv'";
            }
            else if (cmboSearchItems.Text == "generator")
            {
                query = "select * from Items where catagery='generator'";
            }

            con.Open();
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter adb = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adb.Fill(dt);
            dtaManageItems.DataSource = dt;
            con.Close();
        }

        private void dtaManageItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
