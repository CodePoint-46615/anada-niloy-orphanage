using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OrphanageManagementSystem
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        Register r = new Register();
        String prefarableTime; 


        private void Form1_Load(object sender, EventArgs e)
        {
            panelRegister.BackColor = Color.FromArgb(30, 0, 0, 0);  //transparent 


            //button design
            foreach (var item in panelRegister.Controls)
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

        
        //labels 

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void labelDutyEnd_Click(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        //Validation 
        public bool isvalid_firstName(string n)
        {
            bool valid = false;
            Regex check = new Regex(@"^\w+( +\w+)*$");
            valid = check.IsMatch(n);
            if (valid == true)
            {
                r.firstName = text1stName.Text;
            }
            else
            {
                text1stName.Focus();
            }


            return valid;
        }

        public bool isvalid_Number(string n)
        {

            bool valid = false;
            Regex check = new Regex(@"^[0-9]{11}$");
            valid = check.IsMatch(n);
            if (valid == true)
            {
                r.Number = textPhone.Text;
            }
            else
            {
                textPhone.Focus(); 
            }


            return valid;  
        }

        public bool isvalid_Email(string n)
        {
            bool valid = false;
            Regex check = new Regex(@"^([a-zA-Z0-9._%-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,})$");
            valid = check.IsMatch(n);
            if (valid == true)
            {
                r.Email = textBoxEmail.Text;
            }
            else
            {
                textBoxEmail.Focus(); 
            }
            return valid;
        }



        //Button 

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("First complete your registration otherwise your registration will not be completed if you leave this page right now.", "Go Back", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                FormHome fh = new FormHome();
                fh.Show();
                Visible = false;
            }
            
        }

        public void Reset()
        {
            text1stName.Clear();
            textLastName.Clear();
            textBoxEmail.Clear();
            comboBoxRegister.Text = null;
            textBlood.Clear();
            day.Checked = false;
            Night.Checked = false;
            textPhone.Clear();
            textAge.Clear();
            textExp.Clear();

            text1stName.Focus();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset(); 
        }

 
        

        private void lableRegistration_Click(object sender, EventArgs e)
        {
            //get the data from the input fields
            isvalid_firstName(text1stName.Text);
            
            r.lastName = textLastName.Text;
            isvalid_Email(textBoxEmail.Text);

            isvalid_Number(textPhone.Text);
            

            r.Role = comboBoxRegister.Text;
            r.Age = textAge.Text;
            r.userName = textBlood.Text;
            r.Password = textExp.Text;

            if(isvalid_firstName(text1stName.Text) && isvalid_Email(textBoxEmail.Text) && isvalid_Number(textPhone.Text))
            {
                bool success = r.Insert(r);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }

                DataTable dt = r.Select(); 
            }
            else
            {
                MessageBox.Show("try Again"); 
                
            }
            
        }



        //textbox 

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }


        //database 
        private void GetRegistrationRecord()
        {
            //database 
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        //radio button 
        private void Night_CheckedChanged(object sender, EventArgs e)
        {
            r.prefarableTime = "NIGHT";
        }

        private void day_CheckedChanged(object sender, EventArgs e)
        {
            r.prefarableTime = "DAY"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxEmail.Text != "")
            {
                textBlood.Text = textBoxEmail.Text;
            }
            else
            {
                MessageBox.Show("Set a Valid Email");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBoxEmail.Text != "")
            {
                textBlood.Text = textPhone.Text;
            }
            else
            {
                MessageBox.Show("Set a Valid Number");
            }
        }

        private void textBlood_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
