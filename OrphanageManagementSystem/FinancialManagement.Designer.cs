
namespace OrphanageManagementSystem
{
    partial class FinancialManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userControlC1 = new OrphanageManagementSystem.UserControlC();
            this.userControlB1 = new OrphanageManagementSystem.UserControlB();
            this.userControlA1 = new OrphanageManagementSystem.UserControlA();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(200, 426);
            this.panel1.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(3, 386);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(79, 37);
            this.button9.TabIndex = 17;
            this.button9.Text = "Back";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 66);
            this.button3.TabIndex = 3;
            this.button3.Text = "Current Budget";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Expense";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Donation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userControlC1
            // 
            this.userControlC1.BackColor = System.Drawing.Color.Blue;
            this.userControlC1.Location = new System.Drawing.Point(218, 2);
            this.userControlC1.Name = "userControlC1";
            this.userControlC1.Size = new System.Drawing.Size(583, 453);
            this.userControlC1.TabIndex = 1;
            // 
            // userControlB1
            // 
            this.userControlB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.userControlB1.Location = new System.Drawing.Point(218, 2);
            this.userControlB1.Name = "userControlB1";
            this.userControlB1.Size = new System.Drawing.Size(583, 453);
            this.userControlB1.TabIndex = 2;
            // 
            // userControlA1
            // 
            this.userControlA1.BackColor = System.Drawing.Color.Navy;
            this.userControlA1.Location = new System.Drawing.Point(218, 2);
            this.userControlA1.Name = "userControlA1";
            this.userControlA1.Size = new System.Drawing.Size(583, 453);
            this.userControlA1.TabIndex = 3;
            // 
            // FinancialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlA1);
            this.Controls.Add(this.userControlB1);
            this.Controls.Add(this.userControlC1);
            this.Controls.Add(this.panel1);
            this.Name = "FinancialManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Management";
            this.Load += new System.EventHandler(this.FinancialManagement_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private UserControlC userControlC1;
        private UserControlB userControlB1;
        private UserControlA userControlA1;
    }
}