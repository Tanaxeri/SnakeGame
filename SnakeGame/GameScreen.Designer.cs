namespace SnakeGame
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.Scorelbl = new System.Windows.Forms.Label();
            this.foodlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Scorelbl
            // 
            this.Scorelbl.AutoSize = true;
            this.Scorelbl.Location = new System.Drawing.Point(1165, 9);
            this.Scorelbl.Name = "Scorelbl";
            this.Scorelbl.Size = new System.Drawing.Size(98, 21);
            this.Scorelbl.TabIndex = 0;
            this.Scorelbl.Text = "Score: 0";
            // 
            // foodlbl
            // 
            this.foodlbl.BackColor = System.Drawing.Color.Red;
            this.foodlbl.ForeColor = System.Drawing.Color.White;
            this.foodlbl.Location = new System.Drawing.Point(524, 388);
            this.foodlbl.Name = "foodlbl";
            this.foodlbl.Size = new System.Drawing.Size(21, 21);
            this.foodlbl.TabIndex = 1;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.foodlbl);
            this.Controls.Add(this.Scorelbl);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Scorelbl;
        private System.Windows.Forms.Label foodlbl;
    }
}