﻿namespace GUI.Pages
{
    partial class frmTKBCSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTong = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.clMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiDiemLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 519F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpThang);
            this.panel2.Controls.Add(this.btnXuatExcel);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(151, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 46);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chọn tháng:";
            // 
            // dtpThang
            // 
            this.dtpThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(122, 10);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.Size = new System.Drawing.Size(144, 24);
            this.dtpThang.TabIndex = 11;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.Location = new System.Drawing.Point(394, 8);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(116, 30);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXem.Location = new System.Drawing.Point(272, 8);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(116, 30);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTong);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 532);
            this.panel1.TabIndex = 1;
            // 
            // lblTong
            // 
            this.lblTong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(57, 503);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(113, 13);
            this.lblTong.TabIndex = 3;
            this.lblTong.Text = "Tổng: <num> hóa đơn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 883F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 79);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(815, 410);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(-31, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(877, 404);
            this.panel3.TabIndex = 0;
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToResizeRows = false;
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaHD,
            this.clNhanVien,
            this.clThoiDiemLapHD,
            this.clKhachHang,
            this.clTongTien});
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(877, 404);
            this.dgvSach.TabIndex = 0;
            // 
            // clMaHD
            // 
            this.clMaHD.DataPropertyName = "MaHD";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            this.clMaHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.clMaHD.HeaderText = "Mã hóa đơn";
            this.clMaHD.MinimumWidth = 6;
            this.clMaHD.Name = "clMaHD";
            this.clMaHD.ReadOnly = true;
            // 
            // clNhanVien
            // 
            this.clNhanVien.DataPropertyName = "HoTenNV";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Green;
            this.clNhanVien.DefaultCellStyle = dataGridViewCellStyle4;
            this.clNhanVien.HeaderText = "Nhân Viên";
            this.clNhanVien.MinimumWidth = 6;
            this.clNhanVien.Name = "clNhanVien";
            this.clNhanVien.ReadOnly = true;
            // 
            // clThoiDiemLapHD
            // 
            this.clThoiDiemLapHD.DataPropertyName = "ThoiDiemLapHD";
            this.clThoiDiemLapHD.HeaderText = "Thời điểm lập";
            this.clThoiDiemLapHD.MinimumWidth = 6;
            this.clThoiDiemLapHD.Name = "clThoiDiemLapHD";
            this.clThoiDiemLapHD.ReadOnly = true;
            // 
            // clKhachHang
            // 
            this.clKhachHang.DataPropertyName = "HoTenKH";
            this.clKhachHang.HeaderText = "Khách hàng";
            this.clKhachHang.MinimumWidth = 6;
            this.clKhachHang.Name = "clKhachHang";
            this.clKhachHang.ReadOnly = true;
            // 
            // clTongTien
            // 
            this.clTongTien.DataPropertyName = "TongTien";
            this.clTongTien.HeaderText = "Tổng tiền ";
            this.clTongTien.MinimumWidth = 6;
            this.clTongTien.Name = "clTongTien";
            this.clTongTien.ReadOnly = true;
            // 
            // frmTKBCSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 532);
            this.Controls.Add(this.panel1);
            this.Name = "frmTKBCSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTKBCSach";
            this.Load += new System.EventHandler(this.frmTKBCSach_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiDiemLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTongTien;
    }
}