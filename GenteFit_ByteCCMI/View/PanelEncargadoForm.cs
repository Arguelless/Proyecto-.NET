using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFit_ByteCCMI.View
{
    public partial class PanelEncargadoForm : Form
    {
        public PanelEncargadoForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            this.Close();
        }

        private void gestionarActividadesButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            GestionarActividadesForm f = new GestionarActividadesForm();
            f.ShowDialog();

            this.Close();
        }
    }
}
