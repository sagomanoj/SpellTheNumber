using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellTheNumbers
{
    public partial class SpellNumber : Form
    {
        public SpellNumber()
        {
            InitializeComponent();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((string.IsNullOrEmpty(txtNumber.Text) && e.KeyChar.Equals('0')))
                e.Handled = true;
            else
                e.Handled = !(char.IsDigit(e.KeyChar) ||
                            e.KeyChar.Equals('\b') ||
                            (string.IsNullOrEmpty(txtNumber.Text) && e.KeyChar.Equals('-')));
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNumber.Text) && !txtNumber.Text.Equals("-"))
            {
                try
                {
                    txtNumber.Text = TrimPrefixZeros(txtNumber.Text);
                    long numberToBeConverted = Convert.ToInt64(txtNumber.Text);
                    txtResult.Text = SpellNumberProvider.Instance.SpellTheNumber(numberToBeConverted);
                }
                catch (Exception ex)
                {
                    txtResult.Text = "Entered Number crosses the Limit";

                }
            }
            else
            {
                txtResult.Text = string.Empty;
            }
        }

        private string TrimPrefixZeros(string text)
        {
            if (text.Length > 1)
                return text.TrimStart('0');
            else
                return text;
        }
    }
}
