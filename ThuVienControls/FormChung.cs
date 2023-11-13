using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVienControls
{
    public class FormChung : Form
    {
        public FormChung()
        {
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoScroll = false;
            this.FormClosed += FormChung_FormClosed;
        }

        private void FormChung_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(123);
        }
    }
}
