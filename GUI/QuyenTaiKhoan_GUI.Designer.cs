
namespace GUI
{
    partial class QuyenTaiKhoan_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            this.txtTenQuyen = new System.Windows.Forms.TextBox();
            this.dgvQuyenTaiKhoan = new System.Windows.Forms.DataGridView();
            this.MaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyenTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã quyền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên quyền:";
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Location = new System.Drawing.Point(75, 16);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(357, 20);
            this.txtMaQuyen.TabIndex = 2;
            // 
            // txtTenQuyen
            // 
            this.txtTenQuyen.Location = new System.Drawing.Point(75, 45);
            this.txtTenQuyen.Name = "txtTenQuyen";
            this.txtTenQuyen.Size = new System.Drawing.Size(357, 20);
            this.txtTenQuyen.TabIndex = 3;
            // 
            // dgvQuyenTaiKhoan
            // 
            this.dgvQuyenTaiKhoan.AllowUserToAddRows = false;
            this.dgvQuyenTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvQuyenTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuyenTaiKhoan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuyenTaiKhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvQuyenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQuyenTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyenTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuyen,
            this.TenQuyen});
            this.dgvQuyenTaiKhoan.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvQuyenTaiKhoan.Location = new System.Drawing.Point(6, 71);
            this.dgvQuyenTaiKhoan.MultiSelect = false;
            this.dgvQuyenTaiKhoan.Name = "dgvQuyenTaiKhoan";
            this.dgvQuyenTaiKhoan.ReadOnly = true;
            this.dgvQuyenTaiKhoan.Size = new System.Drawing.Size(426, 150);
            this.dgvQuyenTaiKhoan.TabIndex = 4;
            this.dgvQuyenTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyenTaiKhoan_CellClick);
            // 
            // MaQuyen
            // 
            this.MaQuyen.DataPropertyName = "MaQuyen";
            this.MaQuyen.HeaderText = "Mã quyền";
            this.MaQuyen.Name = "MaQuyen";
            this.MaQuyen.ReadOnly = true;
            // 
            // TenQuyen
            // 
            this.TenQuyen.DataPropertyName = "TenQuyen";
            this.TenQuyen.HeaderText = "Tên quyền";
            this.TenQuyen.Name = "TenQuyen";
            this.TenQuyen.ReadOnly = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(356, 227);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 8;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // QuyenTaiKhoan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 254);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvQuyenTaiKhoan);
            this.Controls.Add(this.txtTenQuyen);
            this.Controls.Add(this.txtMaQuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuyenTaiKhoan_GUI";
            this.Text = "Quyền tài khoản";
            this.Load += new System.EventHandler(this.QuyenTaiKhoan_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyenTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaQuyen;
        private System.Windows.Forms.TextBox txtTenQuyen;
        private System.Windows.Forms.DataGridView dgvQuyenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyen;
        private System.Windows.Forms.Button btnLamMoi;
    }
}

