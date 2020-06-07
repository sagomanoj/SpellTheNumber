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
    }
}
