
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChonThang = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buoi1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buoi2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buoi3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buoi4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buoi5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buoi6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buoi7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Buoi8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(815, 45);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 27);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Thoát";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
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
            this.comboBoxChonThang.Location = new System.Drawing.Point(12, 45);
            this.comboBoxChonThang.Name = "comboBoxChonThang";
            this.comboBoxChonThang.Size = new System.Drawing.Size(121, 28);
            this.comboBoxChonThang.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenHS,
            this.Buoi1,
            this.Buoi2,
            this.Buoi3,
            this.Buoi4,
            this.Buoi5,
            this.Buoi6,
            this.Buoi7,
            this.Buoi8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(887, 308);
            this.dataGridView1.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // TenHS
            // 
            this.TenHS.HeaderText = "Tên học sinh";
            this.TenHS.Name = "TenHS";
            this.TenHS.Width = 150;
            // 
            // Buoi1
            // 
            this.Buoi1.HeaderText = "";
            this.Buoi1.Name = "Buoi1";
            this.Buoi1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buoi1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buoi1.Width = 80;
            // 
            // Buoi2
            // 
            this.Buoi2.HeaderText = "";
            this.Buoi2.Name = "Buoi2";
            this.Buoi2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buoi2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buoi2.Width = 80;
            // 
            // Buoi3
            // 
            this.Buoi3.HeaderText = "";
            this.Buoi3.Name = "Buoi3";
            this.Buoi3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buoi3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buoi3.Width = 80;
            // 
            // Buoi4
            // 
            this.Buoi4.HeaderText = "";
            this.Buoi4.Name = "Buoi4";
            this.Buoi4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buoi4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buoi4.Width = 80;
            // 
            // Buoi5
            // 
            this.Buoi5.HeaderText = "";
            this.Buoi5.Name = "Buoi5";
            this.Buoi5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buoi5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buoi5.Width = 80;
            // 
            // Buoi6
            // 
            this.Buoi6.HeaderText = "";
            this.Buoi6.Name = "Buoi6";
            this.Buoi6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buoi6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buoi6.Width = 80;
            // 
            // Buoi7
            // 
            this.Buoi7.HeaderText = "";
            this.Buoi7.Name = "Buoi7";
            this.Buoi7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buoi7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buoi7.Width = 80;
            // 
            // Buoi8
            // 
            this.Buoi8.HeaderText = "";
            this.Buoi8.Name = "Buoi8";
            this.Buoi8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Buoi8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Buoi8.Width = 80;
            // 
            // FormQLDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxChonThang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormQLDD";
            this.Text = "FormQLDD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxChonThang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buoi1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buoi2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buoi3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buoi4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buoi5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buoi6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buoi7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Buoi8;
    }
}