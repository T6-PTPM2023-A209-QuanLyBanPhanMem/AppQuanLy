using System.Drawing;
using System.Windows.Forms;

namespace WindowsAppQuanLy.GUI
{
    partial class FormPhanMem
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
            this.dgvPhanMem = new ThuVienControls.GeneralDataGridView();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhatHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new ThuVienControls.GeneralDataGridView();
            this.PM_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PM_ThoiGianLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSoSanPham = new ThuVienControls.RoundTextBox();
            this.txtGiaTriTonKhoa = new ThuVienControls.RoundTextBox();
            this.txtTongDoanhThu = new ThuVienControls.RoundTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenPM = new ThuVienControls.RoundTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new ThuVienControls.RoundButton();
            this.btnCapNhat = new ThuVienControls.RoundButton();
            this.btnXoa = new ThuVienControls.RoundButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHinh = new ThuVienControls.RoundButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoTa = new ThuVienControls.RoundTextBox();
            this.txtDonGia = new ThuVienControls.NumberRoundTextbox();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.cbxNPH = new Krypton.Toolkit.KryptonComboBox();
            this.dtpNgayPhatHanh = new Krypton.Toolkit.KryptonDateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoLuong = new ThuVienControls.NumberRoundTextbox();
            this.txtThoiHan = new ThuVienControls.NumberRoundTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxDonViThoiHan = new Krypton.Toolkit.KryptonComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanMem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNPH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDonViThoiHan)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 433F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1559, 913);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhanMem);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1163, 474);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phần mềm";
            // 
            // dgvPhanMem
            // 
            this.dgvPhanMem.AllowUserToAddRows = false;
            this.dgvPhanMem.AllowUserToDeleteRows = false;
            this.dgvPhanMem.AllowUserToResizeRows = false;
            this.dgvPhanMem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPM,
            this.TenPM,
            this.TenNPH,
            this.Mota,
            this.NgayPhatHanh,
            this.ThoiHan,
            this.DonViThoiHan,
            this.DonGia,
            this.SoLuong,
            this.MaNPH,
            this.HinhAnh});
            this.dgvPhanMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanMem.Location = new System.Drawing.Point(3, 16);
            this.dgvPhanMem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dgvPhanMem.Name = "dgvPhanMem";
            this.dgvPhanMem.ReadOnly = true;
            this.dgvPhanMem.RowHeadersVisible = false;
            this.dgvPhanMem.RowTemplate.Height = 25;
            this.dgvPhanMem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanMem.Size = new System.Drawing.Size(1157, 455);
            this.dgvPhanMem.StateCommon.Background.Color1 = System.Drawing.Color.Azure;
            this.dgvPhanMem.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvPhanMem.TabIndex = 0;
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MAPM";
            this.MaPM.HeaderText = "Mã";
            this.MaPM.Name = "MaPM";
            this.MaPM.ReadOnly = true;
            this.MaPM.Visible = false;
            // 
            // TenPM
            // 
            this.TenPM.DataPropertyName = "TENPM";
            this.TenPM.HeaderText = "Tên";
            this.TenPM.Name = "TenPM";
            this.TenPM.ReadOnly = true;
            // 
            // TenNPH
            // 
            this.TenNPH.DataPropertyName = "TENNPH";
            this.TenNPH.HeaderText = "Nhà phát hành";
            this.TenNPH.Name = "TenNPH";
            this.TenNPH.ReadOnly = true;
            // 
            // Mota
            // 
            this.Mota.DataPropertyName = "MOTA";
            this.Mota.HeaderText = "Mô tả";
            this.Mota.Name = "Mota";
            this.Mota.ReadOnly = true;
            this.Mota.Visible = false;
            // 
            // NgayPhatHanh
            // 
            this.NgayPhatHanh.DataPropertyName = "NGAYPHATHANH";
            this.NgayPhatHanh.HeaderText = "Ngày phát hành";
            this.NgayPhatHanh.Name = "NgayPhatHanh";
            this.NgayPhatHanh.ReadOnly = true;
            this.NgayPhatHanh.Visible = false;
            // 
            // ThoiHan
            // 
            this.ThoiHan.DataPropertyName = "THOIHAN";
            this.ThoiHan.HeaderText = "Thời hạn ";
            this.ThoiHan.Name = "ThoiHan";
            this.ThoiHan.ReadOnly = true;
            this.ThoiHan.Visible = false;
            // 
            // DonViThoiHan
            // 
            this.DonViThoiHan.DataPropertyName = "DONVITHOIHAN";
            this.DonViThoiHan.HeaderText = "Đơn vị thời hạn";
            this.DonViThoiHan.Name = "DonViThoiHan";
            this.DonViThoiHan.ReadOnly = true;
            this.DonViThoiHan.Visible = false;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DONGIA";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Visible = false;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SOLUONG";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // MaNPH
            // 
            this.MaNPH.DataPropertyName = "MANPH";
            this.MaNPH.HeaderText = "Mã NPH";
            this.MaNPH.Name = "MaNPH";
            this.MaNPH.ReadOnly = true;
            this.MaNPH.Visible = false;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HINHANH";
            this.HinhAnh.HeaderText = "Hình ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoaDon);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(1172, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 474);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PM_MaHD,
            this.PM_ThoiGianLap});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 16);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 25;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(378, 455);
            this.dgvHoaDon.StateCommon.Background.Color1 = System.Drawing.Color.Azure;
            this.dgvHoaDon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvHoaDon.TabIndex = 0;
            // 
            // PM_MaHD
            // 
            this.PM_MaHD.DataPropertyName = "MAHD";
            this.PM_MaHD.HeaderText = "Mã hóa đơn";
            this.PM_MaHD.Name = "PM_MaHD";
            this.PM_MaHD.ReadOnly = true;
            // 
            // PM_ThoiGianLap
            // 
            this.PM_ThoiGianLap.DataPropertyName = "THOIGIANLAP";
            this.PM_ThoiGianLap.HeaderText = "Thời gian lập";
            this.PM_ThoiGianLap.Name = "PM_ThoiGianLap";
            this.PM_ThoiGianLap.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.txtSoSanPham, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtGiaTriTonKhoa, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtTongDoanhThu, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1172, 483);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 427);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtSoSanPham
            // 
            this.txtSoSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoSanPham.Location = new System.Drawing.Point(134, 149);
            this.txtSoSanPham.Name = "txtSoSanPham";
            this.txtSoSanPham.Size = new System.Drawing.Size(218, 39);
            this.txtSoSanPham.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSoSanPham.StateCommon.Border.Rounding = 25F;
            this.txtSoSanPham.TabIndex = 0;
            // 
            // txtGiaTriTonKhoa
            // 
            this.txtGiaTriTonKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGiaTriTonKhoa.Location = new System.Drawing.Point(134, 188);
            this.txtGiaTriTonKhoa.Name = "txtGiaTriTonKhoa";
            this.txtGiaTriTonKhoa.Size = new System.Drawing.Size(218, 39);
            this.txtGiaTriTonKhoa.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGiaTriTonKhoa.StateCommon.Border.Rounding = 25F;
            this.txtGiaTriTonKhoa.TabIndex = 1;
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTongDoanhThu.Location = new System.Drawing.Point(134, 227);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.Size = new System.Drawing.Size(218, 39);
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
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượt mua";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(31, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng tồn kho";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(31, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng doanh thu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel3.Controls.Add(this.txtTenPM, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnHinh, 7, 7);
            this.tableLayoutPanel3.Controls.Add(this.label6, 7, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtMoTa, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtDonGia, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.pbHinh, 7, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbxNPH, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpNgayPhatHanh, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtSoLuong, 2, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtThoiHan, 2, 7);
            this.tableLayoutPanel3.Controls.Add(this.label12, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.cbxDonViThoiHan, 3, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 483);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 11;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1163, 427);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtTenPM
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtTenPM, 4);
            this.txtTenPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenPM.Location = new System.Drawing.Point(222, 34);
            this.txtTenPM.Name = "txtTenPM";
            this.txtTenPM.Size = new System.Drawing.Size(714, 39);
            this.txtTenPM.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenPM.StateCommon.Border.Rounding = 25F;
            this.txtTenPM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên phần mềm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(93, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhà phát hành";
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
            this.tableLayoutPanel4.Controls.Add(this.btnThem, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCapNhat, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnXoa, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(93, 333);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(843, 59);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.CornerRoundingRadius = 25F;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(516, 13);
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
            // btnCapNhat
            // 
            this.btnCapNhat.CornerRoundingRadius = 25F;
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapNhat.Location = new System.Drawing.Point(345, 13);
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
            this.btnXoa.Location = new System.Drawing.Point(216, 13);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(93, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 39);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mô tả";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHinh
            // 
            this.btnHinh.CornerRoundingRadius = 25F;
            this.btnHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHinh.Location = new System.Drawing.Point(1033, 272);
            this.btnHinh.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnHinh.Name = "btnHinh";
            this.btnHinh.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHinh.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHinh.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnHinh.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnHinh.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.Size = new System.Drawing.Size(126, 25);
            this.btnHinh.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHinh.StateCommon.Border.Rounding = 25F;
            this.btnHinh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHinh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHinh.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnHinh.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnHinh.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnHinh.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnHinh.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHinh.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHinh.TabIndex = 22;
            this.btnHinh.Values.Text = "Thêm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(1032, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 39);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hình ảnh";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(93, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày phát hành";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(93, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "Đơn giá";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMoTa
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtMoTa, 4);
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Location = new System.Drawing.Point(222, 112);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(714, 39);
            this.txtMoTa.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMoTa.StateCommon.Border.Rounding = 25F;
            this.txtMoTa.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtDonGia, 4);
            this.txtDonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonGia.Location = new System.Drawing.Point(222, 190);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(714, 39);
            this.txtDonGia.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDonGia.StateCommon.Border.Rounding = 25F;
            this.txtDonGia.TabIndex = 12;
            // 
            // pbHinh
            // 
            this.pbHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHinh.Location = new System.Drawing.Point(1032, 112);
            this.pbHinh.Name = "pbHinh";
            this.tableLayoutPanel3.SetRowSpan(this.pbHinh, 3);
            this.pbHinh.Size = new System.Drawing.Size(128, 111);
            this.pbHinh.TabIndex = 6;
            this.pbHinh.TabStop = false;
            // 
            // cbxNPH
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cbxNPH, 4);
            this.cbxNPH.CornerRoundingRadius = 25F;
            this.cbxNPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxNPH.DropDownWidth = 822;
            this.cbxNPH.IntegralHeight = false;
            this.cbxNPH.Location = new System.Drawing.Point(222, 73);
            this.cbxNPH.Name = "cbxNPH";
            this.cbxNPH.Size = new System.Drawing.Size(714, 37);
            this.cbxNPH.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxNPH.StateCommon.ComboBox.Border.Rounding = 25F;
            this.cbxNPH.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxNPH.TabIndex = 23;
            // 
            // dtpNgayPhatHanh
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.dtpNgayPhatHanh, 4);
            this.dtpNgayPhatHanh.CornerRoundingRadius = 25F;
            this.dtpNgayPhatHanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNgayPhatHanh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayPhatHanh.Location = new System.Drawing.Point(222, 151);
            this.dtpNgayPhatHanh.Name = "dtpNgayPhatHanh";
            this.dtpNgayPhatHanh.Size = new System.Drawing.Size(714, 33);
            this.dtpNgayPhatHanh.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpNgayPhatHanh.StateCommon.Border.Rounding = 25F;
            this.dtpNgayPhatHanh.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(93, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 39);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số lượng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoLuong
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtSoLuong, 4);
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Location = new System.Drawing.Point(222, 229);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(714, 39);
            this.txtSoLuong.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSoLuong.StateCommon.Border.Rounding = 25F;
            this.txtSoLuong.TabIndex = 13;
            // 
            // txtThoiHan
            // 
            this.txtThoiHan.Location = new System.Drawing.Point(222, 268);
            this.txtThoiHan.Name = "txtThoiHan";
            this.txtThoiHan.Size = new System.Drawing.Size(84, 39);
            this.txtThoiHan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtThoiHan.StateCommon.Border.Rounding = 25F;
            this.txtThoiHan.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(93, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 39);
            this.label12.TabIndex = 26;
            this.label12.Text = "Thời hạn";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxDonViThoiHan
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cbxDonViThoiHan, 3);
            this.cbxDonViThoiHan.CornerRoundingRadius = 25F;
            this.cbxDonViThoiHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxDonViThoiHan.DropDownWidth = 717;
            this.cbxDonViThoiHan.IntegralHeight = false;
            this.cbxDonViThoiHan.Location = new System.Drawing.Point(312, 268);
            this.cbxDonViThoiHan.Name = "cbxDonViThoiHan";
            this.cbxDonViThoiHan.Size = new System.Drawing.Size(624, 37);
            this.cbxDonViThoiHan.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbxDonViThoiHan.StateCommon.ComboBox.Border.Rounding = 25F;
            this.cbxDonViThoiHan.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbxDonViThoiHan.TabIndex = 27;
            // 
            // FormPhanMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 913);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormPhanMem";
            this.Text = "FormSanPham";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanMem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNPH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDonViThoiHan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private ThuVienControls.GeneralDataGridView dgvPhanMem;
        private GroupBox groupBox2;
        private ThuVienControls.GeneralDataGridView dgvHoaDon;
        private TableLayoutPanel tableLayoutPanel2;
        private ThuVienControls.RoundTextBox txtSoSanPham;
        private ThuVienControls.RoundTextBox txtGiaTriTonKhoa;
        private ThuVienControls.RoundTextBox txtTongDoanhThu;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private ThuVienControls.RoundTextBox txtTenPM;
        private ThuVienControls.RoundTextBox txtMoTa;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel4;
        private ThuVienControls.RoundButton btnThem;
        private ThuVienControls.RoundButton btnCapNhat;
        private ThuVienControls.RoundButton btnXoa;
        private PictureBox pbHinh;
        private Label label6;
        private ThuVienControls.RoundButton btnHinh;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ThuVienControls.RoundTextBox roundTextBox1;
        private ThuVienControls.RoundTextBox roundTextBox2;
        private ThuVienControls.NumberRoundTextbox txtDonGia;
        private ThuVienControls.NumberRoundTextbox txtSoLuong;
        private ThuVienControls.RoundTextBox roundTextBox5;
        private Krypton.Toolkit.KryptonComboBox cbxNPH;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNgayPhatHanh;
        private DataGridViewTextBoxColumn MaPM;
        private DataGridViewTextBoxColumn TenPM;
        private DataGridViewTextBoxColumn TenNPH;
        private DataGridViewTextBoxColumn Mota;
        private DataGridViewTextBoxColumn NgayPhatHanh;
        private DataGridViewTextBoxColumn ThoiHan;
        private DataGridViewTextBoxColumn DonViThoiHan;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn MaNPH;
        private DataGridViewTextBoxColumn HinhAnh;
        private ThuVienControls.NumberRoundTextbox txtThoiHan;
        private Label label12;
        private Krypton.Toolkit.KryptonComboBox cbxDonViThoiHan;
        private DataGridViewTextBoxColumn PM_MaHD;
        private DataGridViewTextBoxColumn PM_ThoiGianLap;
    }
}