using EstructuraBBDD.Data;
using Microsoft.Data.SqlClient;
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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void accederButton_Click(object sender, EventArgs e)
        {
            string usuario = emailTextField.Text.Trim();
            string password = pwdTextField.Text.Trim();

            using (var context = new AppDbContext())
            {
                var user = context.Set<Usuario>()
                    .FirstOrDefault(u => u.Email == usuario && u.Password == password);

                if (user != null)
                {
                    // Login correcto

                    // 1️⃣ Ocultar el LoginForm
                    this.Hide();

                    if (user is Administrador)
                    {
                        //TODO: Crear PanelAdministradorForm
                        PanelClienteForm panelCliente = new PanelClienteForm();
                        panelCliente.ShowDialog();
                    }
                    else if (user is Cliente)
                    {
                        PanelClienteForm panelCliente = new PanelClienteForm();
                        panelCliente.ShowDialog();
                    }
                    else if (user is Monitor)
                    {
                        PanelMonitorForm panelMonitor = new PanelMonitorForm();
                        panelMonitor.ShowDialog();
                    }
                    else if (user is Encargado)
                    {
                        PanelEncargadoForm panelEncargado = new PanelEncargadoForm();
                        panelEncargado.ShowDialog();
                    }
                    else if (user is Recepcionista)
                    {
                        PanelRecepcionistaForm panelRecepcionista = new PanelRecepcionistaForm();
                        panelRecepcionista.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login incorrecto");
                }
            }
        }

    }
}
