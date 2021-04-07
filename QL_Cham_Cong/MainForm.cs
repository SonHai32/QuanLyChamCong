using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;
namespace QL_Cham_Cong
{

    public partial class MainForm : Form
    {


        private UserControl currentUC;
        public MainForm()
        {
            InitializeComponent();
            Theme customTheme = new Theme();
            this.BackColor = customTheme.BACKGROUND;
            frm_UC_Main ucMain = new frm_UC_Main();
            frm_UC_Staff ucStaff = new frm_UC_Staff();
            this.currentUC = ucStaff;
            this.currentUC.Size = this.pn_main.Size;
            this.pn_main.Controls.Add(this.currentUC);
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.theme_load();
        }

        private void theme_load()
        {
            Theme myTheme = new Theme();
            var allButton = GetAll(this, typeof(Button));
            var allPane = GetAll(this, typeof(Panel));
            foreach(Button btn in allButton)
            {
                btn.BackColor = myTheme.BUTTON;
                btn.ForeColor = myTheme.BUTTON_TEXT;
            }
            foreach(Panel panel in allPane)
            {
                if (panel.Name.ToLower().Contains("main_header"))
                {
                    panel.BackColor = myTheme.BUTTON;
                    panel.ForeColor = myTheme.BUTTON_TEXT;
                }
                else
                {

                    panel.BackColor = myTheme.BACKGROUND;
                    panel.ForeColor = myTheme.BUTTON;
                }


            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.currentUC.Size = this.pn_main.Size;
        }
    }
}
