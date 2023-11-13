using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienControls
{
    public partial class RoundButton : KryptonButton
    {
        public RoundButton()
        {
            InitializeComponent();

            this.CornerRoundingRadius = 25F;
            this.Location = new Point(176, 277);
            this.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            this.OverrideDefault.Back.Color2 = Color.DodgerBlue;
            this.OverrideDefault.Content.ShortText.Color1 = Color.White;
            this.OverrideDefault.Content.ShortText.Color2 = Color.White;
            this.OverrideFocus.Back.Color1 = Color.White;
            this.OverrideFocus.Back.Color2 = Color.White;
            this.OverrideFocus.Content.ShortText.Color1 = Color.DodgerBlue;
            this.OverrideFocus.Content.ShortText.Color2 = Color.DodgerBlue;
            this.Size = new Size(250, 39);
            this.StateCommon.Back.Color1 = Color.DodgerBlue;
            this.StateCommon.Back.Color2 = Color.DodgerBlue;
            this.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            this.StateCommon.Border.Rounding = 25F;
            this.StateCommon.Content.ShortText.Color1 = Color.White;
            this.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.StateNormal.Back.Color1 = Color.DodgerBlue;
            this.StatePressed.Back.Color1 = Color.White;
            this.StatePressed.Back.Color2 = Color.White;
            this.StatePressed.Content.ShortText.Color1 = Color.DodgerBlue;
            this.StatePressed.Content.ShortText.Color2 = Color.DodgerBlue;
            this.StateTracking.Back.Color1 = Color.White;
            this.StateTracking.Back.Color2 = Color.White;
            this.StateTracking.Border.Color1 = Color.DodgerBlue;
            this.StateTracking.Border.Color2 = Color.DodgerBlue;
            this.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            this.StateTracking.Content.LongText.Color1 = Color.DodgerBlue;
            this.StateTracking.Content.LongText.Color2 = Color.DodgerBlue;
            this.StateTracking.Content.ShortText.Color1 = Color.DodgerBlue;
            this.StateTracking.Content.ShortText.Color2 = Color.DodgerBlue;
        }
    }
}
