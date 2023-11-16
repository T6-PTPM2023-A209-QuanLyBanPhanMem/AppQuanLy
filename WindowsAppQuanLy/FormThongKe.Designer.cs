using System.Drawing;

namespace WindowsAppQuanLy.GUI
{
    partial class FormThongKe
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDuongDan = new ThuVienControls.RoundTextBox();
            this.btnPhanMem = new ThuVienControls.RoundButton();
            this.btnNPH = new ThuVienControls.RoundButton();
            this.btnLoaiPM = new ThuVienControls.RoundButton();
            this.btnCTPM = new ThuVienControls.RoundButton();
            this.btnHoaDon = new ThuVienControls.RoundButton();
            this.btnTaiKhoan = new ThuVienControls.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChon = new ThuVienControls.RoundButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1238, 758);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 752);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.txtDuongDan, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPhanMem, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnNPH, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnLoaiPM, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnCTPM, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnHoaDon, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnTaiKhoan, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnChon, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(607, 733);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDuongDan.Location = new System.Drawing.Point(106, 197);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(6);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(393, 39);
            this.txtDuongDan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDuongDan.StateCommon.Border.Rounding = 25F;
            this.txtDuongDan.TabIndex = 0;
            // 
            // btnPhanMem
            // 
            this.btnPhanMem.CornerRoundingRadius = 25F;
            this.btnPhanMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPhanMem.Enabled = false;
            this.btnPhanMem.Location = new System.Drawing.Point(115, 246);
            this.btnPhanMem.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnPhanMem.Name = "btnPhanMem";
            this.btnPhanMem.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPhanMem.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPhanMem.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnPhanMem.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnPhanMem.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.Size = new System.Drawing.Size(375, 40);
            this.btnPhanMem.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPhanMem.StateCommon.Border.Rounding = 25F;
            this.btnPhanMem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPhanMem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPhanMem.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnPhanMem.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnPhanMem.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnPhanMem.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnPhanMem.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPhanMem.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnPhanMem.TabIndex = 1;
            this.btnPhanMem.Values.Text = "Xuất thống kê phần mềm";
            // 
            // btnNPH
            // 
            this.btnNPH.CornerRoundingRadius = 25F;
            this.btnNPH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNPH.Enabled = false;
            this.btnNPH.Location = new System.Drawing.Point(115, 296);
            this.btnNPH.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnNPH.Name = "btnNPH";
            this.btnNPH.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNPH.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnNPH.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnNPH.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnNPH.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.Size = new System.Drawing.Size(375, 40);
            this.btnNPH.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNPH.StateCommon.Border.Rounding = 25F;
            this.btnNPH.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNPH.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNPH.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnNPH.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnNPH.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnNPH.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnNPH.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNPH.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnNPH.TabIndex = 2;
            this.btnNPH.Values.Text = "Xuất thống kê nhà phát hành";
            // 
            // btnLoaiPM
            // 
            this.btnLoaiPM.CornerRoundingRadius = 25F;
            this.btnLoaiPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoaiPM.Enabled = false;
            this.btnLoaiPM.Location = new System.Drawing.Point(115, 346);
            this.btnLoaiPM.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnLoaiPM.Name = "btnLoaiPM";
            this.btnLoaiPM.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLoaiPM.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLoaiPM.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnLoaiPM.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnLoaiPM.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.Size = new System.Drawing.Size(375, 40);
            this.btnLoaiPM.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoaiPM.StateCommon.Border.Rounding = 25F;
            this.btnLoaiPM.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLoaiPM.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoaiPM.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnLoaiPM.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnLoaiPM.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnLoaiPM.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnLoaiPM.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoaiPM.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnLoaiPM.TabIndex = 3;
            this.btnLoaiPM.Values.Text = "Xuất thống kê loại phần mềm";
            // 
            // btnCTPM
            // 
            this.btnCTPM.CornerRoundingRadius = 25F;
            this.btnCTPM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCTPM.Enabled = false;
            this.btnCTPM.Location = new System.Drawing.Point(115, 396);
            this.btnCTPM.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnCTPM.Name = "btnCTPM";
            this.btnCTPM.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCTPM.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnCTPM.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnCTPM.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnCTPM.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.Size = new System.Drawing.Size(375, 40);
            this.btnCTPM.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCTPM.StateCommon.Border.Rounding = 25F;
            this.btnCTPM.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCTPM.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCTPM.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnCTPM.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnCTPM.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnCTPM.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnCTPM.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCTPM.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnCTPM.TabIndex = 4;
            this.btnCTPM.Values.Text = "Xuất thống kê chi tiết phần mềm";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.CornerRoundingRadius = 25F;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoaDon.Enabled = false;
            this.btnHoaDon.Location = new System.Drawing.Point(115, 446);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHoaDon.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHoaDon.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnHoaDon.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnHoaDon.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.Size = new System.Drawing.Size(375, 40);
            this.btnHoaDon.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHoaDon.StateCommon.Border.Rounding = 25F;
            this.btnHoaDon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHoaDon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHoaDon.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnHoaDon.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnHoaDon.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnHoaDon.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnHoaDon.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHoaDon.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Values.Text = "Xuất thống kê hóa đơn";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.CornerRoundingRadius = 25F;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTaiKhoan.Enabled = false;
            this.btnTaiKhoan.Location = new System.Drawing.Point(115, 496);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTaiKhoan.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnTaiKhoan.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnTaiKhoan.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnTaiKhoan.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.Size = new System.Drawing.Size(375, 40);
            this.btnTaiKhoan.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaiKhoan.StateCommon.Border.Rounding = 25F;
            this.btnTaiKhoan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnTaiKhoan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTaiKhoan.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnTaiKhoan.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnTaiKhoan.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnTaiKhoan.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnTaiKhoan.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTaiKhoan.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnTaiKhoan.TabIndex = 6;
            this.btnTaiKhoan.Values.Text = "Xuất thống kê tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đường dẫn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChon
            // 
            this.btnChon.CornerRoundingRadius = 25F;
            this.btnChon.Location = new System.Drawing.Point(511, 197);
            this.btnChon.Margin = new System.Windows.Forms.Padding(6);
            this.btnChon.Name = "btnChon";
            this.btnChon.OverrideDefault.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnChon.OverrideDefault.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnChon.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnChon.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnChon.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnChon.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btnChon.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnChon.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnChon.Size = new System.Drawing.Size(90, 38);
            this.btnChon.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.StateCommon.Border.Rounding = 25F;
            this.btnChon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnChon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChon.StateNormal.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnChon.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnChon.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnChon.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.btnChon.StateTracking.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StateTracking.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChon.StateTracking.Content.LongText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StateTracking.Content.LongText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DodgerBlue;
            this.btnChon.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DodgerBlue;
            this.btnChon.TabIndex = 8;
            this.btnChon.Values.Text = "Chọn";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(622, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 752);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Báo cáo doanh thu";
            // 
            // FormHeThong
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 758);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormHeThong";
            this.Text = "FormTongQuan";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ThuVienControls.RoundTextBox txtDuongDan;
        private System.Windows.Forms.Label label1;
        private ThuVienControls.RoundButton btnPhanMem;
        private ThuVienControls.RoundButton btnNPH;
        private ThuVienControls.RoundButton btnLoaiPM;
        private ThuVienControls.RoundButton btnCTPM;
        private ThuVienControls.RoundButton btnHoaDon;
        private ThuVienControls.RoundButton btnTaiKhoan;
        private ThuVienControls.RoundButton btnChon;
    }
}