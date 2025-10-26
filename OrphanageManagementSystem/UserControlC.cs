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
    public partial class UserControlC : UserControl
    {
        public UserControlC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Focus(); 
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The field is under construction");
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlC_Load(object sender, EventArgs e)
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
    }
}
