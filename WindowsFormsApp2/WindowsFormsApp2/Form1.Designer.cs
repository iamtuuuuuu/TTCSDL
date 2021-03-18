
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyHocSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyGiaoVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyLopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HuongDanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdminToolStripMenuItem,
            this.QuanLyHocSinhToolStripMenuItem,
            this.QuanLyGiaoVienToolStripMenuItem,
            this.QuanLyLopHocToolStripMenuItem,
            this.HuongDanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoiMatKhauToolStripMenuItem,
            this.ThoatToolStripMenuItem});
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.AdminToolStripMenuItem.Text = "ADMIN";
            // 
            // DoiMatKhauToolStripMenuItem
            // 
            this.DoiMatKhauToolStripMenuItem.Name = "DoiMatKhauToolStripMenuItem";
            this.DoiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.DoiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.DoiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.DoiMatKhauToolStripMenuItem_Click);
            // 
            // ThoatToolStripMenuItem
            // 
            this.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem";
            this.ThoatToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.ThoatToolStripMenuItem.Text = "Thoát";
            this.ThoatToolStripMenuItem.Click += new System.EventHandler(this.ThoatToolStripMenuItem_Click);
            // 
            // QuanLyHocSinhToolStripMenuItem
            // 
            this.QuanLyHocSinhToolStripMenuItem.Name = "QuanLyHocSinhToolStripMenuItem";
            this.QuanLyHocSinhToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.QuanLyHocSinhToolStripMenuItem.Text = "Quản lý học sinh";
            this.QuanLyHocSinhToolStripMenuItem.Click += new System.EventHandler(this.QuanLyHocSinhToolStripMenuItem_Click);
            // 
            // QuanLyGiaoVienToolStripMenuItem
            // 
            this.QuanLyGiaoVienToolStripMenuItem.Name = "QuanLyGiaoVienToolStripMenuItem";
            this.QuanLyGiaoVienToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.QuanLyGiaoVienToolStripMenuItem.Text = "Quản lý giáo viên";
            this.QuanLyGiaoVienToolStripMenuItem.Click += new System.EventHandler(this.QuanLyGiaoVienToolStripMenuItem_Click_1);
            // 
            // QuanLyLopHocToolStripMenuItem
            // 
            this.QuanLyLopHocToolStripMenuItem.Name = "QuanLyLopHocToolStripMenuItem";
            this.QuanLyLopHocToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.QuanLyLopHocToolStripMenuItem.Text = "Quản lý lớp học";
            this.QuanLyLopHocToolStripMenuItem.Click += new System.EventHandler(this.QuanLyLopHocToolStripMenuItem_Click_1);
            // 
            // HuongDanToolStripMenuItem
            // 
            this.HuongDanToolStripMenuItem.Name = "HuongDanToolStripMenuItem";
            this.HuongDanToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.HuongDanToolStripMenuItem.Text = "Hướng dẫn";
            this.HuongDanToolStripMenuItem.Click += new System.EventHandler(this.HuongDanToolStripMenuItem_Click);
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(0, 27);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(944, 447);
            this.panelContent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 473);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyHocSinhToolStripMenuItem;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ToolStripMenuItem QuanLyGiaoVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuanLyLopHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HuongDanToolStripMenuItem;
    }
}

