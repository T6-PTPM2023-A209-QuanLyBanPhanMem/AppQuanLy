using System.Drawing;
using System.Windows.Forms;

namespace WindowsAppQuanLy.GUI
{
    partial class FormTheLoai
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoai = new ThuVienControls.GeneralDataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhanMem = new ThuVienControls.GeneralDataGridView();
            this.TL_MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL_TenPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSoSanPham = new ThuVienControls.RoundTextBox();
            this.txtGiaTriTonKhoa = new ThuVienControls.RoundTextBox();
            this.txtTongDoanhThu = new ThuVienControls.RoundTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMaLoai = new ThuVienControls.RoundTextBox();
            this.txtTenLoai = new ThuVienControls.RoundTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCapNhat = new ThuVienControls.RoundButton();
            this.btnXoa = new ThuVienControls.RoundButton();
            this.btnThem = new ThuVienControls.RoundButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanMem)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1559, 913);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLoai);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 647);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách loại phần mềm";
            // 
            // dgvLoai
            // 
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AllowUserToDeleteRows = false;
            this.dgvLoai.AllowUserToResizeRows = false;
            this.dgvLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai});
            this.dgvLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoai.Location = new System.Drawing.Point(3, 16);
            this.dgvLoai.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.RowHeadersVisible = false;
            this.dgvLoai.RowTemplate.Height = 25;
            this.dgvLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoai.Size = new System.Drawing.Size(767, 628);
            this.dgvLoai.StateCommon.Background.Color1 = System.Drawing.Color.Azure;
            this.dgvLoai.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvLoai.TabIndex = 0;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MALOAI";
            this.MaLoai.HeaderText = "Mã loại";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TENLOAI";
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPhanMem);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(782, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 647);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phần mềm";
            // 
            // dgvPhanMem
            // 
            this.dgvPhanMem.AllowUserToAddRows = false;
            this.dgvPhanMem.AllowUserToDeleteRows = false;
            this.dgvPhanMem.AllowUserToResizeRows = false;
            this.dgvPhanMem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TL_MaPM,
            this.TL_TenPM});
            this.dgvPhanMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanMem.Location = new System.Drawing.Point(3, 16);
            this.dgvPhanMem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dgvPhanMem.Name = "dgvPhanMem";
            this.dgvPhanMem.ReadOnly = true;
            this.dgvPhanMem.RowHeadersVisible = false;
            this.dgvPhanMem.RowTemplate.Height = 25;
            this.dgvPhanMem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanMem.Size = new System.Drawing.Size(768, 628);
            this.dgvPhanMem.StateCommon.Background.Color1 = System.Drawing.Color.Azure;
            this.dgvPhanMem.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvPhanMem.TabIndex = 0;
            // 
            // TL_MaPM
            // 
            this.TL_MaPM.DataPropertyName = "MAPM";
            this.TL_MaPM.HeaderText = "Mã phần mềm";
            this.TL_MaPM.Name = "TL_MaPM";
            this.TL_MaPM.ReadOnly = true;
            // 
            // TL_TenPM
            // 
            this.TL_TenPM.DataPropertyName = "TENPM";
            this.TL_TenPM.HeaderText = "Tên phần mềm";
            this.TL_TenPM.Name = "TL_TenPM";
            this.TL_TenPM.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.txtSoSanPham, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtGiaTriTonKhoa, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtTongDoanhThu, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(782, 656);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 254);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtSoSanPham
            // 
            this.txtSoSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoSanPham.Location = new System.Drawing.Point(196, 71);
            this.txtSoSanPham.Name = "txtSoSanPham";
            this.txtSoSanPham.Size = new System.Drawing.Size(510, 39);
            this.txtSoSanPham.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSoSanPham.StateCommon.Border.Rounding = 25F;
            this.txtSoSanPham.TabIndex = 0;
            // 
            // txtGiaTriTonKhoa
            // 
            this.txtGiaTriTonKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaTriTonKhoa.Location = new System.Drawing.Point(196, 110);
            this.txtGiaTriTonKhoa.Name = "txtGiaTriTonKhoa";
            this.txtGiaTriTonKhoa.Size = new System.Drawing.Size(510, 39);
            this.txtGiaTriTonKhoa.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGiaTriTonKhoa.StateCommon.Border.Rounding = 25F;
            this.txtGiaTriTonKhoa.TabIndex = 1;
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongDoanhThu.Location = new System.Drawing.Point(196, 149);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(510, 39);
            this.txtTongDoanhThu.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTongDoanhThu.StateCommon.Border.Rounding = 25F;
            this.txtTongDoanhThu.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(67, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số phần mềm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(67, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá trị tồn kho";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(67, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng doanh thu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.txtMaLoai, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtTenLoai, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 656);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(773, 254);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtMaLoai
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtMaLoai, 4);
            this.txtMaLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaLoai.Location = new System.Drawing.Point(157, 45);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(541, 39);
            this.txtMaLoai.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaLoai.StateCommon.Border.Rounding = 25F;
            this.txtMaLoai.TabIndex = 0;
            // 
            // txtTenLoai
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtTenLoai, 4);
            this.txtTenLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenLoai.Location = new System.Drawing.Point(157, 84);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(541, 39);
            this.txtTenLoai.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenLoai.StateCommon.Border.Rounding = 25F;
            this.txtTenLoai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã loại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(71, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Loại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 5);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCapNhat, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnXoa, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnThem, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(71, 149);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(627, 59);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.CornerRoundingRadius = 25F;
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapNhat.Location = new System.Drawing.Point(237, 13);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.Size = new System.Drawing.Size(153, 33);
            this.btnCapNhat.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.StateCommon.Border.Rounding = 25F;
            this.btnCapNhat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCapNhat.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Values.Text = "Cập nhật";
            // 
            // btnXoa
            // 
            this.btnXoa.CornerRoundingRadius = 25F;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(408, 13);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXoa.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.Size = new System.Drawing.Size(111, 33);
            this.btnXoa.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateCommon.Border.Rounding = 25F;
            this.btnXoa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXoa.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Values.Text = "Xoá";
            // 
            // btnThem
            // 
            this.btnThem.CornerRoundingRadius = 25F;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(108, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThem.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThem.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.Size = new System.Drawing.Size(111, 33);
            this.btnThem.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateCommon.Border.Rounding = 25F;
            this.btnThem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThem.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.TabIndex = 21;
            this.btnThem.Values.Text = "Thêm";
            // 
            // FormTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 913);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTheLoai";
            this.Text = "FormTheLoai";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanMem)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private ThuVienControls.GeneralDataGridView dgvLoai;
        private GroupBox groupBox2;
        private ThuVienControls.GeneralDataGridView dgvPhanMem;
        private TableLayoutPanel tableLayoutPanel2;
        private ThuVienControls.RoundTextBox txtSoSanPham;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel3;
        private ThuVienControls.RoundTextBox txtMaLoai;
        private ThuVienControls.RoundTextBox txtTenLoai;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private ThuVienControls.RoundButton btnThem;
        private ThuVienControls.RoundButton btnCapNhat;
        private ThuVienControls.RoundButton btnXoa;
        private DataGridViewTextBoxColumn MaLoai;
        private DataGridViewTextBoxColumn TenLoai;
        private ThuVienControls.RoundTextBox txtGiaTriTonKhoa;
        private ThuVienControls.RoundTextBox txtTongDoanhThu;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn TL_MaPM;
        private DataGridViewTextBoxColumn TL_TenPM;
    }
}