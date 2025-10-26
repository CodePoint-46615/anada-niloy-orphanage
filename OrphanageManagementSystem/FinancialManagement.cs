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
    public partial class FinancialManagement : Form
    {
        public FinancialManagement()
        {
            InitializeComponent();
        }

        private void FinancialManagement_Load(object sender, EventArgs e)
        {

            foreach (var item in panel1.Controls)
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

            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            userControlA1.Show();
            userControlB1.Hide();
            userControlC1.Hide();
            userControlA1.BringToFront(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControlB1.Show();
            userControlA1.Hide();
            userControlC1.Hide();
            userControlB1.BringToFront(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControlC1.Show();
            userControlA1.Hide();
            userControlB1.Hide();
            userControlC1.BringToFront(); 
        }
       
        private void button9_Click(object sender, EventArgs e)
        {
            FormDashboard fdb = new FormDashboard();
            fdb.Show();
            Visible = false; 
        }

        private void userControlC1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
