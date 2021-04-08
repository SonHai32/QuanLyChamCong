
namespace QL_Cham_Cong
{
    partial class frm_Main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mni_functions = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_fn_report = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_change_theme = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_fn_database_settings = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_fn_log_out = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_fn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_staff = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_staff_add = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_staff_del = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_staff_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_staff_list = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_office = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_off_add = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_off_del = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_off_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_off_list = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_department = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_dep_add = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_dep_del = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_dep_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_dep_list = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_main = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_functions,
            this.mni_staff,
            this.mni_office,
            this.mni_department});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1070, 28);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "Options";
            this.menuBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mni_functions
            // 
            this.mni_functions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_fn_report,
            this.mni_change_theme,
            this.mni_fn_database_settings,
            this.mni_fn_log_out,
            this.mni_fn_exit});
            this.mni_functions.Name = "mni_functions";
            this.mni_functions.Size = new System.Drawing.Size(93, 24);
            this.mni_functions.Text = "Chức năng";
            // 
            // mni_fn_report
            // 
            this.mni_fn_report.BackColor = System.Drawing.Color.Transparent;
            this.mni_fn_report.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_fn_report.Image = global::GUI.Properties.Resources.report;
            this.mni_fn_report.Name = "mni_fn_report";
            this.mni_fn_report.Size = new System.Drawing.Size(332, 30);
            this.mni_fn_report.Text = "Báo cáo & Thống kê điểm danh";
            // 
            // mni_change_theme
            // 
            this.mni_change_theme.BackColor = System.Drawing.Color.Transparent;
            this.mni_change_theme.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_change_theme.Image = global::GUI.Properties.Resources.template;
            this.mni_change_theme.Name = "mni_change_theme";
            this.mni_change_theme.Size = new System.Drawing.Size(332, 30);
            this.mni_change_theme.Text = "Tuỳ chỉnh giao diện";
            // 
            // mni_fn_database_settings
            // 
            this.mni_fn_database_settings.BackColor = System.Drawing.Color.Transparent;
            this.mni_fn_database_settings.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_fn_database_settings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mni_fn_database_settings.Image = global::GUI.Properties.Resources.database_storage;
            this.mni_fn_database_settings.Name = "mni_fn_database_settings";
            this.mni_fn_database_settings.Size = new System.Drawing.Size(332, 30);
            this.mni_fn_database_settings.Text = "Cấu hình DATABASE";
            // 
            // mni_fn_log_out
            // 
            this.mni_fn_log_out.BackColor = System.Drawing.Color.Transparent;
            this.mni_fn_log_out.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_fn_log_out.Image = global::GUI.Properties.Resources.logout;
            this.mni_fn_log_out.Name = "mni_fn_log_out";
            this.mni_fn_log_out.Size = new System.Drawing.Size(332, 30);
            this.mni_fn_log_out.Text = "Đăng xuất";
            // 
            // mni_fn_exit
            // 
            this.mni_fn_exit.BackColor = System.Drawing.Color.Transparent;
            this.mni_fn_exit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_fn_exit.Image = global::GUI.Properties.Resources.exit;
            this.mni_fn_exit.Name = "mni_fn_exit";
            this.mni_fn_exit.Size = new System.Drawing.Size(332, 30);
            this.mni_fn_exit.Text = "Thoát";
            // 
            // mni_staff
            // 
            this.mni_staff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_staff_add,
            this.mni_staff_del,
            this.mni_staff_edit,
            this.mni_staff_list});
            this.mni_staff.Name = "mni_staff";
            this.mni_staff.Size = new System.Drawing.Size(89, 24);
            this.mni_staff.Text = "Nhân viên";
            // 
            // mni_staff_add
            // 
            this.mni_staff_add.BackColor = System.Drawing.Color.Transparent;
            this.mni_staff_add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_staff_add.Image = global::GUI.Properties.Resources.add;
            this.mni_staff_add.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mni_staff_add.Name = "mni_staff_add";
            this.mni_staff_add.Size = new System.Drawing.Size(258, 30);
            this.mni_staff_add.Text = "Thêm";
            // 
            // mni_staff_del
            // 
            this.mni_staff_del.BackColor = System.Drawing.Color.Transparent;
            this.mni_staff_del.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_staff_del.Image = global::GUI.Properties.Resources.remove__1_;
            this.mni_staff_del.Name = "mni_staff_del";
            this.mni_staff_del.Size = new System.Drawing.Size(258, 30);
            this.mni_staff_del.Text = "Xoá";
            // 
            // mni_staff_edit
            // 
            this.mni_staff_edit.BackColor = System.Drawing.Color.Transparent;
            this.mni_staff_edit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_staff_edit.Image = global::GUI.Properties.Resources.edit;
            this.mni_staff_edit.Name = "mni_staff_edit";
            this.mni_staff_edit.Size = new System.Drawing.Size(258, 30);
            this.mni_staff_edit.Text = "Sửa";
            // 
            // mni_staff_list
            // 
            this.mni_staff_list.BackColor = System.Drawing.Color.Transparent;
            this.mni_staff_list.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_staff_list.Image = global::GUI.Properties.Resources.note;
            this.mni_staff_list.Name = "mni_staff_list";
            this.mni_staff_list.Size = new System.Drawing.Size(258, 30);
            this.mni_staff_list.Text = "Danh sách nhân viên";
            // 
            // mni_office
            // 
            this.mni_office.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_off_add,
            this.mni_off_del,
            this.mni_off_edit,
            this.mni_off_list});
            this.mni_office.Name = "mni_office";
            this.mni_office.Size = new System.Drawing.Size(75, 24);
            this.mni_office.Text = "Chức vụ";
            // 
            // mni_off_add
            // 
            this.mni_off_add.BackColor = System.Drawing.Color.Transparent;
            this.mni_off_add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_off_add.Image = global::GUI.Properties.Resources.add;
            this.mni_off_add.Name = "mni_off_add";
            this.mni_off_add.Size = new System.Drawing.Size(243, 30);
            this.mni_off_add.Text = "Thêm";
            // 
            // mni_off_del
            // 
            this.mni_off_del.BackColor = System.Drawing.Color.Transparent;
            this.mni_off_del.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_off_del.Image = global::GUI.Properties.Resources.remove__1_;
            this.mni_off_del.Name = "mni_off_del";
            this.mni_off_del.Size = new System.Drawing.Size(243, 30);
            this.mni_off_del.Text = "Xoá";
            // 
            // mni_off_edit
            // 
            this.mni_off_edit.BackColor = System.Drawing.Color.Transparent;
            this.mni_off_edit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_off_edit.Image = global::GUI.Properties.Resources.edit;
            this.mni_off_edit.Name = "mni_off_edit";
            this.mni_off_edit.Size = new System.Drawing.Size(243, 30);
            this.mni_off_edit.Text = "Sửa";
            // 
            // mni_off_list
            // 
            this.mni_off_list.BackColor = System.Drawing.Color.Transparent;
            this.mni_off_list.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_off_list.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mni_off_list.Image = global::GUI.Properties.Resources.note;
            this.mni_off_list.Name = "mni_off_list";
            this.mni_off_list.Size = new System.Drawing.Size(243, 30);
            this.mni_off_list.Text = "Danh sách chức vụ";
            // 
            // mni_department
            // 
            this.mni_department.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_dep_add,
            this.mni_dep_del,
            this.mni_dep_edit,
            this.mni_dep_list});
            this.mni_department.Name = "mni_department";
            this.mni_department.Size = new System.Drawing.Size(94, 24);
            this.mni_department.Text = "Phòng ban";
            // 
            // mni_dep_add
            // 
            this.mni_dep_add.BackColor = System.Drawing.Color.Transparent;
            this.mni_dep_add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_dep_add.Image = global::GUI.Properties.Resources.add;
            this.mni_dep_add.Name = "mni_dep_add";
            this.mni_dep_add.Size = new System.Drawing.Size(270, 30);
            this.mni_dep_add.Text = "Thêm";
            // 
            // mni_dep_del
            // 
            this.mni_dep_del.BackColor = System.Drawing.Color.Transparent;
            this.mni_dep_del.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_dep_del.Image = global::GUI.Properties.Resources.remove__1_;
            this.mni_dep_del.Name = "mni_dep_del";
            this.mni_dep_del.Size = new System.Drawing.Size(270, 30);
            this.mni_dep_del.Text = "Xoá";
            // 
            // mni_dep_edit
            // 
            this.mni_dep_edit.BackColor = System.Drawing.Color.Transparent;
            this.mni_dep_edit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_dep_edit.Image = global::GUI.Properties.Resources.edit;
            this.mni_dep_edit.Name = "mni_dep_edit";
            this.mni_dep_edit.Size = new System.Drawing.Size(270, 30);
            this.mni_dep_edit.Text = "Sửa";
            // 
            // mni_dep_list
            // 
            this.mni_dep_list.BackColor = System.Drawing.Color.Transparent;
            this.mni_dep_list.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mni_dep_list.Image = global::GUI.Properties.Resources.note;
            this.mni_dep_list.Name = "mni_dep_list";
            this.mni_dep_list.Size = new System.Drawing.Size(270, 30);
            this.mni_dep_list.Text = "Danh sách phòng ban";
            // 
            // pn_main
            // 
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 28);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1070, 704);
            this.pn_main.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 732);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mni_functions;
        private System.Windows.Forms.ToolStripMenuItem mni_fn_report;
        private System.Windows.Forms.ToolStripMenuItem mni_staff;
        private System.Windows.Forms.ToolStripMenuItem mni_office;
        private System.Windows.Forms.ToolStripMenuItem mni_department;
        private System.Windows.Forms.ToolStripMenuItem mni_staff_add;
        private System.Windows.Forms.ToolStripMenuItem mni_staff_del;
        private System.Windows.Forms.ToolStripMenuItem mni_staff_edit;
        private System.Windows.Forms.ToolStripMenuItem mni_staff_list;
        private System.Windows.Forms.ToolStripMenuItem mni_off_add;
        private System.Windows.Forms.ToolStripMenuItem mni_off_del;
        private System.Windows.Forms.ToolStripMenuItem mni_off_edit;
        private System.Windows.Forms.ToolStripMenuItem mni_off_list;
        private System.Windows.Forms.ToolStripMenuItem mni_dep_add;
        private System.Windows.Forms.ToolStripMenuItem mni_dep_del;
        private System.Windows.Forms.ToolStripMenuItem mni_dep_edit;
        private System.Windows.Forms.ToolStripMenuItem mni_dep_list;
        private System.Windows.Forms.ToolStripMenuItem mni_change_theme;
        private System.Windows.Forms.ToolStripMenuItem mni_fn_database_settings;
        private System.Windows.Forms.ToolStripMenuItem mni_fn_log_out;
        private System.Windows.Forms.ToolStripMenuItem mni_fn_exit;
        private System.Windows.Forms.Panel pn_main;
    }
}

