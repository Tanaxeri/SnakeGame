namespace SnakeGame
{
    partial class PauseScreen
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
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Restartbtn = new System.Windows.Forms.Button();
            this.ReturntoTSbtn = new System.Windows.Forms.Button();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(258, 28);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(131, 37);
            this.Titlelbl.TabIndex = 0;
            this.Titlelbl.Text = "Paused";
            // 
            // Restartbtn
            // 
            this.Restartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restartbtn.Location = new System.Drawing.Point(238, 228);
            this.Restartbtn.Name = "Restartbtn";
            this.Restartbtn.Size = new System.Drawing.Size(160, 65);
            this.Restartbtn.TabIndex = 5;
            this.Restartbtn.Text = "Restart";
            this.Restartbtn.UseVisualStyleBackColor = true;
            this.Restartbtn.Click += new System.EventHandler(this.Restartbtn_Click);
            // 
            // ReturntoTSbtn
            // 
            this.ReturntoTSbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoTSbtn.Location = new System.Drawing.Point(238, 341);
            this.ReturntoTSbtn.Name = "ReturntoTSbtn";
            this.ReturntoTSbtn.Size = new System.Drawing.Size(160, 65);
            this.ReturntoTSbtn.TabIndex = 6;
            this.ReturntoTSbtn.Text = "Return to Title Screen";
            this.ReturntoTSbtn.UseVisualStyleBackColor = true;
            this.ReturntoTSbtn.Click += new System.EventHandler(this.ReturntoTSbtn_Click);
            // 
            // Returnbtn
            // 
            this.Returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbtn.Location = new System.Drawing.Point(238, 116);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(160, 65);
            this.Returnbtn.TabIndex = 7;
            this.Returnbtn.Text = "Return";
            this.Returnbtn.UseVisualStyleBackColor = true;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Returnbtn);
            this.Controls.Add(this.ReturntoTSbtn);
            this.Controls.Add(this.Restartbtn);
            this.Controls.Add(this.Titlelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PauseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pause";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PauseScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button Restartbtn;
        private System.Windows.Forms.Button ReturntoTSbtn;
        private System.Windows.Forms.Button Returnbtn;
    }
}