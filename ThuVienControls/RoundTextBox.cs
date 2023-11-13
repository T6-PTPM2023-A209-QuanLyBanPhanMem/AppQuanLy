using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienControls
{
    public partial class RoundTextBox : KryptonTextBox
    {
        public RoundTextBox()
        {
            InitializeComponent();

            this.StateCommon.Border.Rounding = 25;
        }
    }
}
