namespace Ungdungquanlybanhang
{
    partial class FormBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsoluongban = new System.Windows.Forms.NumericUpDown();
            this.lblthanhtien = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemsp = new System.Windows.Forms.Button();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.hangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtdonvitinh = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.cbbtensp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_danhsachspban = new System.Windows.Forms.DataGridView();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_kiemtrakh = new System.Windows.Forms.DataGridView();
            this.txtkiemtrasdt = new System.Windows.Forms.TextBox();
            this.btnThemkh = new System.Windows.Forms.Button();
            this.btnKiemtra = new System.Windows.Forms.Button();
            this.txtkhachhang = new System.Windows.Forms.TextBox();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnlaphoadon = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsohoadon = new System.Windows.Forms.TextBox();
            this.qUANLYBANHANG1DataSet = new Ungdungquanlybanhang.QUANLYBANHANG1DataSet();
            this.qUANLYBANHANG1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluongban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachspban)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiemtrakh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANHANG1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANHANG1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsoluongban);
            this.groupBox1.Controls.Add(this.lblthanhtien);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemsp);
            this.groupBox1.Controls.Add(this.txtmota);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txtdonvitinh);
            this.groupBox1.Controls.Add(this.txtmasp);
            this.groupBox1.Controls.Add(this.cbbtensp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtsoluongban
            // 
            this.txtsoluongban.Location = new System.Drawing.Point(342, 25);
            this.txtsoluongban.Name = "txtsoluongban";
            this.txtsoluongban.Size = new System.Drawing.Size(67, 20);
            this.txtsoluongban.TabIndex = 13;
            // 
            // lblthanhtien
            // 
            this.lblthanhtien.AutoSize = true;
            this.lblthanhtien.Location = new System.Drawing.Point(375, 66);
            this.lblthanhtien.Name = "lblthanhtien";
            this.lblthanhtien.Size = new System.Drawing.Size(0, 13);
            this.lblthanhtien.TabIndex = 15;
            // 
            // txtsoluong
            // 
            this.txtsoluong.AutoSize = true;
            this.txtsoluong.Location = new System.Drawing.Point(286, 25);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(49, 13);
            this.txtsoluong.TabIndex = 12;
            this.txtsoluong.Text = "Số lượng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(403, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemsp
            // 
            this.btnThemsp.Location = new System.Drawing.Point(300, 111);
            this.btnThemsp.Name = "btnThemsp";
            this.btnThemsp.Size = new System.Drawing.Size(75, 23);
            this.btnThemsp.TabIndex = 10;
            this.btnThemsp.Text = "Thêm";
            this.btnThemsp.UseVisualStyleBackColor = true;
            this.btnThemsp.Click += new System.EventHandler(this.btnThemsp_Click);
            // 
            // txtmota
            // 
            this.txtmota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "MoTa", true));
            this.txtmota.Location = new System.Drawing.Point(100, 144);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(309, 40);
            this.txtmota.TabIndex = 9;
            // 
            // hangBindingSource
            // 
            this.hangBindingSource.DataSource = typeof(Ungdungquanlybanhang.Hang);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Thành tiền :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtdongia
            // 
            this.txtdongia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "DonGiaHang", true));
            this.txtdongia.Location = new System.Drawing.Point(100, 116);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(169, 20);
            this.txtdongia.TabIndex = 8;
            // 
            // txtdonvitinh
            // 
            this.txtdonvitinh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "DonViTinh", true));
            this.txtdonvitinh.Location = new System.Drawing.Point(100, 86);
            this.txtdonvitinh.Name = "txtdonvitinh";
            this.txtdonvitinh.Size = new System.Drawing.Size(169, 20);
            this.txtdonvitinh.TabIndex = 7;
            // 
            // txtmasp
            // 
            this.txtmasp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hangBindingSource, "MaHang", true));
            this.txtmasp.Location = new System.Drawing.Point(100, 56);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(169, 20);
            this.txtmasp.TabIndex = 6;
            this.txtmasp.TextChanged += new System.EventHandler(this.txtmasp_TextChanged);
            // 
            // cbbtensp
            // 
            this.cbbtensp.DataSource = this.hangBindingSource;
            this.cbbtensp.DisplayMember = "TenHang";
            this.cbbtensp.FormattingEnabled = true;
            this.cbbtensp.Location = new System.Drawing.Point(100, 25);
            this.cbbtensp.Name = "cbbtensp";
            this.cbbtensp.Size = new System.Drawing.Size(169, 21);
            this.cbbtensp.TabIndex = 5;
            this.cbbtensp.ValueMember = "MaHang";
            this.cbbtensp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_danhsachspban);
            this.groupBox2.Location = new System.Drawing.Point(4, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm bán";
            // 
            // dgv_danhsachspban
            // 
            this.dgv_danhsachspban.AllowUserToAddRows = false;
            this.dgv_danhsachspban.AllowUserToDeleteRows = false;
            this.dgv_danhsachspban.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_danhsachspban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachspban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayLap,
            this.MaSP,
            this.TenSP,
            this.DonViTinh,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgv_danhsachspban.Location = new System.Drawing.Point(6, 22);
            this.dgv_danhsachspban.Name = "dgv_danhsachspban";
            this.dgv_danhsachspban.Size = new System.Drawing.Size(766, 224);
            this.dgv_danhsachspban.TabIndex = 0;
            this.dgv_danhsachspban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachspban_CellContentClick);
            this.dgv_danhsachspban.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachspban_RowEnter);
            // 
            // NgayLap
            // 
            this.NgayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayLap.HeaderText = "Ngày lập HĐ";
            this.NgayLap.Name = "NgayLap";
            // 
            // MaSP
            // 
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 120;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Width = 60;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 50;
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_kiemtrakh);
            this.groupBox3.Controls.Add(this.txtkiemtrasdt);
            this.groupBox3.Controls.Add(this.btnThemkh);
            this.groupBox3.Controls.Add(this.btnKiemtra);
            this.groupBox3.Controls.Add(this.txtkhachhang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(506, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 211);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // dgv_kiemtrakh
            // 
            this.dgv_kiemtrakh.AllowUserToAddRows = false;
            this.dgv_kiemtrakh.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_kiemtrakh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_kiemtrakh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kiemtrakh.Location = new System.Drawing.Point(6, 86);
            this.dgv_kiemtrakh.Name = "dgv_kiemtrakh";
            this.dgv_kiemtrakh.Size = new System.Drawing.Size(264, 81);
            this.dgv_kiemtrakh.TabIndex = 8;
            this.dgv_kiemtrakh.Visible = false;
            // 
            // txtkiemtrasdt
            // 
            this.txtkiemtrasdt.Location = new System.Drawing.Point(92, 22);
            this.txtkiemtrasdt.Name = "txtkiemtrasdt";
            this.txtkiemtrasdt.Size = new System.Drawing.Size(178, 20);
            this.txtkiemtrasdt.TabIndex = 7;
            // 
            // btnThemkh
            // 
            this.btnThemkh.Enabled = false;
            this.btnThemkh.Location = new System.Drawing.Point(182, 182);
            this.btnThemkh.Name = "btnThemkh";
            this.btnThemkh.Size = new System.Drawing.Size(75, 23);
            this.btnThemkh.TabIndex = 5;
            this.btnThemkh.Text = "Thêm";
            this.btnThemkh.UseVisualStyleBackColor = true;
            this.btnThemkh.Click += new System.EventHandler(this.btnThemkh_Click);
            // 
            // btnKiemtra
            // 
            this.btnKiemtra.Location = new System.Drawing.Point(17, 182);
            this.btnKiemtra.Name = "btnKiemtra";
            this.btnKiemtra.Size = new System.Drawing.Size(75, 23);
            this.btnKiemtra.TabIndex = 4;
            this.btnKiemtra.Text = "Kiểm tra";
            this.btnKiemtra.UseVisualStyleBackColor = true;
            this.btnKiemtra.Click += new System.EventHandler(this.btnKiemtra_Click);
            // 
            // txtkhachhang
            // 
            this.txtkhachhang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "TenKH", true));
            this.txtkhachhang.Location = new System.Drawing.Point(92, 57);
            this.txtkhachhang.Name = "txtkhachhang";
            this.txtkhachhang.Size = new System.Drawing.Size(178, 20);
            this.txtkhachhang.TabIndex = 2;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(Ungdungquanlybanhang.KhachHang);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên khách hàng";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Điện thoại";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnlaphoadon
            // 
            this.btnlaphoadon.Location = new System.Drawing.Point(12, 12);
            this.btnlaphoadon.Name = "btnlaphoadon";
            this.btnlaphoadon.Size = new System.Drawing.Size(75, 23);
            this.btnlaphoadon.TabIndex = 12;
            this.btnlaphoadon.Text = "Lập hóa đơn";
            this.btnlaphoadon.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Số hóa đơn";
            // 
            // txtsohoadon
            // 
            this.txtsohoadon.Location = new System.Drawing.Point(206, 15);
            this.txtsohoadon.Name = "txtsohoadon";
            this.txtsohoadon.Size = new System.Drawing.Size(100, 20);
            this.txtsohoadon.TabIndex = 12;
            // 
            // qUANLYBANHANG1DataSet
            // 
            this.qUANLYBANHANG1DataSet.DataSetName = "QUANLYBANHANG1DataSet";
            this.qUANLYBANHANG1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYBANHANG1DataSetBindingSource
            // 
            this.qUANLYBANHANG1DataSetBindingSource.DataSource = this.qUANLYBANHANG1DataSet;
            this.qUANLYBANHANG1DataSetBindingSource.Position = 0;
            // 
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Location = new System.Drawing.Point(328, 18);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(0, 13);
            this.lblNgayLapHD.TabIndex = 14;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Enabled = false;
            this.txtdiachi.HideSelection = false;
            this.txtdiachi.Location = new System.Drawing.Point(662, 14);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(10, 20);
            this.txtdiachi.TabIndex = 15;
            this.txtdiachi.Visible = false;
            // 
            // txtmakh
            // 
            this.txtmakh.Enabled = false;
            this.txtmakh.HideSelection = false;
            this.txtmakh.Location = new System.Drawing.Point(688, 15);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(10, 20);
            this.txtmakh.TabIndex = 16;
            this.txtmakh.Visible = false;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 518);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.lblNgayLapHD);
            this.Controls.Add(this.txtsohoadon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnlaphoadon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluongban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachspban)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kiemtrakh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANHANG1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBANHANG1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemsp;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtdonvitinh;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.ComboBox cbbtensp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtkhachhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlaphoadon;
        private System.Windows.Forms.DataGridView dgv_danhsachspban;
        private System.Windows.Forms.Button btnThemkh;
        private System.Windows.Forms.Button btnKiemtra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsohoadon;
        private System.Windows.Forms.BindingSource hangBindingSource;
        private QUANLYBANHANG1DataSet qUANLYBANHANG1DataSet;
        private System.Windows.Forms.BindingSource qUANLYBANHANG1DataSetBindingSource;
        private System.Windows.Forms.Label txtsoluong;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.NumericUpDown txtsoluongban;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.Label lblthanhtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtkiemtrasdt;
        private System.Windows.Forms.DataGridView dgv_kiemtrakh;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
    }
}