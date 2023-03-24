namespace SnakeGame
{
    partial class CloseScreen
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
            this.Nobtn = new System.Windows.Forms.Button();
            this.Yesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titlelbl
            // 
            this.Titlelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(21, 66);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(744, 37);
            this.Titlelbl.TabIndex = 4;
            this.Titlelbl.Text = "Are you sure, you want to close the application?";
            // 
            // Nobtn
            // 
            this.Nobtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nobtn.Location = new System.Drawing.Point(49, 263);
            this.Nobtn.Name = "Nobtn";
            this.Nobtn.Size = new System.Drawing.Size(134, 66);
            this.Nobtn.TabIndex = 5;
            this.Nobtn.Text = "No";
            this.Nobtn.UseVisualStyleBackColor = true;
            this.Nobtn.Click += new System.EventHandler(this.Nobtn_Click);
            // 
            // Yesbtn
            // 
            this.Yesbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Yesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yesbtn.Location = new System.Drawing.Point(545, 263);
            this.Yesbtn.Name = "Yesbtn";
            this.Yesbtn.Size = new System.Drawing.Size(134, 66);
            this.Yesbtn.TabIndex = 6;
            this.Yesbtn.Text = "Yes";
            this.Yesbtn.UseVisualStyleBackColor = true;
            this.Yesbtn.Click += new System.EventHandler(this.Yesbtn_Click);
            // 
            // CloseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Yesbtn);
            this.Controls.Add(this.Nobtn);
            this.Controls.Add(this.Titlelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloseScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Closing application";
            this.Load += new System.EventHandler(this.CloseScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button Nobtn;
        private System.Windows.Forms.Button Yesbtn;
    }
}