
namespace WindowsFormsApp2
{
    partial class FormBienLaiHV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaHV = new System.Windows.Forms.Label();
            this.dgvBienLaiChiTiet = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSoThangNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbThangDong = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.dtpkNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.ckbDongTien = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienLaiChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.BackColor = System.Drawing.SystemColors.Control;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(124, 356);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(57, 24);
            this.lbTongTien.TabIndex = 19;
            this.lbTongTien.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tổng tiền: ";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(100, 151);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(57, 24);
            this.lbHoTen.TabIndex = 16;
            this.lbHoTen.Text = "None";
            // 
            // lbMaHV
            // 
            this.lbMaHV.AutoSize = true;
            this.lbMaHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHV.Location = new System.Drawing.Point(151, 98);
            this.lbMaHV.Name = "lbMaHV";
            this.lbMaHV.Size = new System.Drawing.Size(57, 24);
            this.lbMaHV.TabIndex = 15;
            this.lbMaHV.Text = "None";
            // 
            // dgvBienLaiChiTiet
            // 
            this.dgvBienLaiChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBienLaiChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBienLaiChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBienLaiChiTiet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBienLaiChiTiet.Location = new System.Drawing.Point(360, 124);
            this.dgvBienLaiChiTiet.Name = "dgvBienLaiChiTiet";
            this.dgvBienLaiChiTiet.RowHeadersWidth = 51;
            this.dgvBienLaiChiTiet.Size = new System.Drawing.Size(671, 243);
            this.dgvBienLaiChiTiet.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày thanh toán: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ tên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã học viên: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Biên lai thu học phí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Số tháng nợ:";
            // 
            // lbSoThangNo
            // 
            this.lbSoThangNo.AutoSize = true;
            this.lbSoThangNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoThangNo.Location = new System.Drawing.Point(136, 253);
            this.lbSoThangNo.Name = "lbSoThangNo";
            this.lbSoThangNo.Size = new System.Drawing.Size(57, 24);
            this.lbSoThangNo.TabIndex = 19;
            this.lbSoThangNo.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tháng:";
            // 
            // lbThangDong
            // 
            this.lbThangDong.AutoSize = true;
            this.lbThangDong.BackColor = System.Drawing.SystemColors.Control;
            this.lbThangDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThangDong.Location = new System.Drawing.Point(94, 304);
            this.lbThangDong.Name = "lbThangDong";
            this.lbThangDong.Size = new System.Drawing.Size(57, 24);
            this.lbThangDong.TabIndex = 19;
            this.lbThangDong.Text = "None";
            // 
            // cbbThang
            // 
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cbbThang.Location = new System.Drawing.Point(839, 27);
            this.cbbThang.MaxDropDownItems = 6;
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 24);
            this.cbbThang.TabIndex = 20;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // dtpkNgayThanhToan
            // 
            this.dtpkNgayThanhToan.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayThanhToan.Location = new System.Drawing.Point(181, 203);
            this.dtpkNgayThanhToan.Name = "dtpkNgayThanhToan";
            this.dtpkNgayThanhToan.Size = new System.Drawing.Size(90, 23);
            this.dtpkNgayThanhToan.TabIndex = 21;
            this.dtpkNgayThanhToan.Value = new System.DateTime(2021, 6, 26, 0, 0, 0, 0);
            // 
            // ckbDongTien
            // 
            this.ckbDongTien.AutoSize = true;
            this.ckbDongTien.Location = new System.Drawing.Point(278, 208);
            this.ckbDongTien.Name = "ckbDongTien";
            this.ckbDongTien.Size = new System.Drawing.Size(15, 14);
            this.ckbDongTien.TabIndex = 22;
            this.ckbDongTien.UseVisualStyleBackColor = true;
            this.ckbDongTien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ckbDongTien_MouseClick);
            // 
            // FormBienLaiHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 427);
            this.Controls.Add(this.ckbDongTien);
            this.Controls.Add(this.dtpkNgayThanhToan);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.lbSoThangNo);
            this.Controls.Add(this.lbThangDong);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbMaHV);
            this.Controls.Add(this.dgvBienLaiChiTiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBienLaiHV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBienLaiHV";
            this.Load += new System.EventHandler(this.FormBienLaiHV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienLaiChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaHV;
        private System.Windows.Forms.DataGridView dgvBienLaiChiTiet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSoThangNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbThangDong;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.DateTimePicker dtpkNgayThanhToan;
        private System.Windows.Forms.CheckBox ckbDongTien;
    }
}