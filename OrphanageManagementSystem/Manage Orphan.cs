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
    public partial class Manage_Orphan : Form
    {
        OrphanManage om = new OrphanManage();

        public Manage_Orphan()
        {
            InitializeComponent();
        }

        private void Manage_Orphan_Load(object sender, EventArgs e)
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
        }

 
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.Text = null;
            textBox1.Focus();
        }

        //textbox: 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        
        
      
        //Buttons: 
        private void button1_Click(object sender, EventArgs e)
        {
            int f = int.TryParse(textBox9.Text, out f) ? f : 0;
            om.orphanID = f;

            

            if (textBox9.Text != "" && textBox1.Text != "" )
            {
                bool success = om.Delete(om);
                if (success == true)
                {
                    MessageBox.Show("Remove Data Successful");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Remove Data Failed");
                }

                DataTable dt1 = om.select();
            }
            else
            {

                MessageBox.Show("Ensure Name and ID", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt1 = om.select();
            dataGridView1.DataSource = dt1;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Be Careful! You're leaving this page right now", "Go Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                FormDashboard fdb = new FormDashboard();
                fdb.Show();
                Visible = false;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int f = int.TryParse(textBox9.Text, out f) ? f : 0;
            om.orphanID = f;
            int c = int.TryParse(textBox2.Text, out c) ? c : 0;
            om.Age = c;

            om.Name = textBox1.Text;
            om.orphanGender = comboBox1.Text;
            om.BloodGroup = textBox4.Text;
            om.orphanCustodianName = textBox5.Text;
            om.Number = textBox6.Text;
            om.Address = textBox8.Text;
            om.Email = textBox7.Text;

            for (int item = 0; item < dataGridView1.Rows.Count; item++)
            {
                if (textBox9.Text == dataGridView1.Rows[item].Cells[0].Value.ToString() || textBox7.Text == dataGridView1.Rows[item].Cells[8].Value.ToString() || textBox6.Text == dataGridView1.Rows[item].Cells[6].Value.ToString())
                {
                    MessageBox.Show("Show Duplicacy!!");
                    return;
                }
            }


            if (textBox9.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && comboBox1.Text != "")
            {
                bool success = om.Insert(om);
                if (success == true)
                {
                    MessageBox.Show("Data Insertion Successful");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion Failed!");
                }
                DataTable dt1 = om.select();
            }
            else
            {
                MessageBox.Show("Insert all the field is Requried", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            textBox1.Focus();
        }


        //DataGridView: 
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row_index = e.RowIndex;

            textBox9.Text = dataGridView1.Rows[row_index].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[row_index].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[row_index].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[row_index].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[row_index].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[row_index].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[row_index].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[row_index].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.Rows[row_index].Cells[8].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
