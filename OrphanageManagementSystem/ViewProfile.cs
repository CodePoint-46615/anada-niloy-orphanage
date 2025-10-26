using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrphanageManagementSystem
{
    public partial class ViewProfile : Form
    {
        MyConnection mcv = new MyConnection();
        Register u = new Register();

        public ViewProfile()
        {
            InitializeComponent();
        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            buttonProfile.BackColor = Color.FromArgb(140, 0, 0, 0);
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.FlatAppearance.BorderColor = Color.White;
            buttonProfile.FlatAppearance.BorderSize = 5;
            buttonProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 241, 196, 15);
            buttonProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 241, 196, 15);
            buttonProfile.ForeColor = Color.White;
            buttonProfile.Cursor = Cursors.Hand;

        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormDashboard fdb = new FormDashboard();
            fdb.Show();
            Visible = false; 
        }

         
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            DataTable dt = u.Select();
            dataGridView1.DataSource = dt; 
           /* if (MyConnection.type == "S")
            {
                DataTable dt = u.Select();
                dataGridView1.DataSource = dt;
            }
            else if(MyConnection.type == "T")
            {
                DataTable dtT = u.Techer();
                dataGridView1.DataSource = dtT; 
            }
            else if (MyConnection.type == "A")
            {
                DataTable dtA = u.Accountant();
                dataGridView1.DataSource = dtA; 
            }
            else if (MyConnection.type == "CT")
            {
                DataTable dtC = u.Caretaker();
                dataGridView1.DataSource = dtC; 
            }
            else if(MyConnection.type == "SG")
            {
                DataTable dtSG = u.SecurityGuard();
                dataGridView1.DataSource = dtSG; 

            }*/
        }

        private void labelVP1_Click(object sender, EventArgs e)
        {

        }
    }
}
