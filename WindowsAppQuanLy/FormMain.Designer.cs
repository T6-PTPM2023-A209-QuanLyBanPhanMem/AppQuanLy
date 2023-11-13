using System.Drawing;
using System.Windows.Forms;

namespace WindowsAppQuanLy.GUI
{
    partial class FormMain
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
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnNPH = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnKey = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 25F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 312);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(171, 104);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Location = new System.Drawing.Point(0, 0);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(171, 104);
            this.btnSanPham.TabIndex = 4;
            this.btnSanPham.Text = "Phần mềm";
            this.btnSanPham.UseVisualStyleBackColor = false;
            // 
            // btnNPH
            // 
            this.btnNPH.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNPH.FlatAppearance.BorderSize = 0;
            this.btnNPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNPH.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNPH.ForeColor = System.Drawing.Color.White;
            this.btnNPH.Location = new System.Drawing.Point(0, 208);
            this.btnNPH.Margin = new System.Windows.Forms.Padding(0);
            this.btnNPH.Name = "btnNPH";
            this.btnNPH.Size = new System.Drawing.Size(171, 104);
            this.btnNPH.TabIndex = 3;
            this.btnNPH.Text = "Nhà phát hành";
            this.btnNPH.UseVisualStyleBackColor = false;
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTheLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTheLoai.FlatAppearance.BorderSize = 0;
            this.btnTheLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTheLoai.ForeColor = System.Drawing.Color.White;
            this.btnTheLoai.Location = new System.Drawing.Point(0, 104);
            this.btnTheLoai.Margin = new System.Windows.Forms.Padding(0);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(171, 104);
            this.btnTheLoai.TabIndex = 2;
            this.btnTheLoai.Text = "Thể loại";
            this.btnTheLoai.UseVisualStyleBackColor = false;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 416);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(171, 104);
            this.btnTaiKhoan.TabIndex = 1;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // btnKey
            // 
            this.btnKey.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKey.FlatAppearance.BorderSize = 0;
            this.btnKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKey.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnKey.ForeColor = System.Drawing.Color.White;
            this.btnKey.Location = new System.Drawing.Point(0, 520);
            this.btnKey.Margin = new System.Windows.Forms.Padding(0);
            this.btnKey.Name = "btnKey";
            this.btnKey.Size = new System.Drawing.Size(171, 104);
            this.btnKey.TabIndex = 0;
            this.btnKey.Text = "Key phần mềm";
            this.btnKey.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnHeThong, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnSanPham, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnKey, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnTaiKhoan, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnTheLoai, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNPH, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnHoaDon, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(171, 729);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnHeThong
            // 
            this.btnHeThong.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Location = new System.Drawing.Point(0, 624);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(0);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(171, 105);
            this.btnHeThong.TabIndex = 6;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1183, 729);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Quản lý";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Button btnKey;
        private Button btnTheLoai;
        private Button btnTaiKhoan;
        private Button btnSanPham;
        private Button btnNPH;
        private Button btnHoaDon;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnHeThong;
    }
}
