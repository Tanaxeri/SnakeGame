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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.Scorelbl = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.gamezone = new System.Windows.Forms.PictureBox();
            this.Levellbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamezone)).BeginInit();
            this.SuspendLayout();
            // 
            // Scorelbl
            // 
            this.Scorelbl.AutoSize = true;
            this.Scorelbl.Location = new System.Drawing.Point(1174, 6);
            this.Scorelbl.Name = "Scorelbl";
            this.Scorelbl.Size = new System.Drawing.Size(98, 21);
            this.Scorelbl.TabIndex = 0;
            this.Scorelbl.Text = "Score: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // gamezone
            // 
            this.gamezone.Location = new System.Drawing.Point(31, 30);
            this.gamezone.Name = "gamezone";
            this.gamezone.Size = new System.Drawing.Size(1234, 601);
            this.gamezone.TabIndex = 1;
            this.gamezone.TabStop = false;
            this.gamezone.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGameGraphics);
            // 
            // Levellbl
            // 
            this.Levellbl.AutoSize = true;
            this.Levellbl.Location = new System.Drawing.Point(12, 6);
            this.Levellbl.Name = "Levellbl";
            this.Levellbl.Size = new System.Drawing.Size(87, 21);
            this.Levellbl.TabIndex = 2;
            this.Levellbl.Text = "Level 0";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.Levellbl);
            this.Controls.Add(this.gamezone);
            this.Controls.Add(this.Scorelbl);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameScreen_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.gamezone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Scorelbl;
        public System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox gamezone;
        private System.Windows.Forms.Label Levellbl;
    }
}