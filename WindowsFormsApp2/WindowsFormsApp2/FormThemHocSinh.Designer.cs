
namespace WindowsFormsApp2
{
    partial class FormThemHocSinh
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
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.dtPickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.txbMaHV = new System.Windows.Forms.TextBox();
            this.lbMaHV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.radioBtnNam = new System.Windows.Forms.RadioButton();
            this.radioBtnNu = new System.Windows.Forms.RadioButton();
            this.listBoxLopHoc = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.listBoxChonLop = new System.Windows.Forms.ListBox();
            this.lbLop = new System.Windows.Forms.Label();
            this.btnChuyenVe = new System.Windows.Forms.Button();
            this.lbLopTheoHoc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(213, 303);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(318, 29);
            this.txbDiaChi.TabIndex = 4;
            // 
            // dtPickerNgaySinh
            // 
            this.dtPickerNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerNgaySinh.Location = new System.Drawing.Point(213, 243);
            this.dtPickerNgaySinh.Name = "dtPickerNgaySinh";
            this.dtPickerNgaySinh.Size = new System.Drawing.Size(318, 29);
            this.dtPickerNgaySinh.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(597, 448);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 41);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(268, 448);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 41);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiaChi.Location = new System.Drawing.Point(24, 306);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(67, 24);
            this.lbDiaChi.TabIndex = 38;
            this.lbDiaChi.Text = "Địa chỉ";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaySinh.Location = new System.Drawing.Point(25, 247);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(94, 24);
            this.lbNgaySinh.TabIndex = 36;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Location = new System.Drawing.Point(213, 186);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(318, 29);
            this.txbSDT.TabIndex = 2;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.Location = new System.Drawing.Point(25, 189);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(47, 24);
            this.lbSDT.TabIndex = 34;
            this.lbSDT.Text = "SĐT";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTen.Location = new System.Drawing.Point(213, 129);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(318, 29);
            this.txbHoTen.TabIndex = 1;
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(25, 132);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(66, 24);
            this.lbHoTen.TabIndex = 32;
            this.lbHoTen.Text = "Họ tên";
            // 
            // txbMaHV
            // 
            this.txbMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaHV.Location = new System.Drawing.Point(213, 74);
            this.txbMaHV.MaxLength = 6;
            this.txbMaHV.Name = "txbMaHV";
            this.txbMaHV.ReadOnly = true;
            this.txbMaHV.Size = new System.Drawing.Size(318, 29);
            this.txbMaHV.TabIndex = 0;
            // 
            // lbMaHV
            // 
            this.lbMaHV.AutoSize = true;
            this.lbMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHV.Location = new System.Drawing.Point(25, 74);
            this.lbMaHV.Name = "lbMaHV";
            this.lbMaHV.Size = new System.Drawing.Size(113, 24);
            this.lbMaHV.TabIndex = 30;
            this.lbMaHV.Text = "Mã học viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thông tin học viên";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioiTinh.Location = new System.Drawing.Point(24, 363);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(78, 24);
            this.lbGioiTinh.TabIndex = 44;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // radioBtnNam
            // 
            this.radioBtnNam.AutoSize = true;
            this.radioBtnNam.Checked = true;
            this.radioBtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNam.Location = new System.Drawing.Point(213, 359);
            this.radioBtnNam.Name = "radioBtnNam";
            this.radioBtnNam.Size = new System.Drawing.Size(68, 28);
            this.radioBtnNam.TabIndex = 5;
            this.radioBtnNam.TabStop = true;
            this.radioBtnNam.Text = "Nam";
            this.radioBtnNam.UseVisualStyleBackColor = true;
            // 
            // radioBtnNu
            // 
            this.radioBtnNu.AutoSize = true;
            this.radioBtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNu.Location = new System.Drawing.Point(419, 359);
            this.radioBtnNu.Name = "radioBtnNu";
            this.radioBtnNu.Size = new System.Drawing.Size(53, 28);
            this.radioBtnNu.TabIndex = 6;
            this.radioBtnNu.TabStop = true;
            this.radioBtnNu.Text = "Nữ";
            this.radioBtnNu.UseVisualStyleBackColor = true;
            // 
            // listBoxLopHoc
            // 
            this.listBoxLopHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLopHoc.FormattingEnabled = true;
            this.listBoxLopHoc.ItemHeight = 20;
            this.listBoxLopHoc.Location = new System.Drawing.Point(604, 74);
            this.listBoxLopHoc.Name = "listBoxLopHoc";
            this.listBoxLopHoc.Size = new System.Drawing.Size(105, 244);
            this.listBoxLopHoc.TabIndex = 7;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(726, 143);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(44, 34);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // listBoxChonLop
            // 
            this.listBoxChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChonLop.FormattingEnabled = true;
            this.listBoxChonLop.ItemHeight = 20;
            this.listBoxChonLop.Location = new System.Drawing.Point(788, 74);
            this.listBoxChonLop.Name = "listBoxChonLop";
            this.listBoxChonLop.Size = new System.Drawing.Size(105, 244);
            this.listBoxChonLop.TabIndex = 10;
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLop.Location = new System.Drawing.Point(601, 31);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(110, 24);
            this.lbLop.TabIndex = 44;
            this.lbLop.Text = "Lớp hiện có";
            // 
            // btnChuyenVe
            // 
            this.btnChuyenVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenVe.Location = new System.Drawing.Point(726, 215);
            this.btnChuyenVe.Name = "btnChuyenVe";
            this.btnChuyenVe.Size = new System.Drawing.Size(44, 34);
            this.btnChuyenVe.TabIndex = 9;
            this.btnChuyenVe.Text = "<";
            this.btnChuyenVe.UseVisualStyleBackColor = true;
            this.btnChuyenVe.Click += new System.EventHandler(this.btnChuyenVe_Click);
            // 
            // lbLopTheoHoc
            // 
            this.lbLopTheoHoc.AutoSize = true;
            this.lbLopTheoHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLopTheoHoc.Location = new System.Drawing.Point(751, 31);
            this.lbLopTheoHoc.Name = "lbLopTheoHoc";
            this.lbLopTheoHoc.Size = new System.Drawing.Size(170, 24);
            this.lbLopTheoHoc.TabIndex = 44;
            this.lbLopTheoHoc.Text = "Lớp đang theo học";
            // 
            // FormThemHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 526);
            this.Controls.Add(this.btnChuyenVe);
            this.Controls.Add(this.listBoxChonLop);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.listBoxLopHoc);
            this.Controls.Add(this.radioBtnNu);
            this.Controls.Add(this.radioBtnNam);
            this.Controls.Add(this.lbLopTheoHoc);
            this.Controls.Add(this.lbLop);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.dtPickerNgaySinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbDiaChi);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.txbMaHV);
            this.Controls.Add(this.lbMaHV);
            this.Controls.Add(this.label1);
            this.Name = "FormThemHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemHocSinh";
            this.Load += new System.EventHandler(this.FormThemHocSinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.DateTimePicker dtPickerNgaySinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.TextBox txbMaHV;
        private System.Windows.Forms.Label lbMaHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.RadioButton radioBtnNam;
        private System.Windows.Forms.RadioButton radioBtnNu;
        private System.Windows.Forms.ListBox listBoxLopHoc;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.ListBox listBoxChonLop;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Button btnChuyenVe;
        private System.Windows.Forms.Label lbLopTheoHoc;
    }
}