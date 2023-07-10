
namespace GUI
{
    partial class DichVu_GUI
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbDanhDachOrder = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoaMonAn = new System.Windows.Forms.Button();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.btnGiamThe = new System.Windows.Forms.Button();
            this.btnTangThe = new System.Windows.Forms.Button();
            this.txtSoLuongThe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbThe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGiamNuoc = new System.Windows.Forms.Button();
            this.btnTangNuoc = new System.Windows.Forms.Button();
            this.txtSoLuongNuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbNuoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiamMon = new System.Windows.Forms.Button();
            this.btnTangMon = new System.Windows.Forms.Button();
            this.txtSoLuongDoAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDoAn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSuaThe = new System.Windows.Forms.Button();
            this.btnXoaThe = new System.Windows.Forms.Button();
            this.btnThemThe = new System.Windows.Forms.Button();
            this.dgvThe = new System.Windows.Forms.DataGridView();
            this.TenThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTheOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNuoc = new System.Windows.Forms.DataGridView();
            this.TenNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNuocOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaNuoc = new System.Windows.Forms.Button();
            this.btnThemNuoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDoAn = new System.Windows.Forms.DataGridView();
            this.TenDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.gbDanhDachOrder.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1028, 517);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 36);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // gbDanhDachOrder
            // 
            this.gbDanhDachOrder.Controls.Add(this.btnGiamThe);
            this.gbDanhDachOrder.Controls.Add(this.btnTangThe);
            this.gbDanhDachOrder.Controls.Add(this.txtSoLuongThe);
            this.gbDanhDachOrder.Controls.Add(this.label5);
            this.gbDanhDachOrder.Controls.Add(this.cbbThe);
            this.gbDanhDachOrder.Controls.Add(this.label6);
            this.gbDanhDachOrder.Controls.Add(this.btnGiamNuoc);
            this.gbDanhDachOrder.Controls.Add(this.btnTangNuoc);
            this.gbDanhDachOrder.Controls.Add(this.txtSoLuongNuoc);
            this.gbDanhDachOrder.Controls.Add(this.label3);
            this.gbDanhDachOrder.Controls.Add(this.cbbNuoc);
            this.gbDanhDachOrder.Controls.Add(this.label4);
            this.gbDanhDachOrder.Controls.Add(this.btnGiamMon);
            this.gbDanhDachOrder.Controls.Add(this.txtSoLuongDoAn);
            this.gbDanhDachOrder.Controls.Add(this.label2);
            this.gbDanhDachOrder.Controls.Add(this.groupBox4);
            this.gbDanhDachOrder.Controls.Add(this.groupBox3);
            this.gbDanhDachOrder.Controls.Add(this.groupBox2);
            this.gbDanhDachOrder.Controls.Add(this.btnThoat);
            this.gbDanhDachOrder.Location = new System.Drawing.Point(11, 30);
            this.gbDanhDachOrder.Name = "gbDanhDachOrder";
            this.gbDanhDachOrder.Size = new System.Drawing.Size(572, 404);
            this.gbDanhDachOrder.TabIndex = 13;
            this.gbDanhDachOrder.TabStop = false;
            this.gbDanhDachOrder.Text = ".....................";
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(380, 74);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 42;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoaMonAn
            // 
            this.btnXoaMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaMonAn.Location = new System.Drawing.Point(461, 74);
            this.btnXoaMonAn.Name = "btnXoaMonAn";
            this.btnXoaMonAn.Size = new System.Drawing.Size(75, 23);
            this.btnXoaMonAn.TabIndex = 39;
            this.btnXoaMonAn.Text = "Xóa ";
            this.btnXoaMonAn.UseVisualStyleBackColor = true;
            this.btnXoaMonAn.Click += new System.EventHandler(this.btnXoaMonAn_Click);
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMonAn.Location = new System.Drawing.Point(299, 74);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(75, 23);
            this.btnThemMonAn.TabIndex = 38;
            this.btnThemMonAn.Text = "Thêm";
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // btnGiamThe
            // 
            this.btnGiamThe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiamThe.Location = new System.Drawing.Point(512, 325);
            this.btnGiamThe.Name = "btnGiamThe";
            this.btnGiamThe.Size = new System.Drawing.Size(21, 20);
            this.btnGiamThe.TabIndex = 35;
            this.btnGiamThe.Text = "-";
            this.btnGiamThe.UseVisualStyleBackColor = true;
            this.btnGiamThe.Click += new System.EventHandler(this.btnGiamThe_Click);
            // 
            // btnTangThe
            // 
            this.btnTangThe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTangThe.Location = new System.Drawing.Point(485, 325);
            this.btnTangThe.Name = "btnTangThe";
            this.btnTangThe.Size = new System.Drawing.Size(21, 20);
            this.btnTangThe.TabIndex = 34;
            this.btnTangThe.Text = "+";
            this.btnTangThe.UseVisualStyleBackColor = true;
            this.btnTangThe.Click += new System.EventHandler(this.btnTangThe_Click);
            // 
            // txtSoLuongThe
            // 
            this.txtSoLuongThe.Enabled = false;
            this.txtSoLuongThe.Location = new System.Drawing.Point(358, 325);
            this.txtSoLuongThe.Name = "txtSoLuongThe";
            this.txtSoLuongThe.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuongThe.TabIndex = 33;
            this.txtSoLuongThe.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(289, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Số lượng:";
            // 
            // cbbThe
            // 
            this.cbbThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThe.FormattingEnabled = true;
            this.cbbThe.Location = new System.Drawing.Point(358, 290);
            this.cbbThe.Name = "cbbThe";
            this.cbbThe.Size = new System.Drawing.Size(175, 21);
            this.cbbThe.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(289, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Chọn thẻ:";
            // 
            // btnGiamNuoc
            // 
            this.btnGiamNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiamNuoc.Location = new System.Drawing.Point(512, 181);
            this.btnGiamNuoc.Name = "btnGiamNuoc";
            this.btnGiamNuoc.Size = new System.Drawing.Size(21, 20);
            this.btnGiamNuoc.TabIndex = 29;
            this.btnGiamNuoc.Text = "-";
            this.btnGiamNuoc.UseVisualStyleBackColor = true;
            this.btnGiamNuoc.Click += new System.EventHandler(this.btnGiamNuoc_Click);
            // 
            // btnTangNuoc
            // 
            this.btnTangNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTangNuoc.Location = new System.Drawing.Point(485, 181);
            this.btnTangNuoc.Name = "btnTangNuoc";
            this.btnTangNuoc.Size = new System.Drawing.Size(21, 20);
            this.btnTangNuoc.TabIndex = 28;
            this.btnTangNuoc.Text = "+";
            this.btnTangNuoc.UseVisualStyleBackColor = true;
            this.btnTangNuoc.Click += new System.EventHandler(this.btnTangNuoc_Click);
            // 
            // txtSoLuongNuoc
            // 
            this.txtSoLuongNuoc.Enabled = false;
            this.txtSoLuongNuoc.Location = new System.Drawing.Point(358, 181);
            this.txtSoLuongNuoc.Name = "txtSoLuongNuoc";
            this.txtSoLuongNuoc.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuongNuoc.TabIndex = 27;
            this.txtSoLuongNuoc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(289, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Số lượng:";
            // 
            // cbbNuoc
            // 
            this.cbbNuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNuoc.FormattingEnabled = true;
            this.cbbNuoc.Location = new System.Drawing.Point(358, 146);
            this.cbbNuoc.Name = "cbbNuoc";
            this.cbbNuoc.Size = new System.Drawing.Size(175, 21);
            this.cbbNuoc.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(289, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Chọn nước";
            // 
            // btnGiamMon
            // 
            this.btnGiamMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGiamMon.Location = new System.Drawing.Point(521, 56);
            this.btnGiamMon.Name = "btnGiamMon";
            this.btnGiamMon.Size = new System.Drawing.Size(21, 20);
            this.btnGiamMon.TabIndex = 23;
            this.btnGiamMon.Text = "-";
            this.btnGiamMon.UseVisualStyleBackColor = true;
            this.btnGiamMon.Click += new System.EventHandler(this.btnGiamMon_Click);
            // 
            // btnTangMon
            // 
            this.btnTangMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTangMon.Location = new System.Drawing.Point(488, 38);
            this.btnTangMon.Name = "btnTangMon";
            this.btnTangMon.Size = new System.Drawing.Size(21, 20);
            this.btnTangMon.TabIndex = 22;
            this.btnTangMon.Text = "+";
            this.btnTangMon.UseVisualStyleBackColor = true;
            this.btnTangMon.Click += new System.EventHandler(this.btnTangMon_Click);
            // 
            // txtSoLuongDoAn
            // 
            this.txtSoLuongDoAn.Enabled = false;
            this.txtSoLuongDoAn.Location = new System.Drawing.Point(367, 56);
            this.txtSoLuongDoAn.Name = "txtSoLuongDoAn";
            this.txtSoLuongDoAn.Size = new System.Drawing.Size(121, 20);
            this.txtSoLuongDoAn.TabIndex = 21;
            this.txtSoLuongDoAn.Text = "0";
            this.txtSoLuongDoAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongDoAn_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(298, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Số lượng:";
            // 
            // cbbDoAn
            // 
            this.cbbDoAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDoAn.FormattingEnabled = true;
            this.cbbDoAn.Location = new System.Drawing.Point(361, 11);
            this.cbbDoAn.Name = "cbbDoAn";
            this.cbbDoAn.Size = new System.Drawing.Size(175, 21);
            this.cbbDoAn.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(283, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chọn đồ ăn:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSuaThe);
            this.groupBox4.Controls.Add(this.btnXoaThe);
            this.groupBox4.Controls.Add(this.btnThemThe);
            this.groupBox4.Controls.Add(this.dgvThe);
            this.groupBox4.Location = new System.Drawing.Point(6, 266);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(536, 129);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thẻ";
            // 
            // btnSuaThe
            // 
            this.btnSuaThe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaThe.Location = new System.Drawing.Point(376, 85);
            this.btnSuaThe.Name = "btnSuaThe";
            this.btnSuaThe.Size = new System.Drawing.Size(75, 23);
            this.btnSuaThe.TabIndex = 48;
            this.btnSuaThe.Text = "Sửa";
            this.btnSuaThe.UseVisualStyleBackColor = true;
            this.btnSuaThe.Click += new System.EventHandler(this.btnSuaThe_Click);
            // 
            // btnXoaThe
            // 
            this.btnXoaThe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoaThe.Location = new System.Drawing.Point(457, 85);
            this.btnXoaThe.Name = "btnXoaThe";
            this.btnXoaThe.Size = new System.Drawing.Size(75, 23);
            this.btnXoaThe.TabIndex = 47;
            this.btnXoaThe.Text = "Xóa ";
            this.btnXoaThe.UseVisualStyleBackColor = true;
            this.btnXoaThe.Click += new System.EventHandler(this.btnXoaThe_Click);
            // 
            // btnThemThe
            // 
            this.btnThemThe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemThe.Location = new System.Drawing.Point(295, 85);
            this.btnThemThe.Name = "btnThemThe";
            this.btnThemThe.Size = new System.Drawing.Size(75, 23);
            this.btnThemThe.TabIndex = 46;
            this.btnThemThe.Text = "Thêm";
            this.btnThemThe.UseVisualStyleBackColor = true;
            this.btnThemThe.Click += new System.EventHandler(this.btnThemThe_Click);
            // 
            // dgvThe
            // 
            this.dgvThe.AllowUserToAddRows = false;
            this.dgvThe.AllowUserToDeleteRows = false;
            this.dgvThe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThe,
            this.SoLuongTheOrder});
            this.dgvThe.Location = new System.Drawing.Point(6, 27);
            this.dgvThe.Name = "dgvThe";
            this.dgvThe.ReadOnly = true;
            this.dgvThe.Size = new System.Drawing.Size(256, 96);
            this.dgvThe.TabIndex = 0;
            this.dgvThe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThe_CellClick);
            // 
            // TenThe
            // 
            this.TenThe.DataPropertyName = "TenThe";
            this.TenThe.HeaderText = "Tên thẻ";
            this.TenThe.Name = "TenThe";
            this.TenThe.ReadOnly = true;
            // 
            // SoLuongTheOrder
            // 
            this.SoLuongTheOrder.DataPropertyName = "SoLuongTheOrder";
            this.SoLuongTheOrder.HeaderText = "Số lượng";
            this.SoLuongTheOrder.Name = "SoLuongTheOrder";
            this.SoLuongTheOrder.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNuoc);
            this.groupBox3.Controls.Add(this.btnSuaNuoc);
            this.groupBox3.Controls.Add(this.btnThemNuoc);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Location = new System.Drawing.Point(6, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(536, 118);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nước";
            // 
            // dgvNuoc
            // 
            this.dgvNuoc.AllowUserToAddRows = false;
            this.dgvNuoc.AllowUserToDeleteRows = false;
            this.dgvNuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNuoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNuoc,
            this.SoLuongNuocOrder});
            this.dgvNuoc.Location = new System.Drawing.Point(6, 19);
            this.dgvNuoc.Name = "dgvNuoc";
            this.dgvNuoc.ReadOnly = true;
            this.dgvNuoc.Size = new System.Drawing.Size(256, 85);
            this.dgvNuoc.TabIndex = 0;
            this.dgvNuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNuoc_CellClick);
            // 
            // TenNuoc
            // 
            this.TenNuoc.DataPropertyName = "TenNuoc";
            this.TenNuoc.HeaderText = "Tên nước";
            this.TenNuoc.Name = "TenNuoc";
            this.TenNuoc.ReadOnly = true;
            // 
            // SoLuongNuocOrder
            // 
            this.SoLuongNuocOrder.DataPropertyName = "SoLuongNuocOrder";
            this.SoLuongNuocOrder.HeaderText = "Số lượng";
            this.SoLuongNuocOrder.Name = "SoLuongNuocOrder";
            this.SoLuongNuocOrder.ReadOnly = true;
            // 
            // btnSuaNuoc
            // 
            this.btnSuaNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSuaNuoc.Location = new System.Drawing.Point(376, 81);
            this.btnSuaNuoc.Name = "btnSuaNuoc";
            this.btnSuaNuoc.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNuoc.TabIndex = 45;
            this.btnSuaNuoc.Text = "Sửa";
            this.btnSuaNuoc.UseVisualStyleBackColor = true;
            this.btnSuaNuoc.Click += new System.EventHandler(this.btnSuaNuoc_Click);
            // 
            // btnThemNuoc
            // 
            this.btnThemNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemNuoc.Location = new System.Drawing.Point(295, 81);
            this.btnThemNuoc.Name = "btnThemNuoc";
            this.btnThemNuoc.Size = new System.Drawing.Size(75, 23);
            this.btnThemNuoc.TabIndex = 43;
            this.btnThemNuoc.Text = "Thêm";
            this.btnThemNuoc.UseVisualStyleBackColor = true;
            this.btnThemNuoc.Click += new System.EventHandler(this.btnThemNuoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(457, 81);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemMonAn);
            this.groupBox2.Controls.Add(this.btnXoaMonAn);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.dgvDoAn);
            this.groupBox2.Controls.Add(this.btnTangMon);
            this.groupBox2.Controls.Add(this.cbbDoAn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 103);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đồ ăn";
            // 
            // dgvDoAn
            // 
            this.dgvDoAn.AllowUserToAddRows = false;
            this.dgvDoAn.AllowUserToDeleteRows = false;
            this.dgvDoAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoAn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDoAn,
            this.SoLuong});
            this.dgvDoAn.Location = new System.Drawing.Point(6, 19);
            this.dgvDoAn.Name = "dgvDoAn";
            this.dgvDoAn.ReadOnly = true;
            this.dgvDoAn.Size = new System.Drawing.Size(256, 80);
            this.dgvDoAn.TabIndex = 0;
            this.dgvDoAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoAn_CellClick);
            // 
            // TenDoAn
            // 
            this.TenDoAn.DataPropertyName = "TenDoAn";
            this.TenDoAn.HeaderText = "Tên đồ ăn";
            this.TenDoAn.Name = "TenDoAn";
            this.TenDoAn.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuongDoAnOrder";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Location = new System.Drawing.Point(542, 14);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(35, 13);
            this.lblkThoat.TabIndex = 43;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // DichVu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(591, 438);
            this.Controls.Add(this.lblkThoat);
            this.Controls.Add(this.gbDanhDachOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DichVu_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_GUI";
            this.Load += new System.EventHandler(this.DichVu_GUI_Load);
            this.gbDanhDachOrder.ResumeLayout(false);
            this.gbDanhDachOrder.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox gbDanhDachOrder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDoAn;
        private System.Windows.Forms.Button btnGiamThe;
        private System.Windows.Forms.Button btnTangThe;
        private System.Windows.Forms.TextBox txtSoLuongThe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbThe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGiamNuoc;
        private System.Windows.Forms.Button btnTangNuoc;
        private System.Windows.Forms.TextBox txtSoLuongNuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbNuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGiamMon;
        private System.Windows.Forms.Button btnTangMon;
        private System.Windows.Forms.TextBox txtSoLuongDoAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbDoAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvThe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvNuoc;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.Button btnXoaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnSuaNuoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNuocOrder;
        private System.Windows.Forms.Button btnSuaThe;
        private System.Windows.Forms.Button btnXoaThe;
        private System.Windows.Forms.Button btnThemThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTheOrder;
        private System.Windows.Forms.LinkLabel lblkThoat;
    }
}