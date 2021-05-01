
namespace WindowsFormsApp2
{
    partial class FormThemBienLai
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
            this.cbbMaHV = new System.Windows.Forms.ComboBox();
            this.lbMaHV = new System.Windows.Forms.Label();
            this.lbMaBL = new System.Windows.Forms.Label();
            this.txbMaBL = new System.Windows.Forms.TextBox();
            this.lbNgayThu = new System.Windows.Forms.Label();
            this.dtPickerNgayThu = new System.Windows.Forms.DateTimePicker();
            this.lbThang = new System.Windows.Forms.Label();
            this.numUpDownThang = new System.Windows.Forms.NumericUpDown();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbThongTin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownThang)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMaHV
            // 
            this.cbbMaHV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHV.FormattingEnabled = true;
            this.cbbMaHV.IntegralHeight = false;
            this.cbbMaHV.Location = new System.Drawing.Point(505, 113);
            this.cbbMaHV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaHV.Name = "cbbMaHV";
            this.cbbMaHV.Size = new System.Drawing.Size(356, 33);
            this.cbbMaHV.TabIndex = 0;
            // 
            // lbMaHV
            // 
            this.lbMaHV.AutoSize = true;
            this.lbMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHV.Location = new System.Drawing.Point(244, 113);
            this.lbMaHV.Name = "lbMaHV";
            this.lbMaHV.Size = new System.Drawing.Size(150, 29);
            this.lbMaHV.TabIndex = 1;
            this.lbMaHV.Text = "Mã học viên";
            // 
            // lbMaBL
            // 
            this.lbMaBL.AutoSize = true;
            this.lbMaBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaBL.Location = new System.Drawing.Point(244, 198);
            this.lbMaBL.Name = "lbMaBL";
            this.lbMaBL.Size = new System.Drawing.Size(136, 29);
            this.lbMaBL.TabIndex = 2;
            this.lbMaBL.Text = "Mã biên lai";
            // 
            // txbMaBL
            // 
            this.txbMaBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaBL.Location = new System.Drawing.Point(505, 196);
            this.txbMaBL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaBL.MaxLength = 10;
            this.txbMaBL.Name = "txbMaBL";
            this.txbMaBL.Size = new System.Drawing.Size(356, 36);
            this.txbMaBL.TabIndex = 3;
            // 
            // lbNgayThu
            // 
            this.lbNgayThu.AutoSize = true;
            this.lbNgayThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThu.Location = new System.Drawing.Point(244, 284);
            this.lbNgayThu.Name = "lbNgayThu";
            this.lbNgayThu.Size = new System.Drawing.Size(114, 29);
            this.lbNgayThu.TabIndex = 2;
            this.lbNgayThu.Text = "Ngày thu";
            // 
            // dtPickerNgayThu
            // 
            this.dtPickerNgayThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerNgayThu.Location = new System.Drawing.Point(505, 287);
            this.dtPickerNgayThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerNgayThu.Name = "dtPickerNgayThu";
            this.dtPickerNgayThu.Size = new System.Drawing.Size(356, 26);
            this.dtPickerNgayThu.TabIndex = 4;
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(244, 368);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(84, 29);
            this.lbThang.TabIndex = 2;
            this.lbThang.Text = "Tháng";
            // 
            // numUpDownThang
            // 
            this.numUpDownThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownThang.Location = new System.Drawing.Point(505, 369);
            this.numUpDownThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numUpDownThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDownThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownThang.Name = "numUpDownThang";
            this.numUpDownThang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numUpDownThang.Size = new System.Drawing.Size(356, 30);
            this.numUpDownThang.TabIndex = 5;
            this.numUpDownThang.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numUpDownThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(244, 448);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(118, 29);
            this.lbTongTien.TabIndex = 2;
            this.lbTongTien.Text = "Tổng tiền";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(316, 527);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 41);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(640, 527);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 41);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(421, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thêm biên lai";
            // 
            // lbThongTin
            // 
            this.lbThongTin.AutoSize = true;
            this.lbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongTin.ForeColor = System.Drawing.Color.Red;
            this.lbThongTin.Location = new System.Drawing.Point(503, 448);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(358, 29);
            this.lbThongTin.TabIndex = 8;
            this.lbThongTin.Text = "Cập nhật tự động sau khi thêm";
            // 
            // FormThemBienLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 601);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numUpDownThang);
            this.Controls.Add(this.dtPickerNgayThu);
            this.Controls.Add(this.txbMaBL);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbNgayThu);
            this.Controls.Add(this.lbMaBL);
            this.Controls.Add(this.lbMaHV);
            this.Controls.Add(this.cbbMaHV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThemBienLai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemBienLai";
            this.Load += new System.EventHandler(this.FormThemBienLai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMaHV;
        private System.Windows.Forms.Label lbMaHV;
        private System.Windows.Forms.Label lbMaBL;
        private System.Windows.Forms.TextBox txbMaBL;
        private System.Windows.Forms.Label lbNgayThu;
        private System.Windows.Forms.DateTimePicker dtPickerNgayThu;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.NumericUpDown numUpDownThang;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbThongTin;
    }
}