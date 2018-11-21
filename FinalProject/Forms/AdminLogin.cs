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
    public partial class frmAdminLogin : Form
    {
        int PanelWidth;
        bool iscollapse;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\c#\oop\FinalProject\FinalProject\bin\Debug\DBElectronicShop.accdb");


        private void MovePanle(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }

        public frmAdminLogin()
        {
            InitializeComponent();
            PanelWidth = PanelLeft.Width;
            iscollapse = false;
            UserControls.ucAdminReports uc = new UserControls.ucAdminReports();
            addControlsToPanel(uc);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
        }

        private void moveToPanel(Control btn)
        {
            pnlMainAdmin.Height = btn.Height;
            pnlMainAdmin.Top = btn.Top;
        }
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlMainAdmin.Controls.Clear();
            pnlMainAdmin.Controls.Add(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MovePanle(btnAdminLogout);
            frmLogin f = new frmLogin();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MovePanle(btnAdminCreateUser);

            con.Open();
            moveToPanel(btnAdminCreateUser);
            UserControls.ucCreateUser uc = new UserControls.ucCreateUser();
            addControlsToPanel(uc);
            con.Close();
            uc.dataviewCreateuser();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MovePanle(btnAdminReports);
            moveToPanel(btnAdminReports);
            UserControls.ucAdminReports uc = new UserControls.ucAdminReports();
            addControlsToPanel(uc);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnAdminManageItems_Click(object sender, EventArgs e)
        {
            MovePanle(btnAdminManageItems);
            UserControls.ucManageItems uc = new UserControls.ucManageItems();
            uc.resetData();
            addControlsToPanel(uc);
        }

        private void btnAdminRecord_Click(object sender, EventArgs e)
        {
            MovePanle(btnAdminRecord);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iscollapse)
            {
                PanelLeft.Width = PanelLeft.Width + 160;

                button9.Visible = false;
                timer1.Stop();
                iscollapse = false;
                this.Refresh();

            }
            else
            {
                PanelLeft.Width = PanelLeft.Width - 160;

                button9.Visible = true;
                timer1.Stop();
                iscollapse = true;
                this.Refresh();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}