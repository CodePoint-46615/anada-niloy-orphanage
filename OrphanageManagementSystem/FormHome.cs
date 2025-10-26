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
    public partial class FormHome : Form
    {
        int x = 0, y = 124; 
        public FormHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panel design 
            panelHome.BackColor = Color.FromArgb(30,0,0,0);  //transparent 


            //button design
            foreach (var item in panelHome.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button) item;
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


            buttonHomeExit.BackColor = Color.FromArgb(140, 0, 0, 0);
            buttonHomeExit.FlatStyle = FlatStyle.Flat;
            buttonHomeExit.FlatAppearance.BorderColor = Color.White;
            buttonHomeExit.FlatAppearance.BorderSize = 5;
            buttonHomeExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 241, 196, 15);
            buttonHomeExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 241, 196, 15);
            buttonHomeExit.ForeColor = Color.White;
            buttonHomeExit.Cursor = Cursors.Hand;

            //dynamicHomeNote
            timerHomeNote.Interval = 5; 
            timerHomeNote.Start(); 
            
            
        }

        //panel: 
        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        //timer: 
        private void timer1_Tick(object sender, EventArgs e)
        {
            
             /*String firstletter = labelHomeNote.Text.Substring(0, 1);
             String starttext = labelHomeNote.Text.Substring(1, labelHomeNote.Text.Length -1);
             string finalstr = starttext + firstletter;
             labelHomeNote.Text = finalstr; */

            labelHomeNote.SetBounds(x, y, 1, 1);
            x--;
            if (x <= -400)
            {
                x = 50; 
            }

        }

        //Labels: 
        private void labelHomeNote_Click(object sender, EventArgs e)
        {

        }

        //Buttons: 
        private void buttonHomeLogIn_MouseClick(object sender, MouseEventArgs e)
        {
            FormLogIn flin = new FormLogIn();
            flin.Show();
            Visible = false; 
        }

        private void buttonHomeRegister_Click(object sender, EventArgs e)
        {
            FormRegister fg = new FormRegister();
            fg.Show();
            Visible = false; 
        }

        private void buttonHomeExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "Exit Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       
    }
}
