using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ThuVienControls
{
    public class LabelTextBox : KryptonRichTextBox
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        public int MaxWidth = 700;

        public LabelTextBox()
        {
            this.GotFocus += TextChanged;
            this.Multiline = true;
            this.ReadOnly = true;
            this.ScrollBars = RichTextBoxScrollBars.None;
            this.StateCommon.Border.Rounding = 15;
            this.StateCommon.Border.Color1 = Color.SkyBlue;
            this.StateCommon.Border.Width = 1;
        }

        public void SetText(string text)
        {
            this.Text = text.Trim();

            using (Graphics g = CreateGraphics())
            {
                SizeF size = g.MeasureString(this.Text, this.Font);
                
                if (size.Width > MaxWidth)
                {
                    this.Width = MaxWidth;
                    this.Height = 35 + Convert.ToInt32(size.Width / MaxWidth) * 35;
                }
                else
                {
                    this.Width = (int)size.Width + 20;
                    this.Height = 35;
                }

            }
        }

        private void TextChanged(object sender, EventArgs e)
        {
            HideCaret(this.Handle);
        }
    }
}
