namespace MineSweeper
{
    partial class frmMain
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
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lblEasy = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblHard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(12, 12);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(12, 41);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(12, 70);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 2;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lblEasy
            // 
            this.lblEasy.AutoSize = true;
            this.lblEasy.Location = new System.Drawing.Point(99, 17);
            this.lblEasy.Name = "lblEasy";
            this.lblEasy.Size = new System.Drawing.Size(108, 13);
            this.lblEasy.TabIndex = 3;
            this.lblEasy.Text = "9 x 9 board, 10 mines";
            this.lblEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Location = new System.Drawing.Point(93, 46);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(120, 13);
            this.lblMedium.TabIndex = 4;
            this.lblMedium.Text = "16 x 16 board, 40 mines";
            // 
            // lblHard
            // 
            this.lblHard.AutoSize = true;
            this.lblHard.Location = new System.Drawing.Point(90, 75);
            this.lblHard.Name = "lblHard";
            this.lblHard.Size = new System.Drawing.Size(127, 13);
            this.lblHard.TabIndex = 5;
            this.lblHard.Text = "16 x 30 board, 99 bombs ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 108);
            this.Controls.Add(this.lblHard);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblEasy);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Name = "frmMain";
            this.Text = "Select a difficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lblEasy;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblHard;
    }
}

