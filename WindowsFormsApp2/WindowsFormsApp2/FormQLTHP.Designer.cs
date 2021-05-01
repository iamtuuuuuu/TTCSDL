
namespace WindowsFormsApp2
{
    partial class FormQLTHP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBienLaiHP = new System.Windows.Forms.DataGridView();
            this.btnThemBL = new System.Windows.Forms.Button();
            this.btnXoaBL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienLaiHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBienLaiHP
            // 
            this.dgvBienLaiHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBienLaiHP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBienLaiHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBienLaiHP.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBienLaiHP.Location = new System.Drawing.Point(79, 30);
            this.dgvBienLaiHP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBienLaiHP.Name = "dgvBienLaiHP";
            this.dgvBienLaiHP.RowHeadersWidth = 51;
            this.dgvBienLaiHP.Size = new System.Drawing.Size(1092, 635);
            this.dgvBienLaiHP.TabIndex = 0;
            this.dgvBienLaiHP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBienLaiHP_CellDoubleClick);
            // 
            // btnThemBL
            // 
            this.btnThemBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBL.Location = new System.Drawing.Point(232, 688);
            this.btnThemBL.Name = "btnThemBL";
            this.btnThemBL.Size = new System.Drawing.Size(193, 40);
            this.btnThemBL.TabIndex = 1;
            this.btnThemBL.Text = "Thêm biên lai";
            this.btnThemBL.UseVisualStyleBackColor = true;
            this.btnThemBL.Click += new System.EventHandler(this.btnThemBL_Click);
            // 
            // btnXoaBL
            // 
            this.btnXoaBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBL.Location = new System.Drawing.Point(791, 688);
            this.btnXoaBL.Name = "btnXoaBL";
            this.btnXoaBL.Size = new System.Drawing.Size(193, 40);
            this.btnXoaBL.TabIndex = 2;
            this.btnXoaBL.Text = "Xóa biên lai";
            this.btnXoaBL.UseVisualStyleBackColor = true;
            this.btnXoaBL.Click += new System.EventHandler(this.btnXoaBL_Click);
            // 
            // FormQLTHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 764);
            this.Controls.Add(this.btnXoaBL);
            this.Controls.Add(this.btnThemBL);
            this.Controls.Add(this.dgvBienLaiHP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQLTHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLTHP";
            this.Load += new System.EventHandler(this.FormQLTHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBienLaiHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBienLaiHP;
        private System.Windows.Forms.Button btnThemBL;
        private System.Windows.Forms.Button btnXoaBL;
    }
}