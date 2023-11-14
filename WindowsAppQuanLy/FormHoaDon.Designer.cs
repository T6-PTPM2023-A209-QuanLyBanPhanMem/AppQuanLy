using System.Drawing;
using System.Windows.Forms;

namespace WindowsAppQuanLy.GUI
{
    partial class FormHoaDon
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
            this.dgvHoaDon = new ThuVienControls.GeneralDataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCTHD = new ThuVienControls.GeneralDataGridView();
            this.HD_MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_TenPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HD_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtThoiGianLap = new ThuVienControls.RoundTextBox();
            this.txtMaHD = new ThuVienControls.RoundTextBox();
            this.txtTenTK = new ThuVienControls.RoundTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.lb1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtThanhTien = new ThuVienControls.RoundTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1559, 913);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 647);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.ThoiGianLap,
            this.TenTK,
            this.TongTien,
            this.TinhTrang});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 16);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 25;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(767, 628);
            this.dgvHoaDon.StateCommon.Background.Color1 = System.Drawing.Color.Azure;
            this.dgvHoaDon.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvHoaDon.TabIndex = 0;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MAHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // ThoiGianLap
            // 
            this.ThoiGianLap.DataPropertyName = "ThoiGianLap";
            this.ThoiGianLap.HeaderText = "Thời gian lập";
            this.ThoiGianLap.Name = "ThoiGianLap";
            this.ThoiGianLap.ReadOnly = true;
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TENTK";
            this.TenTK.HeaderText = "Tài khoản";
            this.TenTK.Name = "TenTK";
            this.TenTK.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TONGTIEN";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TINHTRANG";
            this.TinhTrang.HeaderText = "Trạng thái";
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCTHD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(782, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 647);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiêt hóa đơn";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToDeleteRows = false;
            this.dgvCTHD.AllowUserToResizeRows = false;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HD_MaPM,
            this.HD_TenPM,
            this.HD_SoLuong,
            this.HD_ThanhTien});
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.Location = new System.Drawing.Point(3, 16);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowTemplate.Height = 25;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(768, 628);
            this.dgvCTHD.StateCommon.Background.Color1 = System.Drawing.Color.Azure;
            this.dgvCTHD.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgvCTHD.TabIndex = 0;
            // 
            // HD_MaPM
            // 
            this.HD_MaPM.DataPropertyName = "MaPM";
            this.HD_MaPM.HeaderText = "Mã phần mềm";
            this.HD_MaPM.Name = "HD_MaPM";
            this.HD_MaPM.ReadOnly = true;
            // 
            // HD_TenPM
            // 
            this.HD_TenPM.DataPropertyName = "TenPM";
            this.HD_TenPM.HeaderText = "Tên phần mềm";
            this.HD_TenPM.Name = "HD_TenPM";
            this.HD_TenPM.ReadOnly = true;
            // 
            // HD_SoLuong
            // 
            this.HD_SoLuong.DataPropertyName = "SoLuong";
            this.HD_SoLuong.HeaderText = "Số lượng";
            this.HD_SoLuong.Name = "HD_SoLuong";
            this.HD_SoLuong.ReadOnly = true;
            // 
            // HD_ThanhTien
            // 
            this.HD_ThanhTien.DataPropertyName = "ThanhTien";
            this.HD_ThanhTien.HeaderText = "Thành tiền";
            this.HD_ThanhTien.Name = "HD_ThanhTien";
            this.HD_ThanhTien.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.txtThoiGianLap, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtMaHD, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtTenTK, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel2, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.kryptonLabel7, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtThanhTien, 2, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 656);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1553, 254);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtThoiGianLap
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtThoiGianLap, 4);
            this.txtThoiGianLap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThoiGianLap.Location = new System.Drawing.Point(274, 130);
            this.txtThoiGianLap.Name = "txtThoiGianLap";
            this.txtThoiGianLap.Size = new System.Drawing.Size(1132, 39);
            this.txtThoiGianLap.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtThoiGianLap.StateCommon.Border.Rounding = 25F;
            this.txtThoiGianLap.TabIndex = 7;
            // 
            // txtMaHD
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtMaHD, 4);
            this.txtMaHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaHD.Location = new System.Drawing.Point(274, 50);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(1132, 39);
            this.txtMaHD.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaHD.StateCommon.Border.Rounding = 25F;
            this.txtMaHD.TabIndex = 0;
            // 
            // txtTenTK
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtTenTK, 4);
            this.txtTenTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenTK.Location = new System.Drawing.Point(274, 90);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(1132, 39);
            this.txtTenTK.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTenTK.StateCommon.Border.Rounding = 25F;
            this.txtTenTK.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(145, 50);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(123, 34);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Mã hóa đơn";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel2.Location = new System.Drawing.Point(145, 90);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(123, 34);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Tên tài khoản";
            // 
            // lb1
            // 
            this.lb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb1.Location = new System.Drawing.Point(145, 130);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(123, 34);
            this.lb1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.TabIndex = 4;
            this.lb1.Values.Text = "Thời gian lập";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel7.Location = new System.Drawing.Point(145, 170);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(123, 34);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 5;
            this.kryptonLabel7.Values.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtThanhTien, 4);
            this.txtThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThanhTien.Location = new System.Drawing.Point(274, 170);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(1132, 39);
            this.txtThanhTien.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtThanhTien.StateCommon.Border.Rounding = 25F;
            this.txtThanhTien.TabIndex = 6;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 913);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private ThuVienControls.GeneralDataGridView dgvHoaDon;
        private GroupBox groupBox2;
        private ThuVienControls.GeneralDataGridView dgvCTHD;
        private TableLayoutPanel tableLayoutPanel3;
        private ThuVienControls.RoundTextBox txtMaHD;
        private ThuVienControls.RoundTextBox txtTenTK;
        private DataGridViewTextBoxColumn MaHD;
        private DataGridViewTextBoxColumn ThoiGianLap;
        private DataGridViewTextBoxColumn TenTK;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn TinhTrang;
        private ThuVienControls.RoundTextBox txtThoiGianLap;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel lb1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ThuVienControls.RoundTextBox txtThanhTien;
        private DataGridViewTextBoxColumn HD_MaPM;
        private DataGridViewTextBoxColumn HD_TenPM;
        private DataGridViewTextBoxColumn HD_SoLuong;
        private DataGridViewTextBoxColumn HD_ThanhTien;
    }
}