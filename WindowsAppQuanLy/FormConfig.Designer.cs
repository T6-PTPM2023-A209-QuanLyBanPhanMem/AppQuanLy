namespace GUI
{
    partial class FormConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenTaiKhoan = new ThuVienControls.RoundTextBox();
            this.txtMatKhau = new ThuVienControls.RoundTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMayChu = new Krypton.Toolkit.KryptonComboBox();
            this.cbxCSDL = new Krypton.Toolkit.KryptonComboBox();
            this.btnKetNoi = new ThuVienControls.RoundButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMayChu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCSDL)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txtTenTaiKhoan, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtMatKhau, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbxMayChu, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxCSDL, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnKetNoi, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(183, 134);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(234, 39);
            this.txtTenTaiKhoan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenTaiKhoan.StateCommon.Border.Rounding = 25F;
            this.txtTenTaiKhoan.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.Location = new System.Drawing.Point(183, 183);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(234, 39);
            this.txtMatKhau.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMatKhau.StateCommon.Border.Rounding = 25F;
            this.txtMatKhau.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(83, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên máy chủ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(83, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên cơ sở dữ liệu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(83, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên tài khoản";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(83, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxMayChu
            // 
            this.cbxMayChu.CornerRoundingRadius = 25F;
            this.cbxMayChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxMayChu.DropDownWidth = 218;
            this.cbxMayChu.IntegralHeight = false;
            this.cbxMayChu.Location = new System.Drawing.Point(183, 36);
            this.cbxMayChu.Name = "cbxMayChu";
            this.cbxMayChu.Size = new System.Drawing.Size(234, 37);
            this.cbxMayChu.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxMayChu.StateCommon.ComboBox.Border.Rounding = 25F;
            this.cbxMayChu.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxMayChu.TabIndex = 8;
            // 
            // cbxCSDL
            // 
            this.cbxCSDL.CornerRoundingRadius = 25F;
            this.cbxCSDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxCSDL.DropDownWidth = 218;
            this.cbxCSDL.IntegralHeight = false;
            this.cbxCSDL.Location = new System.Drawing.Point(183, 85);
            this.cbxCSDL.Name = "cbxCSDL";
            this.cbxCSDL.Size = new System.Drawing.Size(234, 37);
            this.cbxCSDL.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxCSDL.StateCommon.ComboBox.Border.Rounding = 25F;
            this.cbxCSDL.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxCSDL.TabIndex = 9;
            // 
            // btnKetNoi
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnKetNoi, 2);
            this.btnKetNoi.CornerRoundingRadius = 25F;
            this.btnKetNoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKetNoi.Enabled = false;
            this.btnKetNoi.Location = new System.Drawing.Point(83, 232);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnKetNoi.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnKetNoi.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnKetNoi.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnKetNoi.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.Size = new System.Drawing.Size(334, 44);
            this.btnKetNoi.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKetNoi.StateCommon.Border.Rounding = 25F;
            this.btnKetNoi.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnKetNoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKetNoi.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnKetNoi.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnKetNoi.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnKetNoi.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnKetNoi.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKetNoi.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnKetNoi.TabIndex = 10;
            this.btnKetNoi.Values.Text = "Kết nối CSDL";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 313);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfig";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ShadowValues.Colour = System.Drawing.Color.Black;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMayChu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxCSDL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ThuVienControls.RoundTextBox txtTenTaiKhoan;
        private ThuVienControls.RoundTextBox txtMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonComboBox cbxMayChu;
        private Krypton.Toolkit.KryptonComboBox cbxCSDL;
        private ThuVienControls.RoundButton btnKetNoi;
    }
}