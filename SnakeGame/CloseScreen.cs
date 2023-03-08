using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class CloseScreen : Form
    {
        public CloseScreen()
        {
            InitializeComponent();
        }

        private void Yesbtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Yes;
            this.Close();

        }

        private void Nobtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.No;
            this.Close();

        }
    }
}
