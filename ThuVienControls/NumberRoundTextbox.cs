using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVienControls;

namespace ThuVienControls
{
    public class NumberRoundTextbox : RoundTextBox
    {
        public NumberRoundTextbox() : base()
        {
            this.KeyPress += NumberRoundTextbox_KeyPress;
        }

        private void NumberRoundTextbox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
