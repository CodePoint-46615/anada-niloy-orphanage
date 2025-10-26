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
    public partial class Manage_Employee : Form
    {
        public Manage_Employee()
        {
            InitializeComponent();
        }
        MyConnection mc = new MyConnection(); 
  

        private void button4_Click(object sender, EventArgs e)
        {
            FormDashboard fdb = new FormDashboard();
            fdb.Show();
            Visible = false; 
        }

        private void Manage_Employee_Load(object sender, EventArgs e)
        {
            foreach(var item in panel1.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.BackColor = Color.FromArgb(140, 0, 0, 0);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.BorderSize = 2;
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 241, 196, 15);
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 241, 196, 15);
                    btn.ForeColor = Color.White;
                    btn.Cursor = Cursors.Hand;
                }

                button4.BackColor = Color.FromArgb(140, 0, 0, 0);
                button4.FlatStyle = FlatStyle.Flat;
                button4.FlatAppearance.BorderColor = Color.White;
                button4.FlatAppearance.BorderSize = 5;
                button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 241, 196, 15);
                button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 241, 196, 15);
                button4.ForeColor = Color.White;
                button4.Cursor = Cursors.Hand;
            }


        }

        public void Clear()
        {
            textBoxName.Clear();
            textBoxID.Clear();
            textBoxEmail.Clear();
            textBoxPR.Clear();
            textBoxMN.Clear();
            textBox11.Clear();
            comboBoxRole.Text = null;
            textBoxName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear(); 
        }

        Employee em = new Employee();

        private void button7_Click(object sender, EventArgs e)
        {
            em.Name = textBoxName.Text ;
            int a = int.TryParse(textBoxID.Text, out a) ? a : 0;
            em.ID = a ;
            em.Email = textBoxEmail.Text;
            em.Role = comboBoxRole.Text;
            em.PreferableTIme = textBoxPR.Text;
            em.MobileNumber = textBoxMN.Text;

            for (int item = 0; item < dataGridView1.Rows.Count; item++)
            {
                if(textBoxID.Text == dataGridView1.Rows[item].Cells[1].Value.ToString() || textBoxEmail.Text == dataGridView1.Rows[item].Cells[2].Value.ToString() || textBoxMN.Text == dataGridView1.Rows[item].Cells[5].Value.ToString())
                {
                    MessageBox.Show("Show Duplicacy!!");
                    return; 
                }
            }
             

            if(textBoxName.Text != "" && textBoxID.Text != "" && textBoxEmail.Text != "" && textBoxPR.Text != "" && textBoxMN.Text != "")
            {
                bool success = em.Insert(em);
                if (success == true)
                {
                    MessageBox.Show("Data Insertion Successful");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }

                DataTable dt2 = em.Select(); 
            }
            else
            {
                MessageBox.Show("Insert all the field is Requried", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            textBoxName.Focus();
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt2 = em.Select();
            dataGridView1.DataSource = dt2;
            textBoxName.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.TryParse(textBoxID.Text, out a) ? a : 0;
            em.ID = a;


            if (textBoxName.Text != "" && textBoxID.Text != "")
            {
                bool success = em.Delete(em);
                if (success == true)
                {
                    MessageBox.Show("Remove Data Successful");
                }
                else
                {
                    MessageBox.Show("Remove Data Failed");
                }

                DataTable dt2 = em.Select();
            }
            else
            {
                MessageBox.Show("Ensure Name and ID", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            textBoxName.Focus();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            textBoxName.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textBoxID.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            textBoxEmail.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            comboBoxRole.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            textBoxPR.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
            textBoxMN.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
        }
    }
}
