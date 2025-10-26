using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrphanageManagementSystem
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            foreach (var item in panelDb.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.BackColor = Color.FromArgb(140, 0, 0, 0);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.BorderSize = 5;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 241, 196, 15);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 241, 196, 15);
                    btn.ForeColor = Color.White;
                    btn.Cursor = Cursors.Hand;
                }

                buttonDbBack.BackColor = Color.FromArgb(140, 0, 0, 0);
                buttonDbBack.FlatStyle = FlatStyle.Flat;
                buttonDbBack.FlatAppearance.BorderColor = Color.White;
                buttonDbBack.FlatAppearance.BorderSize = 2;
                buttonDbBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 241, 196, 15);
                buttonDbBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 241, 196, 15);
                buttonDbBack.ForeColor = Color.White;
                buttonDbBack.Cursor = Cursors.Hand;
            }

            if (MyConnection.type == "S")
            {
                button2.Visible = true;
                button3.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                buttonDB1.Visible = true;
                buttonDbBack.Visible = true;
            }
            else if (MyConnection.type == "T")
            {
                button2.Visible = false;
                button3.Visible = true;
                button7.Visible = false;
                button8.Visible = false;
                buttonDB1.Visible = true;
                buttonDbBack.Visible = true;
            }
            else if (MyConnection.type == "A")
            {
                button2.Visible = false;
                button3.Visible = false;
                button7.Visible = true;
                button8.Visible = false;
                buttonDB1.Visible = true;
                buttonDbBack.Visible = true;
            }
            else if (MyConnection.type == "CT")
            {
                button2.Visible = false;
                button3.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                buttonDB1.Visible = true;
                buttonDbBack.Visible = true;
            }
            else if (MyConnection.type == "SG")
            {
                button2.Visible = false;
                button3.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                buttonDB1.Visible = true;
                buttonDbBack.Visible = true;
            }
        }

        private void buttonDbBack_Click(object sender, EventArgs e)
        {
            FormLogIn flg = new FormLogIn();
            flg.Show();
            Visible = false; 
        }

        private void buttonDB1_Click(object sender, EventArgs e)
        {
            ViewProfile vp = new ViewProfile();
            vp.Show();
            Visible = false; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FinancialManagement fm = new FinancialManagement();
            fm.Show();
            Visible = false; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Orphan mo = new Manage_Orphan();
            mo.Show();
            Visible = false; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Employee me = new Manage_Employee();
            me.Show();
            Visible = false; 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Change_Role cr = new Change_Role();
            cr.Show();
            Visible = false; 
        }
    }
}
