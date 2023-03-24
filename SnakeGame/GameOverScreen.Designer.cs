namespace SnakeGame
{
    partial class GameOverScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverScreen));
            this.FinalScorelbl = new System.Windows.Forms.Label();
            this.FinalLevellbl = new System.Windows.Forms.Label();
            this.Savebtn = new System.Windows.Forms.Button();
            this.GameOverlbl = new System.Windows.Forms.Label();
            this.PlayAgainbtn = new System.Windows.Forms.Button();
            this.ReturntoTSbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FinalScorelbl
            // 
            this.FinalScorelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinalScorelbl.AutoSize = true;
            this.FinalScorelbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScorelbl.Location = new System.Drawing.Point(265, 167);
            this.FinalScorelbl.Name = "FinalScorelbl";
            this.FinalScorelbl.Size = new System.Drawing.Size(153, 22);
            this.FinalScorelbl.TabIndex = 0;
            this.FinalScorelbl.Text = "Final Score: ";
            // 
            // FinalLevellbl
            // 
            this.FinalLevellbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinalLevellbl.AutoSize = true;
            this.FinalLevellbl.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalLevellbl.Location = new System.Drawing.Point(597, 167);
            this.FinalLevellbl.Name = "FinalLevellbl";
            this.FinalLevellbl.Size = new System.Drawing.Size(153, 22);
            this.FinalLevellbl.TabIndex = 1;
            this.FinalLevellbl.Text = "Final Level: ";
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Savebtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(64, 330);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(141, 65);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // GameOverlbl
            // 
            this.GameOverlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameOverlbl.AutoSize = true;
            this.GameOverlbl.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverlbl.Location = new System.Drawing.Point(326, 33);
            this.GameOverlbl.Name = "GameOverlbl";
            this.GameOverlbl.Size = new System.Drawing.Size(412, 73);
            this.GameOverlbl.TabIndex = 3;
            this.GameOverlbl.Text = "Game Over!";
            // 
            // PlayAgainbtn
            // 
            this.PlayAgainbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PlayAgainbtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainbtn.Location = new System.Drawing.Point(432, 330);
            this.PlayAgainbtn.Name = "PlayAgainbtn";
            this.PlayAgainbtn.Size = new System.Drawing.Size(141, 65);
            this.PlayAgainbtn.TabIndex = 4;
            this.PlayAgainbtn.Text = "Play Again";
            this.PlayAgainbtn.UseVisualStyleBackColor = true;
            this.PlayAgainbtn.Click += new System.EventHandler(this.PlayAgainbtn_Click);
            // 
            // ReturntoTSbtn
            // 
            this.ReturntoTSbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReturntoTSbtn.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoTSbtn.Location = new System.Drawing.Point(767, 330);
            this.ReturntoTSbtn.Name = "ReturntoTSbtn";
            this.ReturntoTSbtn.Size = new System.Drawing.Size(160, 65);
            this.ReturntoTSbtn.TabIndex = 5;
            this.ReturntoTSbtn.Text = "Return to Title Screen";
            this.ReturntoTSbtn.UseVisualStyleBackColor = true;
            this.ReturntoTSbtn.Click += new System.EventHandler(this.ReturntoTSbtn_Click);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.ReturntoTSbtn);
            this.Controls.Add(this.PlayAgainbtn);
            this.Controls.Add(this.GameOverlbl);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.FinalLevellbl);
            this.Controls.Add(this.FinalScorelbl);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOverScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameOverScreen_FormClosing);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FinalScorelbl;
        private System.Windows.Forms.Label FinalLevellbl;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label GameOverlbl;
        private System.Windows.Forms.Button PlayAgainbtn;
        private System.Windows.Forms.Button ReturntoTSbtn;
    }
}