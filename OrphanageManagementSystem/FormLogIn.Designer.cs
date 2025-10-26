using System.Data.SqlClient;

namespace OrphanageManagementSystem
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.buttonLogSP2 = new System.Windows.Forms.Button();
            this.buttonLogSP1 = new System.Windows.Forms.Button();
            this.buttonLogLI = new System.Windows.Forms.Button();
            this.buttonLogClr = new System.Windows.Forms.Button();
            this.textBoxLogPW = new System.Windows.Forms.TextBox();
            this.textBoxLogUN = new System.Windows.Forms.TextBox();
            this.labelLogPW = new System.Windows.Forms.Label();
            this.labelLogUN = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonLogBk = new System.Windows.Forms.Button();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.Controls.Add(this.buttonLogSP2);
            this.panelLogIn.Controls.Add(this.buttonLogSP1);
            this.panelLogIn.Controls.Add(this.buttonLogLI);
            this.panelLogIn.Controls.Add(this.buttonLogClr);
            this.panelLogIn.Controls.Add(this.textBoxLogPW);
            this.panelLogIn.Controls.Add(this.textBoxLogUN);
            this.panelLogIn.Controls.Add(this.labelLogPW);
            this.panelLogIn.Controls.Add(this.labelLogUN);
            this.panelLogIn.Controls.Add(this.labelLogin);
            this.panelLogIn.Location = new System.Drawing.Point(183, 48);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(437, 335);
            this.panelLogIn.TabIndex = 0;
            this.panelLogIn.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogIn_Paint);
            // 
            // buttonLogSP2
            // 
            this.buttonLogSP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogSP2.BackgroundImage")));
            this.buttonLogSP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogSP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogSP2.Location = new System.Drawing.Point(336, 174);
            this.buttonLogSP2.Name = "buttonLogSP2";
            this.buttonLogSP2.Size = new System.Drawing.Size(26, 26);
            this.buttonLogSP2.TabIndex = 8;
            this.buttonLogSP2.UseVisualStyleBackColor = true;
            this.buttonLogSP2.Click += new System.EventHandler(this.buttonLogSP2_Click);
            // 
            // buttonLogSP1
            // 
            this.buttonLogSP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogSP1.BackgroundImage")));
            this.buttonLogSP1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogSP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogSP1.Location = new System.Drawing.Point(336, 174);
            this.buttonLogSP1.Name = "buttonLogSP1";
            this.buttonLogSP1.Size = new System.Drawing.Size(26, 26);
            this.buttonLogSP1.TabIndex = 7;
            this.buttonLogSP1.UseVisualStyleBackColor = true;
            this.buttonLogSP1.Click += new System.EventHandler(this.buttonLogSP1_Click);
            // 
            // buttonLogLI
            // 
            this.buttonLogLI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogLI.Location = new System.Drawing.Point(217, 265);
            this.buttonLogLI.Name = "buttonLogLI";
            this.buttonLogLI.Size = new System.Drawing.Size(106, 43);
            this.buttonLogLI.TabIndex = 6;
            this.buttonLogLI.Text = "Log In";
            this.buttonLogLI.UseVisualStyleBackColor = true;
            this.buttonLogLI.Click += new System.EventHandler(this.buttonLogLI_Click);
            // 
            // buttonLogClr
            // 
            this.buttonLogClr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogClr.Location = new System.Drawing.Point(105, 265);
            this.buttonLogClr.Name = "buttonLogClr";
            this.buttonLogClr.Size = new System.Drawing.Size(106, 43);
            this.buttonLogClr.TabIndex = 5;
            this.buttonLogClr.Text = "Clear";
            this.buttonLogClr.UseVisualStyleBackColor = true;
            this.buttonLogClr.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxLogPW
            // 
            this.textBoxLogPW.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogPW.Location = new System.Drawing.Point(62, 174);
            this.textBoxLogPW.Name = "textBoxLogPW";
            this.textBoxLogPW.PasswordChar = '*';
            this.textBoxLogPW.Size = new System.Drawing.Size(300, 26);
            this.textBoxLogPW.TabIndex = 4;
            this.textBoxLogPW.TextChanged += new System.EventHandler(this.textBoxLogPW_TextChanged);
            // 
            // textBoxLogUN
            // 
            this.textBoxLogUN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogUN.Location = new System.Drawing.Point(62, 116);
            this.textBoxLogUN.Name = "textBoxLogUN";
            this.textBoxLogUN.Size = new System.Drawing.Size(300, 26);
            this.textBoxLogUN.TabIndex = 3;
            this.textBoxLogUN.TextChanged += new System.EventHandler(this.textBoxLogUN_TextChanged);
            // 
            // labelLogPW
            // 
            this.labelLogPW.AutoSize = true;
            this.labelLogPW.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogPW.Location = new System.Drawing.Point(58, 152);
            this.labelLogPW.Name = "labelLogPW";
            this.labelLogPW.Size = new System.Drawing.Size(72, 19);
            this.labelLogPW.TabIndex = 2;
            this.labelLogPW.Text = "Password";
            // 
            // labelLogUN
            // 
            this.labelLogUN.AutoSize = true;
            this.labelLogUN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogUN.Location = new System.Drawing.Point(58, 83);
            this.labelLogUN.Name = "labelLogUN";
            this.labelLogUN.Size = new System.Drawing.Size(77, 19);
            this.labelLogUN.TabIndex = 1;
            this.labelLogUN.Text = "Username";
            this.labelLogUN.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(194, 29);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(53, 26);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLogBk
            // 
            this.buttonLogBk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogBk.Location = new System.Drawing.Point(24, 395);
            this.buttonLogBk.Name = "buttonLogBk";
            this.buttonLogBk.Size = new System.Drawing.Size(106, 43);
            this.buttonLogBk.TabIndex = 7;
            this.buttonLogBk.Text = "Back";
            this.buttonLogBk.UseVisualStyleBackColor = true;
            this.buttonLogBk.Click += new System.EventHandler(this.buttonLogBk_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogBk);
            this.Controls.Add(this.panelLogIn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private System.Windows.Forms.Label labelLogUN;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLogPW;
        private System.Windows.Forms.TextBox textBoxLogPW;
        private System.Windows.Forms.TextBox textBoxLogUN;
        private System.Windows.Forms.Button buttonLogClr;
        private System.Windows.Forms.Button buttonLogLI;
        private System.Windows.Forms.Button buttonLogBk;
        private System.Windows.Forms.Button buttonLogSP2;
        private System.Windows.Forms.Button buttonLogSP1;
    }
}