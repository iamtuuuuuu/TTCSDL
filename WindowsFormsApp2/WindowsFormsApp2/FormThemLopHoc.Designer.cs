
namespace WindowsFormsApp2
{
    partial class FormThemLopHoc
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
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMaMonHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMaGiaoVien = new System.Windows.Forms.ComboBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.comboBoxMaMHP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin lớp học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã lớp";
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaLop.Location = new System.Drawing.Point(167, 110);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(216, 29);
            this.textBoxMaLop.TabIndex = 2;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenLop.Location = new System.Drawing.Point(167, 176);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(216, 29);
            this.textBoxTenLop.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã MHP";
            // 
            // comboBoxMaMonHoc
            // 
            this.comboBoxMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaMonHoc.FormattingEnabled = true;
            this.comboBoxMaMonHoc.Location = new System.Drawing.Point(167, 320);
            this.comboBoxMaMonHoc.Name = "comboBoxMaMonHoc";
            this.comboBoxMaMonHoc.Size = new System.Drawing.Size(216, 32);
            this.comboBoxMaMonHoc.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã môn học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã giáo viên";
            // 
            // comboBoxMaGiaoVien
            // 
            this.comboBoxMaGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaGiaoVien.FormattingEnabled = true;
            this.comboBoxMaGiaoVien.Location = new System.Drawing.Point(167, 392);
            this.comboBoxMaGiaoVien.Name = "comboBoxMaGiaoVien";
            this.comboBoxMaGiaoVien.Size = new System.Drawing.Size(216, 32);
            this.comboBoxMaGiaoVien.TabIndex = 9;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLuu.Location = new System.Drawing.Point(271, 455);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(112, 41);
            this.buttonLuu.TabIndex = 11;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(34, 455);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(112, 41);
            this.buttonThoat.TabIndex = 12;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // comboBoxMaMHP
            // 
            this.comboBoxMaMHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaMHP.FormattingEnabled = true;
            this.comboBoxMaMHP.Location = new System.Drawing.Point(167, 243);
            this.comboBoxMaMHP.Name = "comboBoxMaMHP";
            this.comboBoxMaMHP.Size = new System.Drawing.Size(216, 32);
            this.comboBoxMaMHP.TabIndex = 13;
            // 
            // FormThemLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 508);
            this.Controls.Add(this.comboBoxMaMHP);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMaGiaoVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMaMonHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTenLop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemLopHoc";
            this.Text = "FormThemLopHoc";
            this.Load += new System.EventHandler(this.FormThemLopHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMaMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMaGiaoVien;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.ComboBox comboBoxMaMHP;
    }
}