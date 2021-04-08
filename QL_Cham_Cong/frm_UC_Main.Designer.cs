
namespace GUI
{
    partial class frm_UC_Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_main_staff = new System.Windows.Forms.Button();
            this.btn_main_office = new System.Windows.Forms.Button();
            this.btn_main_department = new System.Windows.Forms.Button();
            this.btn_main_attendance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_main_staff
            // 
            this.btn_main_staff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_main_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_staff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_staff.Image = global::GUI.Properties.Resources.staff;
            this.btn_main_staff.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_main_staff.Location = new System.Drawing.Point(62, 62);
            this.btn_main_staff.Name = "btn_main_staff";
            this.btn_main_staff.Size = new System.Drawing.Size(450, 220);
            this.btn_main_staff.TabIndex = 0;
            this.btn_main_staff.Text = "Quản lý nhân viên";
            this.btn_main_staff.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_main_staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_main_staff.UseVisualStyleBackColor = true;
            this.btn_main_staff.Click += new System.EventHandler(this.btn_main_staff_Click);
            // 
            // btn_main_office
            // 
            this.btn_main_office.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_main_office.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_office.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_office.Image = global::GUI.Properties.Resources.office;
            this.btn_main_office.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_main_office.Location = new System.Drawing.Point(574, 62);
            this.btn_main_office.Name = "btn_main_office";
            this.btn_main_office.Size = new System.Drawing.Size(450, 220);
            this.btn_main_office.TabIndex = 0;
            this.btn_main_office.Text = "Quản lý chức vụ";
            this.btn_main_office.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_main_office.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_main_office.UseVisualStyleBackColor = true;
            this.btn_main_office.Click += new System.EventHandler(this.btn_main_office_Click);
            // 
            // btn_main_department
            // 
            this.btn_main_department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_main_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_department.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_department.Image = global::GUI.Properties.Resources.department__1_;
            this.btn_main_department.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_main_department.Location = new System.Drawing.Point(62, 338);
            this.btn_main_department.Name = "btn_main_department";
            this.btn_main_department.Size = new System.Drawing.Size(450, 220);
            this.btn_main_department.TabIndex = 0;
            this.btn_main_department.Text = "Quản lý phòng ban";
            this.btn_main_department.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_main_department.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_main_department.UseVisualStyleBackColor = true;
            this.btn_main_department.Click += new System.EventHandler(this.btn_main_department_Click);
            // 
            // btn_main_attendance
            // 
            this.btn_main_attendance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_main_attendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_attendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_attendance.Image = global::GUI.Properties.Resources.approve;
            this.btn_main_attendance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_main_attendance.Location = new System.Drawing.Point(574, 338);
            this.btn_main_attendance.Name = "btn_main_attendance";
            this.btn_main_attendance.Size = new System.Drawing.Size(450, 220);
            this.btn_main_attendance.TabIndex = 0;
            this.btn_main_attendance.Text = "Báo cáo điểm danh";
            this.btn_main_attendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_main_attendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_main_attendance.UseVisualStyleBackColor = true;
            this.btn_main_attendance.Click += new System.EventHandler(this.btn_main_attendance_Click);
            // 
            // frm_UC_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_main_attendance);
            this.Controls.Add(this.btn_main_department);
            this.Controls.Add(this.btn_main_office);
            this.Controls.Add(this.btn_main_staff);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frm_UC_Main";
            this.Size = new System.Drawing.Size(1082, 623);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_main_staff;
        private System.Windows.Forms.Button btn_main_office;
        private System.Windows.Forms.Button btn_main_department;
        private System.Windows.Forms.Button btn_main_attendance;
    }
}
