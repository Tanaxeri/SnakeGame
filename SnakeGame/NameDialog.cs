using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SnakeGame
{
    public partial class NameDialog : Form
    {
        public string PlayerName { get; set; }

        public NameDialog()
        {

            InitializeComponent();
            txtPlayerName.MaxLength = 25;

        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();

            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Please enter a valid player name", "Error");
                return;
            }

            var regex = new Regex("^[a-zA-Z0-9]*$");
            if (!regex.IsMatch(playerName))
            {
                MessageBox.Show("Player name can only contain numbers and letters!", "Error");
                return;
            }

            this.PlayerName = playerName;
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
