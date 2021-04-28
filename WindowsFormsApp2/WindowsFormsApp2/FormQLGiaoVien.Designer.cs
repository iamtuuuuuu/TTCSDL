
namespace WindowsFormsApp2
{
    partial class FormQLGiaoVien
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTraLuong = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbGVThongTin = new System.Windows.Forms.TextBox();
            this.cbbGVDanhSach = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDanhSachGiaoVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(258, 417);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(188, 50);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa giáo viên";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(44, 417);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(188, 50);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm giáo viên";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTraLuong
            // 
            this.btnTraLuong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraLuong.Location = new System.Drawing.Point(480, 417);
            this.btnTraLuong.Name = "btnTraLuong";
            this.btnTraLuong.Size = new System.Drawing.Size(448, 50);
            this.btnTraLuong.TabIndex = 27;
            this.btnTraLuong.Text = "Quản lý trả lương";
            this.btnTraLuong.UseVisualStyleBackColor = true;
            this.btnTraLuong.Click += new System.EventHandler(this.btnTraLuong_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(840, 345);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 34);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbGVThongTin
            // 
            this.txbGVThongTin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGVThongTin.Location = new System.Drawing.Point(198, 348);
            this.txbGVThongTin.Name = "txbGVThongTin";
            this.txbGVThongTin.Size = new System.Drawing.Size(636, 29);
            this.txbGVThongTin.TabIndex = 25;
            // 
            // cbbGVDanhSach
            // 
            this.cbbGVDanhSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGVDanhSach.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGVDanhSach.FormattingEnabled = true;
            this.cbbGVDanhSach.Items.AddRange(new object[] {
            "Mã giáo viên",
            "Tên giáo viên"});
            this.cbbGVDanhSach.Location = new System.Drawing.Point(46, 348);
            this.cbbGVDanhSach.Name = "cbbGVDanhSach";
            this.cbbGVDanhSach.Size = new System.Drawing.Size(133, 27);
            this.cbbGVDanhSach.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Danh sách giáo viên";
            // 
            // dataGridViewDanhSachGiaoVien
            // 
            this.dataGridViewDanhSachGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDanhSachGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDanhSachGiaoVien.Location = new System.Drawing.Point(12, 66);
            this.dataGridViewDanhSachGiaoVien.Name = "dataGridViewDanhSachGiaoVien";
            this.dataGridViewDanhSachGiaoVien.Size = new System.Drawing.Size(916, 252);
            this.dataGridViewDanhSachGiaoVien.TabIndex = 22;
            this.dataGridViewDanhSachGiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDanhSachGiaoVien_CellDoubleClick);
            // 
            // FormQLGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 485);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTraLuong);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txbGVThongTin);
            this.Controls.Add(this.cbbGVDanhSach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDanhSachGiaoVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQLGiaoVien";
            this.Text = "FormQLGiaoVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormQLGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDanhSachGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTraLuong;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbGVThongTin;
        private System.Windows.Forms.ComboBox cbbGVDanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDanhSachGiaoVien;
    }
}