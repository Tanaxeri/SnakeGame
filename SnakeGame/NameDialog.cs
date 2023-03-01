using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SnakeGame
{
    public partial class NameDialog : Form
    {
        public string PlayerName { get; set; }

        public NameDialog()
        {
            InitializeComponent();
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            txtPlayerName.Text = PlayerName;
            this.Close();

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
