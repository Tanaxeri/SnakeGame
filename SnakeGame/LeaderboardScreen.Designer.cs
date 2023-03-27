namespace SnakeGame
{
    partial class LeaderboardScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardScreen));
            this.ReturntoTSbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturntoTSbtn
            // 
            this.ReturntoTSbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturntoTSbtn.BackColor = System.Drawing.Color.Transparent;
            this.ReturntoTSbtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoTSbtn.Location = new System.Drawing.Point(533, 511);
            this.ReturntoTSbtn.Name = "ReturntoTSbtn";
            this.ReturntoTSbtn.Size = new System.Drawing.Size(160, 65);
            this.ReturntoTSbtn.TabIndex = 6;
            this.ReturntoTSbtn.Text = "Return to Title Screen";
            this.ReturntoTSbtn.UseVisualStyleBackColor = false;
            this.ReturntoTSbtn.Click += new System.EventHandler(this.ReturntoTSbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 73);
            this.label1.TabIndex = 7;
            this.label1.Text = "Leaderboard";
            // 
            // Lblbl
            // 
            this.Lblbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lblbl.AutoSize = true;
            this.Lblbl.BackColor = System.Drawing.Color.Transparent;
            this.Lblbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lblbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblbl.Location = new System.Drawing.Point(402, 139);
            this.Lblbl.Name = "Lblbl";
            this.Lblbl.Size = new System.Drawing.Size(0, 22);
            this.Lblbl.TabIndex = 8;
            // 
            // LeaderboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.SnakeGame_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.Lblbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturntoTSbtn);
            this.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "LeaderboardScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeaderboardScreen_FormClosing);
            this.Load += new System.EventHandler(this.LeaderboardScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturntoTSbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblbl;
    }
}