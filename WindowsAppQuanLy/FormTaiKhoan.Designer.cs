using Krypton.Toolkit;
using System.Drawing;
using System.Windows.Forms;
using ThuVienControls;

namespace WindowsAppQuanLy.GUI
{
    partial class FormTaiKhoan
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
            this.dgvTaiKhoan = new Krypton.Toolkit.KryptonDataGridView();
            this.TK_MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_SoDu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_HINHDAIDIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTaiKhoanQuanTri = new Krypton.Toolkit.KryptonDataGridView();
            this.TK_TenTaiKhoanQuanTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK_MatKhauTaiKhoanQuanTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoDu = new ThuVienControls.RoundTextBox();
            this.txtSoluong = new ThuVienControls.RoundTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new ThuVienControls.RoundButton();
            this.btnCapNhat = new ThuVienControls.RoundButton();
            this.btnXoa = new ThuVienControls.RoundButton();
            this.btnDoiMa = new ThuVienControls.RoundButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTaiKhoan = new ThuVienControls.RoundTextBox();
            this.txtMatKhau = new ThuVienControls.RoundTextBox();
            this.txtMaQuanTri = new ThuVienControls.RoundTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanQuanTri)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1265, 754);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTaiKhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 371);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản người dùng";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.AllowUserToResizeRows = false;
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TK_MaTK,
            this.TK_TenTK,
            this.TK_HoTen,
            this.TK_CCCD,
            this.TK_Email,
            this.TK_SDT,
            this.TK_DiaChi,
            this.TK_SoDu,
            this.TK_HINHDAIDIEN});
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(3, 16);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowTemplate.Height = 25;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(873, 352);
            this.dgvTaiKhoan.StateCommon.Background.Color1 = System.Drawing.Color.Azure;
            this.dgvTaiKhoan.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvTaiKhoan.TabIndex = 8;
            // 
            // TK_MaTK
            // 
            this.TK_MaTK.DataPropertyName = "MATK";
            this.TK_MaTK.HeaderText = "Mã tài khoản";
            this.TK_MaTK.Name = "TK_MaTK";
            this.TK_MaTK.ReadOnly = true;
            // 
            // TK_TenTK
            // 
            this.TK_TenTK.DataPropertyName = "TENTK";
            this.TK_TenTK.HeaderText = "Tên tài khoản";
            this.TK_TenTK.Name = "TK_TenTK";
            this.TK_TenTK.ReadOnly = true;
            // 
            // TK_HoTen
            // 
            this.TK_HoTen.DataPropertyName = "HOTEN";
            this.TK_HoTen.HeaderText = "Họ tên";
            this.TK_HoTen.Name = "TK_HoTen";
            this.TK_HoTen.ReadOnly = true;
            // 
            // TK_CCCD
            // 
            this.TK_CCCD.DataPropertyName = "CCCD";
            this.TK_CCCD.HeaderText = "CCCD";
            this.TK_CCCD.Name = "TK_CCCD";
            this.TK_CCCD.ReadOnly = true;
            // 
            // TK_Email
            // 
            this.TK_Email.DataPropertyName = "EMAIL";
            this.TK_Email.HeaderText = "Email";
            this.TK_Email.Name = "TK_Email";
            this.TK_Email.ReadOnly = true;
            // 
            // TK_SDT
            // 
            this.TK_SDT.DataPropertyName = "SDT";
            this.TK_SDT.HeaderText = "Số điện thoại";
            this.TK_SDT.Name = "TK_SDT";
            this.TK_SDT.ReadOnly = true;
            // 
            // TK_DiaChi
            // 
            this.TK_DiaChi.DataPropertyName = "DIACHI";
            this.TK_DiaChi.HeaderText = "Địa chỉ";
            this.TK_DiaChi.Name = "TK_DiaChi";
            this.TK_DiaChi.ReadOnly = true;
            // 
            // TK_SoDu
            // 
            this.TK_SoDu.DataPropertyName = "SODU";
            this.TK_SoDu.HeaderText = "Số dư";
            this.TK_SoDu.Name = "TK_SoDu";
            this.TK_SoDu.ReadOnly = true;
            // 
            // TK_HINHDAIDIEN
            // 
            this.TK_HINHDAIDIEN.DataPropertyName = "HINHDAIDIEN";
            this.TK_HINHDAIDIEN.HeaderText = "Hình";
            this.TK_HINHDAIDIEN.Name = "TK_HINHDAIDIEN";
            this.TK_HINHDAIDIEN.ReadOnly = true;
            this.TK_HINHDAIDIEN.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTaiKhoanQuanTri);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(888, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 371);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản quản trị";
            // 
            // dgvTaiKhoanQuanTri
            // 
            this.dgvTaiKhoanQuanTri.AllowUserToAddRows = false;
            this.dgvTaiKhoanQuanTri.AllowUserToDeleteRows = false;
            this.dgvTaiKhoanQuanTri.AllowUserToResizeRows = false;
            this.dgvTaiKhoanQuanTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoanQuanTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoanQuanTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TK_TenTaiKhoanQuanTri,
            this.TK_MatKhauTaiKhoanQuanTri});
            this.dgvTaiKhoanQuanTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoanQuanTri.Location = new System.Drawing.Point(3, 16);
            this.dgvTaiKhoanQuanTri.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dgvTaiKhoanQuanTri.Name = "dgvTaiKhoanQuanTri";
            this.dgvTaiKhoanQuanTri.ReadOnly = true;
            this.dgvTaiKhoanQuanTri.RowHeadersVisible = false;
            this.dgvTaiKhoanQuanTri.RowTemplate.Height = 25;
            this.dgvTaiKhoanQuanTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoanQuanTri.Size = new System.Drawing.Size(368, 352);
            this.dgvTaiKhoanQuanTri.StateCommon.Background.Color1 = System.Drawing.Color.Azure;
            this.dgvTaiKhoanQuanTri.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvTaiKhoanQuanTri.TabIndex = 9;
            // 
            // TK_TenTaiKhoanQuanTri
            // 
            this.TK_TenTaiKhoanQuanTri.DataPropertyName = "TENTK";
            this.TK_TenTaiKhoanQuanTri.HeaderText = "Tên tài khoản";
            this.TK_TenTaiKhoanQuanTri.Name = "TK_TenTaiKhoanQuanTri";
            this.TK_TenTaiKhoanQuanTri.ReadOnly = true;
            // 
            // TK_MatKhauTaiKhoanQuanTri
            // 
            this.TK_MatKhauTaiKhoanQuanTri.DataPropertyName = "MATKHAU";
            this.TK_MatKhauTaiKhoanQuanTri.HeaderText = "Mật khẩu";
            this.TK_MatKhauTaiKhoanQuanTri.Name = "TK_MatKhauTaiKhoanQuanTri";
            this.TK_MatKhauTaiKhoanQuanTri.ReadOnly = true;
            this.TK_MatKhauTaiKhoanQuanTri.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSoDu, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSoluong, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 380);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(879, 371);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(75, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số lượng tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(75, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng số dư";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoDu
            // 
            this.txtSoDu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoDu.Location = new System.Drawing.Point(227, 143);
            this.txtSoDu.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.ReadOnly = true;
            this.txtSoDu.Size = new System.Drawing.Size(573, 39);
            this.txtSoDu.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSoDu.StateCommon.Border.Rounding = 25F;
            this.txtSoDu.TabIndex = 6;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoluong.Location = new System.Drawing.Point(227, 83);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.ReadOnly = true;
            this.txtSoluong.Size = new System.Drawing.Size(573, 39);
            this.txtSoluong.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSoluong.StateCommon.Border.Rounding = 25F;
            this.txtSoluong.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(225, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 177);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý tài khoản quản trị";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.btnThem, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnCapNhat, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnXoa, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnDoiMa, 3, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(571, 158);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.CornerRoundingRadius = 25F;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.Location = new System.Drawing.Point(3, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnThem.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnThem.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnThem.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnThem.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnThem.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnThem.Size = new System.Drawing.Size(136, 44);
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
            this.btnThem.TabIndex = 0;
            this.btnThem.Values.Text = "Thêm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.CornerRoundingRadius = 25F;
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapNhat.Location = new System.Drawing.Point(145, 13);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnCapNhat.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnCapNhat.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.Size = new System.Drawing.Size(136, 44);
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
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Values.Text = "Cập nhật";
            // 
            // btnXoa
            // 
            this.btnXoa.CornerRoundingRadius = 25F;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.Location = new System.Drawing.Point(287, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnXoa.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnXoa.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnXoa.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnXoa.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnXoa.Size = new System.Drawing.Size(136, 44);
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
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Values.Text = "Xóa";
            // 
            // btnDoiMa
            // 
            this.btnDoiMa.CornerRoundingRadius = 25F;
            this.btnDoiMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoiMa.Location = new System.Drawing.Point(429, 13);
            this.btnDoiMa.Name = "btnDoiMa";
            this.btnDoiMa.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDoiMa.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDoiMa.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnDoiMa.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnDoiMa.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.Size = new System.Drawing.Size(139, 44);
            this.btnDoiMa.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDoiMa.StateCommon.Border.Rounding = 25F;
            this.btnDoiMa.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDoiMa.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDoiMa.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnDoiMa.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnDoiMa.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnDoiMa.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnDoiMa.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDoiMa.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnDoiMa.TabIndex = 3;
            this.btnDoiMa.Values.Text = "Đổi mã";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.txtTaiKhoan, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMatKhau, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtMaQuanTri, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.l, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(888, 380);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(374, 371);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaiKhoan.Location = new System.Drawing.Point(40, 88);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(293, 39);
            this.txtTaiKhoan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTaiKhoan.StateCommon.Border.Rounding = 25F;
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.Location = new System.Drawing.Point(40, 188);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(293, 39);
            this.txtMatKhau.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMatKhau.StateCommon.Border.Rounding = 25F;
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtMaQuanTri
            // 
            this.txtMaQuanTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaQuanTri.Location = new System.Drawing.Point(40, 288);
            this.txtMaQuanTri.Name = "txtMaQuanTri";
            this.txtMaQuanTri.Size = new System.Drawing.Size(293, 39);
            this.txtMaQuanTri.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaQuanTri.StateCommon.Border.Rounding = 25F;
            this.txtMaQuanTri.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(40, 35);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label3.Size = new System.Drawing.Size(293, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên tài khoản quản trị";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l.Location = new System.Drawing.Point(40, 135);
            this.l.Name = "l";
            this.l.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.l.Size = new System.Drawing.Size(293, 50);
            this.l.TabIndex = 4;
            this.l.Text = "Mật khẩu tài khoản quản trị";
            this.l.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(40, 235);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label5.Size = new System.Drawing.Size(293, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã quản trị";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 754);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTaiKhoan";
            this.Text = "FormHoSo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoanQuanTri)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private KryptonDataGridView dgvTaiKhoan;
        private GroupBox groupBox2;
        private KryptonDataGridView dgvTaiKhoanQuanTri;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private RoundTextBox txtSoDu;
        private RoundTextBox txtSoluong;
        private TableLayoutPanel tableLayoutPanel3;
        private RoundTextBox txtTaiKhoan;
        private RoundTextBox txtMatKhau;
        private RoundTextBox txtMaQuanTri;
        private Label label3;
        private Label l;
        private Label label5;
        private DataGridViewTextBoxColumn TK_MaTK;
        private DataGridViewTextBoxColumn TK_TenTK;
        private DataGridViewTextBoxColumn TK_HoTen;
        private DataGridViewTextBoxColumn TK_CCCD;
        private DataGridViewTextBoxColumn TK_Email;
        private DataGridViewTextBoxColumn TK_SDT;
        private DataGridViewTextBoxColumn TK_DiaChi;
        private DataGridViewTextBoxColumn TK_SoDu;
        private DataGridViewTextBoxColumn TK_HINHDAIDIEN;
        private DataGridViewTextBoxColumn TK_TenTaiKhoanQuanTri;
        private DataGridViewTextBoxColumn TK_MatKhauTaiKhoanQuanTri;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private RoundButton btnThem;
        private RoundButton btnCapNhat;
        private RoundButton btnXoa;
        private RoundButton btnDoiMa;
    }
}