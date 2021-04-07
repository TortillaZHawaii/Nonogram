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

        private const int minSize = 2;
        private const int maxSize = 15;

        public PickSizeDialog(string title=null)
        {
            InitializeComponent();
            if (title is not null)
                this.Text = title;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                GameWidth = int.Parse(widthTextBox.Text);
                GameHeight = int.Parse(heightTextBox.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if (int.TryParse(this.widthTextBox.Text, out number))
            {
                if (number >= minSize && number <= maxSize)
                {
                    e.Cancel = false;
                    PickErrorProvider.SetError(this.widthTextBox, string.Empty);
                    return;
                }
            }

            e.Cancel = true;
            PickErrorProvider.SetError(this.widthTextBox, "Width must be an integer in range 2-15");
        }

        private void heightTextBox_Validating(object sender, CancelEventArgs e)
        {
            int number;
            if (int.TryParse(this.heightTextBox.Text, out number))
            {
                if (number >= minSize && number <= maxSize)
                {
                    e.Cancel = false;
                    PickErrorProvider.SetError(this.heightTextBox, string.Empty);
                    return;
                }
            }

            e.Cancel = true;
            PickErrorProvider.SetError(this.heightTextBox, "Height must be an integer in range 2-15");
        }
    }
}
