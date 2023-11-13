using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVienControls
{
    public partial class GeneralDataGridView : KryptonDataGridView
    {
        public GeneralDataGridView()
        {
            InitializeComponent();

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 0);
            this.Margin = new Padding(0, 0, 0, 5);
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowTemplate.Height = 25;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Size = new Size(1476, 765);
            this.StateCommon.Background.Color1 = Color.Azure;
            this.StateCommon.BackStyle = PaletteBackStyle.GridBackgroundList; 
        }
    }
}
