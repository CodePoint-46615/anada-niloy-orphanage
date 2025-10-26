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
    public partial class UserControlA : UserControl
    {
        public UserControlA()
        {
            InitializeComponent();
        }

        private void UserControlA_Load(object sender, EventArgs e)
        {
             
            foreach (var item in panel2Ex.Controls)
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

            }
        }
        public void Reset()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox1.Focus();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Reset();
        }

        Donor d = new Donor();
        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.TryParse(textBox3.Text, out a) ? a : 0;
            d.donorID = a ;
            d.donorName = textBox1.Text;
            d.donorEmail = textBox4.Text;
            d.donorAddress = textBox2.Text;
            d.donationAmount = textBox5.Text.ToString(); 
           

            for (int item = 0; item < dataGridView1.Rows.Count; item++)
            {
                if (textBox3.Text == dataGridView1.Rows[item].Cells[0].Value.ToString() || textBox4.Text == dataGridView1.Rows[item].Cells[3].Value.ToString())
                {
                    MessageBox.Show("Show Duplicacy!!");
                    return;
                }
            }


            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                bool success = d.Insert(d);
                if (success == true)
                {
                    MessageBox.Show("Data Insertion Successful");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }

                DataTable dt3 = d.Select();
            }
            else
            {
                MessageBox.Show("Insert all the field is Requried", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            textBox1.Focus();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt3 = d.Select();
            dataGridView1.DataSource = dt3;
            textBox1.Focus();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            textBox3.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = int.TryParse(textBox3.Text, out a) ? a : 0;
            d.donorID = a;


            if (textBox1.Text != "" && textBox3.Text != "")
            {
                bool success = d.Delete(d);
                if (success == true)
                {
                    MessageBox.Show("Remove Data Successful");
                }
                else
                {
                    MessageBox.Show("Remove Data Failed");
                }

                DataTable dt3 = d.Select();
            }
            else
            {
                MessageBox.Show("Ensure Name and ID", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.TryParse(textBox3.Text, out a) ? a : 0;
            d.donorID = a;
            d.donorName = textBox1.Text;
            d.donorEmail = textBox4.Text;
            d.donorAddress = textBox2.Text;
            d.donationAmount = textBox5.Text;

            if (textBox3.Text == dataGridView1.CurrentRow.Cells[0].Value.ToString() && textBox4.Text == dataGridView1.CurrentRow.Cells[3].Value.ToString())
            {
                bool success = d.Update(d);
                if (success == true)
                {
                    MessageBox.Show("Data Update Successful");
                }
                else
                {
                    MessageBox.Show("Data Update Failed");
                }


                DataTable dt3 = d.Select();
            }
            else
            {
                MessageBox.Show("Access Deny");
            }

            textBox1.Focus();
        }
    }
}
