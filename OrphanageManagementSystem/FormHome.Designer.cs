
namespace OrphanageManagementSystem
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.labelHomeHeading = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.labelHomeNote = new System.Windows.Forms.Label();
            this.buttonHomeRegister = new System.Windows.Forms.Button();
            this.buttonHomeLogIn = new System.Windows.Forms.Button();
            this.buttonHomeExit = new System.Windows.Forms.Button();
            this.timerHomeNote = new System.Windows.Forms.Timer(this.components);
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHomeHeading
            // 
            resources.ApplyResources(this.labelHomeHeading, "labelHomeHeading");
            this.labelHomeHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHomeHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelHomeHeading.Name = "labelHomeHeading";
            // 
            // panelHome
            // 
            resources.ApplyResources(this.panelHome, "panelHome");
            this.panelHome.Controls.Add(this.labelHomeNote);
            this.panelHome.Controls.Add(this.buttonHomeRegister);
            this.panelHome.Controls.Add(this.buttonHomeLogIn);
            this.panelHome.Name = "panelHome";
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHome_Paint);
            // 
            // labelHomeNote
            // 
            resources.ApplyResources(this.labelHomeNote, "labelHomeNote");
            this.labelHomeNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelHomeNote.Name = "labelHomeNote";
            this.labelHomeNote.Click += new System.EventHandler(this.labelHomeNote_Click);
            // 
            // buttonHomeRegister
            // 
            resources.ApplyResources(this.buttonHomeRegister, "buttonHomeRegister");
            this.buttonHomeRegister.Name = "buttonHomeRegister";
            this.buttonHomeRegister.UseVisualStyleBackColor = true;
            this.buttonHomeRegister.Click += new System.EventHandler(this.buttonHomeRegister_Click);
            // 
            // buttonHomeLogIn
            // 
            resources.ApplyResources(this.buttonHomeLogIn, "buttonHomeLogIn");
            this.buttonHomeLogIn.Name = "buttonHomeLogIn";
            this.buttonHomeLogIn.UseVisualStyleBackColor = true;
            this.buttonHomeLogIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonHomeLogIn_MouseClick);
            // 
            // buttonHomeExit
            // 
            resources.ApplyResources(this.buttonHomeExit, "buttonHomeExit");
            this.buttonHomeExit.Name = "buttonHomeExit";
            this.buttonHomeExit.UseVisualStyleBackColor = true;
            this.buttonHomeExit.Click += new System.EventHandler(this.buttonHomeExit_Click);
            // 
            // timerHomeNote
            // 
            this.timerHomeNote.Enabled = true;
            this.timerHomeNote.Interval = 300;
            this.timerHomeNote.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::OrphanageManagementSystem.Properties.Resources.F1P5;
            this.Controls.Add(this.buttonHomeExit);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.labelHomeHeading);
            this.Name = "FormHome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHomeHeading;
        private System.Windows.Forms.Button buttonHomeLogIn;
        private System.Windows.Forms.Button buttonHomeRegister;
        private System.Windows.Forms.Button buttonHomeExit;
        private System.Windows.Forms.Label labelHomeNote;
        private System.Windows.Forms.Timer timerHomeNote;
        private System.Windows.Forms.Panel panelHome;
    }
}