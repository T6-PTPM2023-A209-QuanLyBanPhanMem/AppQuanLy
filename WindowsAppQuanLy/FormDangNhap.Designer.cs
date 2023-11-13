using System.Drawing;
using System.Windows.Forms;

namespace WindowsAppQuanLy.GUI
{
    partial class FormDangNhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new Krypton.Toolkit.KryptonTextBox();
            this.txtMatKhau = new Krypton.Toolkit.KryptonTextBox();
            this.btnDangNhap = new Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 62);
            this.label3.TabIndex = 13;
            this.label3.Text = " Đăng nhập";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(92, 101);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(382, 39);
            this.txtTaiKhoan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTaiKhoan.StateCommon.Border.Rounding = 25F;
            this.txtTaiKhoan.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(93, 146);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(381, 39);
            this.txtMatKhau.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMatKhau.StateCommon.Border.Rounding = 25F;
            this.txtMatKhau.TabIndex = 18;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.CornerRoundingRadius = 25F;
            this.btnDangNhap.Location = new System.Drawing.Point(151, 240);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDangNhap.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDangNhap.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnDangNhap.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnDangNhap.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.Size = new System.Drawing.Size(214, 34);
            this.btnDangNhap.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangNhap.StateCommon.Border.Rounding = 25F;
            this.btnDangNhap.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDangNhap.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnDangNhap.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnDangNhap.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDangNhap.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDangNhap.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangNhap.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDangNhap.TabIndex = 20;
            this.btnDangNhap.Values.Text = "Đăng nhập";
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
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Location = new System.Drawing.Point(8, 101);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(81, 39);
            this.kryptonLabel1.StateCommon.AdjacentGap = 0;
            this.kryptonLabel1.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 21;
            this.kryptonLabel1.Values.Text = "Tài khoản";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.AutoSize = false;
            this.kryptonLabel2.Location = new System.Drawing.Point(9, 143);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(81, 39);
            this.kryptonLabel2.StateCommon.AdjacentGap = 0;
            this.kryptonLabel2.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 22;
            this.kryptonLabel2.Values.Text = "Mật khẩu";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 313);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ShadowValues.Colour = System.Drawing.Color.Black;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Krypton.Toolkit.KryptonTextBox txtTaiKhoan;
        private Krypton.Toolkit.KryptonTextBox txtMatKhau;
        private Krypton.Toolkit.KryptonButton btnDangNhap;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}