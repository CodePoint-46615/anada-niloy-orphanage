using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrphanageManagementSystem
{ 
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }
        MyConnection db = new MyConnection();

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            //panel design
            panelLogIn.BackColor = Color.FromArgb(30, 0, 0, 0);

            //button design
            foreach (var item in panelLogIn.Controls)
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

                buttonLogBk.BackColor = Color.FromArgb(140, 0, 0, 0);
                buttonLogBk.FlatStyle = FlatStyle.Flat;
                buttonLogBk.FlatAppearance.BorderColor = Color.White;
                buttonLogBk.FlatAppearance.BorderSize = 5;
                buttonLogBk.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 241, 196, 15);
                buttonLogBk.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 241, 196, 15);
                buttonLogBk.ForeColor = Color.White;
                buttonLogBk.Cursor = Cursors.Hand;
            }

        }

        //Labels: 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Textfields: 
        private void textBoxLogPW_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void textBoxLogUN_TextChanged(object sender, EventArgs e)
        {
           
        }

        //Buttons: 
        private void buttonLogLI_Click(object sender, EventArgs e)
        {
            try
            {
                using (db.con)
                {
                    SqlCommand cmd = new SqlCommand("role_login", db.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    db.con.Open();
                    cmd.Parameters.AddWithValue("@uname", textBoxLogUN.Text);
                    cmd.Parameters.AddWithValue("@upass", textBoxLogPW.Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[2].ToString() == "Supervisor")
                        {
                            MyConnection.type = "S"; 
                        }
                        else if (rd[2].ToString() == "Teacher")
                        {
                            MyConnection.type = "T";
                        }
                        else if (rd[2].ToString() == "Accountant")
                        {
                            MyConnection.type = "A";
                        }
                        else if (rd[2].ToString() == "CareTaker")
                        {
                            MyConnection.type = "CT";
                        }
                        if (rd[2].ToString() == "SecurityGuard")
                        {
                            MyConnection.type = "SG";
                        }

                        FormDashboard fdb = new FormDashboard();
                        fdb.Show();
                        Visible = false;
                    }
                    else
                    {
                       if(MessageBox.Show("Something Wrong", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK);
                       
                            FormHome fh = new FormHome();
                            fh.Show();
                            Visible = false;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBoxLogUN.Clear();
            textBoxLogPW.Clear();

            textBoxLogUN.Focus();
        }

        private void buttonLogBk_Click(object sender, EventArgs e)
        {
            FormHome fh = new FormHome();
            fh.Show();
            Visible = false;
        }

        private void buttonLogSP2_Click(object sender, EventArgs e)
        {
            if (textBoxLogPW.PasswordChar == '*')
            {
                buttonLogSP1.BringToFront();
                textBoxLogPW.PasswordChar = '\0'; 
            }
        }

        private void buttonLogSP1_Click(object sender, EventArgs e)
        {
            if (textBoxLogPW.PasswordChar == '\0')
            {
                buttonLogSP2.BringToFront();
                textBoxLogPW.PasswordChar = '*';
            }
        }

        //Panel
        private void panelLogIn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
