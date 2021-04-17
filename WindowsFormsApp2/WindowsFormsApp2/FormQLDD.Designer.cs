
namespace WindowsFormsApp2
{
    partial class FormQLDD
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
            this.comboBoxChonThang = new System.Windows.Forms.ComboBox();
            this.dataGridViewQLDiemDanh = new System.Windows.Forms.DataGridView();
            this.comboBoxChonLop = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDiemDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách học sinh";
            // 
            // comboBoxChonThang
            // 
            this.comboBoxChonThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChonThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChonThang.FormattingEnabled = true;
            this.comboBoxChonThang.Items.AddRange(new object[] {
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
            this.comboBoxChonThang.Location = new System.Drawing.Point(12, 12);
            this.comboBoxChonThang.Name = "comboBoxChonThang";
            this.comboBoxChonThang.Size = new System.Drawing.Size(121, 28);
            this.comboBoxChonThang.TabIndex = 5;
            // 
            // dataGridViewQLDiemDanh
            // 
            this.dataGridViewQLDiemDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQLDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLDiemDanh.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewQLDiemDanh.Name = "dataGridViewQLDiemDanh";
            this.dataGridViewQLDiemDanh.Size = new System.Drawing.Size(887, 313);
            this.dataGridViewQLDiemDanh.TabIndex = 4;
            this.dataGridViewQLDiemDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQLDiemDanh_CellClick);
            // 
            // comboBoxChonLop
            // 
            this.comboBoxChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChonLop.FormattingEnabled = true;
            this.comboBoxChonLop.Items.AddRange(new object[] {
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
            this.comboBoxChonLop.Location = new System.Drawing.Point(169, 12);
            this.comboBoxChonLop.Name = "comboBoxChonLop";
            this.comboBoxChonLop.Size = new System.Drawing.Size(121, 28);
            this.comboBoxChonLop.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(352, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(422, 31);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(169, 61);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(121, 35);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Lọc";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(797, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 31);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 61);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 35);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm buổi học";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(778, 67);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(121, 35);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormQLDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.comboBoxChonLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChonThang);
            this.Controls.Add(this.dataGridViewQLDiemDanh);
            this.Name = "FormQLDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQLDD";
            this.Load += new System.EventHandler(this.FormQLDD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDiemDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxChonThang;
        private System.Windows.Forms.DataGridView dataGridViewQLDiemDanh;
        private System.Windows.Forms.ComboBox comboBoxChonLop;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
    }
}