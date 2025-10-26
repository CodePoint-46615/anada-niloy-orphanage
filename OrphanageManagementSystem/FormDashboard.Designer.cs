
namespace OrphanageManagementSystem
{
    partial class FormDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelDb = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDB1 = new System.Windows.Forms.Button();
            this.buttonDbBack = new System.Windows.Forms.Button();
            this.panelDb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Dashboard";
            // 
            // panelDb
            // 
            this.panelDb.BackColor = System.Drawing.Color.DarkBlue;
            this.panelDb.Controls.Add(this.button8);
            this.panelDb.Controls.Add(this.button3);
            this.panelDb.Controls.Add(this.button7);
            this.panelDb.Controls.Add(this.button2);
            this.panelDb.Controls.Add(this.buttonDB1);
            this.panelDb.Location = new System.Drawing.Point(51, 68);
            this.panelDb.Name = "panelDb";
            this.panelDb.Size = new System.Drawing.Size(703, 308);
            this.panelDb.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(26, 227);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(199, 66);
            this.button8.TabIndex = 8;
            this.button8.Text = "Manage Role";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(480, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 66);
            this.button3.TabIndex = 7;
            this.button3.Text = "Manage Orphan";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(26, 118);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(199, 66);
            this.button7.TabIndex = 6;
            this.button7.Text = "Financial Management";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(480, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Manage Employee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDB1
            // 
            this.buttonDB1.BackColor = System.Drawing.Color.Transparent;
            this.buttonDB1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDB1.Location = new System.Drawing.Point(26, 20);
            this.buttonDB1.Name = "buttonDB1";
            this.buttonDB1.Size = new System.Drawing.Size(199, 66);
            this.buttonDB1.TabIndex = 0;
            this.buttonDB1.Text = "View Profile\r\n";
            this.buttonDB1.UseVisualStyleBackColor = false;
            this.buttonDB1.Click += new System.EventHandler(this.buttonDB1_Click);
            // 
            // buttonDbBack
            // 
            this.buttonDbBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDbBack.Location = new System.Drawing.Point(703, 12);
            this.buttonDbBack.Name = "buttonDbBack";
            this.buttonDbBack.Size = new System.Drawing.Size(75, 44);
            this.buttonDbBack.TabIndex = 2;
            this.buttonDbBack.Text = "Log Out";
            this.buttonDbBack.UseVisualStyleBackColor = true;
            this.buttonDbBack.Click += new System.EventHandler(this.buttonDbBack_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDbBack);
            this.Controls.Add(this.panelDb);
            this.Controls.Add(this.label1);
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelDb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDB1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonDbBack;
    }
}