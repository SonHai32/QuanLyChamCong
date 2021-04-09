using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QL_Cham_Cong;
namespace GUI
{
    public partial class frm_UC_Main : UserControl
    {
        private frm_Main_form mainForm;
        public frm_UC_Main(frm_Main_form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void btn_main_staff_Click(object sender, EventArgs e)
        {
            this.mainForm.loadUDForm(new frm_UC_Staff());
        }

        private void btn_main_office_Click(object sender, EventArgs e)
        {
            this.mainForm.loadUDForm(new frm_UC_Office());
        }

        private void btn_main_department_Click(object sender, EventArgs e)
        {
            this.mainForm.loadUDForm(new frm_UC_Department());
        }

        private void btn_main_attendance_Click(object sender, EventArgs e)
        {
            this.mainForm.loadUDForm(new frm_UC_Attendance());
        }
    }
}
