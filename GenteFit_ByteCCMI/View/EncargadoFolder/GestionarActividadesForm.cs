using GenteFit_ByteCCMI.View.EncargadoFolder.GestionarActividades;
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
    public partial class GestionarActividadesForm : Form
    {
        public GestionarActividadesForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearActividadesForm crearActividadForm = new CrearActividadesForm();
            crearActividadForm.ShowDialog();
            this.Close();

        }
    }
}
