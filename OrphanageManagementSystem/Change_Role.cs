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
    public partial class Change_Role : Form
    {
        public Change_Role()
        {
            InitializeComponent();
        }

        Employee emp = new Employee();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable dt2 = emp.Select();
            dataGridView1.DataSource = dt2;
            textBox1.Focus(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDashboard fdb = new FormDashboard();
            fdb.Show();
            Visible = false; 
        }

        private void Change_Role_Load(object sender, EventArgs e)
        {
            foreach (var item in panel1.Controls)
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

            button3.BackColor = Color.FromArgb(140, 0, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 5;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 241, 196, 15);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 241, 196, 15);
            button3.ForeColor = Color.White;
            button3.Cursor = Cursors.Hand;

        }

        public void clear()
        {
            textBox1.Clear();
            comboBox1.Text = null;
            comboBoxRegister.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Row = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[Row].Cells[1].Value.ToString();
            comboBoxRegister.Text = dataGridView1.Rows[Row].Cells[3].Value.ToString();
        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.TryParse(textBox1.Text, out a) ? a: 0 ;
            emp.ID = a;
            emp.Role = comboBox1.Text;
            bool success = emp.UpdateRole(emp);
            if (success == true)
            {
                MessageBox.Show("Updated Successfully");
                clear();
            }
            else
            {
                MessageBox.Show("Updated Failed");
            }
            DataTable dt2 = emp.Select();


           /* for (int item = 0; item < dataGridView1.Rows.Count; item++)
            {
                if (comboBoxRegister.Text != dataGridView1.Rows[item].Cells[3].Value.ToString())
                {
                    bool success = emp.UpdateRole(emp);
                    if (success == true)
                    {
                        MessageBox.Show("Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Updated Failed");
                    }
                    DataTable dt2 = emp.Select(); 
                }
               else{
           }

            }*/

           
            

        }
    }
}
