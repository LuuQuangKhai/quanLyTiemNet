
namespace GUI
{
    partial class ThongTinMay_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvThongTinMay = new System.Windows.Forms.DataGridView();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblThoiGianSuDung = new System.Windows.Forms.Label();
            this.lblThoiGianDong = new System.Windows.Forms.Label();
            this.lblThoiGianMo = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblMay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDongMay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnMoMay = new System.Windows.Forms.Button();
            this.dgvDanhSachMay = new System.Windows.Forms.DataGridView();
            this.TenMay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lblkLamMoi = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinMay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTinMay
            // 
            this.dgvThongTinMay.AllowUserToAddRows = false;
            this.dgvThongTinMay.AllowUserToDeleteRows = false;
            this.dgvThongTinMay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThongTinMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinMay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMay,
            this.TrangThai,
            this.ThoiGianMo,
            this.ThoiGianDong,
            this.ThoiGianSuDung,
            this.MaNhanVien});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinMay.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvThongTinMay.Location = new System.Drawing.Point(254, 192);
            this.dgvThongTinMay.MultiSelect = false;
            this.dgvThongTinMay.Name = "dgvThongTinMay";
            this.dgvThongTinMay.ReadOnly = true;
            this.dgvThongTinMay.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvThongTinMay.Size = new System.Drawing.Size(416, 204);
            this.dgvThongTinMay.TabIndex = 0;
            this.dgvThongTinMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinMay_CellClick);
            // 
            // TenMay
            // 
            this.TenMay.DataPropertyName = "TenMay";
            this.TenMay.HeaderText = "Máy";
            this.TenMay.Name = "TenMay";
            this.TenMay.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // ThoiGianMo
            // 
            this.ThoiGianMo.DataPropertyName = "ThoiGianMo";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.ThoiGianMo.DefaultCellStyle = dataGridViewCellStyle1;
            this.ThoiGianMo.HeaderText = "Thời gian mở";
            this.ThoiGianMo.Name = "ThoiGianMo";
            this.ThoiGianMo.ReadOnly = true;
            // 
            // ThoiGianDong
            // 
            this.ThoiGianDong.DataPropertyName = "ThoiGianDong";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.ThoiGianDong.DefaultCellStyle = dataGridViewCellStyle2;
            this.ThoiGianDong.HeaderText = "Thời gian đóng";
            this.ThoiGianDong.Name = "ThoiGianDong";
            this.ThoiGianDong.ReadOnly = true;
            // 
            // ThoiGianSuDung
            // 
            this.ThoiGianSuDung.DataPropertyName = "ThoiGianSuDung";
            dataGridViewCellStyle3.Format = "G";
            this.ThoiGianSuDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.ThoiGianSuDung.HeaderText = "Thời gian sử dụng";
            this.ThoiGianSuDung.Name = "ThoiGianSuDung";
            this.ThoiGianSuDung.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Nhân viên thực thi";
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblThoiGianSuDung);
            this.groupBox1.Controls.Add(this.lblThoiGianDong);
            this.groupBox1.Controls.Add(this.lblThoiGianMo);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.lblMay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblThoiGianSuDung
            // 
            this.lblThoiGianSuDung.AutoSize = true;
            this.lblThoiGianSuDung.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGianSuDung.Location = new System.Drawing.Point(356, 68);
            this.lblThoiGianSuDung.Name = "lblThoiGianSuDung";
            this.lblThoiGianSuDung.Size = new System.Drawing.Size(0, 13);
            this.lblThoiGianSuDung.TabIndex = 10;
            // 
            // lblThoiGianDong
            // 
            this.lblThoiGianDong.AutoSize = true;
            this.lblThoiGianDong.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGianDong.Location = new System.Drawing.Point(356, 42);
            this.lblThoiGianDong.Name = "lblThoiGianDong";
            this.lblThoiGianDong.Size = new System.Drawing.Size(0, 13);
            this.lblThoiGianDong.TabIndex = 9;
            // 
            // lblThoiGianMo
            // 
            this.lblThoiGianMo.AutoSize = true;
            this.lblThoiGianMo.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGianMo.Location = new System.Drawing.Point(356, 16);
            this.lblThoiGianMo.Name = "lblThoiGianMo";
            this.lblThoiGianMo.Size = new System.Drawing.Size(0, 13);
            this.lblThoiGianMo.TabIndex = 8;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lblTrangThai.Location = new System.Drawing.Point(70, 42);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(0, 13);
            this.lblTrangThai.TabIndex = 7;
            // 
            // lblMay
            // 
            this.lblMay.AutoSize = true;
            this.lblMay.ForeColor = System.Drawing.Color.Red;
            this.lblMay.Location = new System.Drawing.Point(71, 16);
            this.lblMay.Name = "lblMay";
            this.lblMay.Size = new System.Drawing.Size(0, 13);
            this.lblMay.TabIndex = 6;
            this.lblMay.TextChanged += new System.EventHandler(this.lblMay_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thời gian mở:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thời gian đóng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian sử dụng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân viên:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblkThoat);
            this.panel1.Controls.Add(this.lblNhanVien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblThoiGian);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 39);
            this.panel1.TabIndex = 2;
            // 
            // lblkThoat
            // 
            this.lblkThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.LinkColor = System.Drawing.Color.White;
            this.lblkThoat.Location = new System.Drawing.Point(607, 24);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(35, 13);
            this.lblkThoat.TabIndex = 11;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblNhanVien.Location = new System.Drawing.Point(71, 10);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(100, 13);
            this.lblNhanVien.TabIndex = 3;
            this.lblNhanVien.Text = "...............................";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGian.Location = new System.Drawing.Point(489, 10);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(0, 13);
            this.lblThoiGian.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thời gian hiện tại:";
            // 
            // btnDongMay
            // 
            this.btnDongMay.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDongMay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDongMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongMay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDongMay.Location = new System.Drawing.Point(6, 48);
            this.btnDongMay.Name = "btnDongMay";
            this.btnDongMay.Size = new System.Drawing.Size(106, 23);
            this.btnDongMay.TabIndex = 3;
            this.btnDongMay.Text = "Đóng máy";
            this.btnDongMay.UseVisualStyleBackColor = false;
            this.btnDongMay.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.btnDichVu);
            this.groupBox2.Controls.Add(this.btnMoMay);
            this.groupBox2.Controls.Add(this.btnDongMay);
            this.groupBox2.Location = new System.Drawing.Point(547, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 112);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDichVu.Location = new System.Drawing.Point(6, 77);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(106, 23);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnMoMay
            // 
            this.btnMoMay.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMoMay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoMay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMoMay.Location = new System.Drawing.Point(6, 19);
            this.btnMoMay.Name = "btnMoMay";
            this.btnMoMay.Size = new System.Drawing.Size(106, 23);
            this.btnMoMay.TabIndex = 0;
            this.btnMoMay.Text = "Mở máy";
            this.btnMoMay.UseVisualStyleBackColor = false;
            this.btnMoMay.Click += new System.EventHandler(this.btnMoMay_Click);
            // 
            // dgvDanhSachMay
            // 
            this.dgvDanhSachMay.AllowUserToAddRows = false;
            this.dgvDanhSachMay.AllowUserToDeleteRows = false;
            this.dgvDanhSachMay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDanhSachMay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachMay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDanhSachMay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMay2,
            this.TrangThai2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachMay.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachMay.Location = new System.Drawing.Point(12, 192);
            this.dgvDanhSachMay.MultiSelect = false;
            this.dgvDanhSachMay.Name = "dgvDanhSachMay";
            this.dgvDanhSachMay.ReadOnly = true;
            this.dgvDanhSachMay.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachMay.Size = new System.Drawing.Size(240, 204);
            this.dgvDanhSachMay.TabIndex = 7;
            this.dgvDanhSachMay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachMay_CellClick);
            // 
            // TenMay2
            // 
            this.TenMay2.DataPropertyName = "TenMay";
            this.TenMay2.HeaderText = "Tên máy";
            this.TenMay2.Name = "TenMay2";
            this.TenMay2.ReadOnly = true;
            // 
            // TrangThai2
            // 
            this.TrangThai2.DataPropertyName = "TrangThai";
            this.TrangThai2.HeaderText = "Trạng thái";
            this.TrangThai2.Name = "TrangThai2";
            this.TrangThai2.ReadOnly = true;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTinhTien.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTinhTien.Location = new System.Drawing.Point(564, 402);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(106, 23);
            this.btnTinhTien.TabIndex = 8;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click_1);
            // 
            // lblkLamMoi
            // 
            this.lblkLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblkLamMoi.AutoSize = true;
            this.lblkLamMoi.LinkColor = System.Drawing.Color.White;
            this.lblkLamMoi.Location = new System.Drawing.Point(251, 176);
            this.lblkLamMoi.Name = "lblkLamMoi";
            this.lblkLamMoi.Size = new System.Drawing.Size(46, 13);
            this.lblkLamMoi.TabIndex = 10;
            this.lblkLamMoi.TabStop = true;
            this.lblkLamMoi.Text = "Làm mới";
            this.lblkLamMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkLamMoi_LinkClicked);
            // 
            // ThongTinMay_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(674, 439);
            this.Controls.Add(this.lblkLamMoi);
            this.Controls.Add(this.dgvDanhSachMay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvThongTinMay);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongTinMay_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinMay_GUI";
            this.Load += new System.EventHandler(this.ThongTinMay_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinMay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinMay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Button btnDongMay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnMoMay;
        private System.Windows.Forms.DataGridView dgvDanhSachMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.Label lblThoiGianSuDung;
        private System.Windows.Forms.Label lblThoiGianDong;
        private System.Windows.Forms.Label lblThoiGianMo;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblMay;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.LinkLabel lblkLamMoi;
        private System.Windows.Forms.LinkLabel lblkThoat;
    }
}