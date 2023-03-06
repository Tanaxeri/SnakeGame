namespace SnakeGame
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Leaderboardbtn = new System.Windows.Forms.Button();
            this.Playbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(481, 468);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(232, 77);
            this.Exitbtn.TabIndex = 1;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Leaderboardbtn
            // 
            this.Leaderboardbtn.Location = new System.Drawing.Point(481, 346);
            this.Leaderboardbtn.Name = "Leaderboardbtn";
            this.Leaderboardbtn.Size = new System.Drawing.Size(232, 77);
            this.Leaderboardbtn.TabIndex = 2;
            this.Leaderboardbtn.Text = "Leaderboard";
            this.Leaderboardbtn.UseVisualStyleBackColor = true;
            this.Leaderboardbtn.Click += new System.EventHandler(this.Leaderboardbtn_Click);
            // 
            // Playbtn
            // 
            this.Playbtn.Location = new System.Drawing.Point(481, 224);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(232, 77);
            this.Playbtn.TabIndex = 3;
            this.Playbtn.Text = "Play";
            this.Playbtn.UseVisualStyleBackColor = true;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Snake Game";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Playbtn);
            this.Controls.Add(this.Leaderboardbtn);
            this.Controls.Add(this.Exitbtn);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Leaderboardbtn;
        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Label label1;
    }
}

