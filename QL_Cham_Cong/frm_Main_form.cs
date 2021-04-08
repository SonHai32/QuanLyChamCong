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

    public partial class frm_Main_form : Form
    {


        private UserControl currentUC;
        public frm_Main_form()
        {
            InitializeComponent();
            Theme customTheme = new Theme();
            this.BackColor = customTheme.BACKGROUND;
            this.loadUDForm(new frm_UC_Main(this));
            this.theme_load(); 
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        public void loadUDForm(UserControl uc)
        {
            
            this.pn_main.Controls.Remove(this.currentUC);
            this.currentUC = uc;
            this.currentUC.Size = this.pn_main.Size;
            this.pn_main.Controls.Add(this.currentUC);
            theme_load();
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
