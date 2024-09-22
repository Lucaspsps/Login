using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormMenu : Form
    {
        private Form activeForm;
        public FormMenu()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            PICBOX_HOME.Visible = false;
            childForm.MdiParent = this;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
            childForm.FormClosed += ChildForm_FormClosed;

        }

        private void BTN_Cadastrar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCadastro(), sender);
        }

        private void BTN_Consultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConsultar(), sender);
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            lblTitle.Text = "HOME";
            activeForm = null;
            PICBOX_HOME.Visible = true;
        }

    }
}
