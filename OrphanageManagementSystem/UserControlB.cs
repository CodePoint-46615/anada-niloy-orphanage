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
    public partial class UserControlB : UserControl
    {
        public UserControlB()
        {
            InitializeComponent();
        }

        private void UserControlB_Load(object sender, EventArgs e)
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

        public void Clear()
        {
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox6.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Clear(); 
        }

        Expense exp = new Expense();
        private void button4_Click(object sender, EventArgs e)
        {
            exp.product = textBox6.Text;
            exp.Description = textBox10.Text;

            int a = int.TryParse(textBox7.Text, out a) ? a : 0; 
            exp.amount = a;
            int b = int.TryParse(textBox8.Text, out b) ? b : 0;
            exp.rate = b;
            int c = int.TryParse(textBox9.Text, out c) ? c : 0;
            exp.Total = c;


            if (textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox10.Text != "")
            {
                bool success = exp.Insert(exp);
                if (success == true)
                {
                    MessageBox.Show("Data Insertion Successful");
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed");
                }

                DataTable dt4 = exp.Select();
            }
            else
            {
                MessageBox.Show("Insert all the field is Requried", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            textBox6.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt4 = exp.Select();
            dataGridView2.DataSource = dt4;
            textBox6.Focus();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = e.RowIndex;

            textBox6.Text = dataGridView2.Rows[row].Cells[0].Value.ToString();
            textBox10.Text = dataGridView2.Rows[row].Cells[1].Value.ToString();
            textBox7.Text = dataGridView2.Rows[row].Cells[2].Value.ToString();
            textBox8.Text = dataGridView2.Rows[row].Cells[3].Value.ToString();
            textBox9.Text = dataGridView2.Rows[row].Cells[4].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            exp.product = textBox6.Text;


            if (textBox6.Text != "")
            {
                bool success = exp.Delete(exp);

                if (success == true)
                {
                    MessageBox.Show("Remove Data Successful");
                }
                else
                {
                    MessageBox.Show("Remove Data Failed");
                }

                DataTable dt4 = exp.Select();
            }
            else
            {
                MessageBox.Show("Ensure Name and ID", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            textBox6.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exp.product = textBox6.Text;
            exp.Description = textBox10.Text;

            int a = int.TryParse(textBox7.Text, out a) ? a : 0;
            exp.amount = a;
            int b = int.TryParse(textBox8.Text, out b) ? b : 0;
            exp.rate = b;
            int c = int.TryParse(textBox9.Text, out c) ? c : 0;
            exp.Total = c;

            bool success = exp.Calculation(exp);
            if (success == true)
            {
                MessageBox.Show("Calculation Done");
            }
            else
            {
                MessageBox.Show("Calculation Not Done");
            }
            DataTable dt4 = exp.Select();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
