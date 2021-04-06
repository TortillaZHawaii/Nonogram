using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWSG_LAB5
{
    public partial class PickSizeDialog : Form
    {
        public int GameWidth { get; private set; }
        public int GameHeight { get; private set; }

        public PickSizeDialog(string title=null)
        {
            InitializeComponent();
            if (title is not null)
                this.Text = title;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            GameWidth = int.Parse(widthTextBox.Text);
            GameHeight = int.Parse(heightTextBox.Text);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
