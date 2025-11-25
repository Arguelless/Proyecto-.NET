using EstructuraBBDD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFit_ByteCCMI.View.EncargadoFolder.GestionarActividades
{
    public partial class ModificarActividadesForm : Form
    {
        private ActividadTipo actividad;

        public ModificarActividadesForm(ActividadTipo actividadSeleccionada)
        {
            InitializeComponent();
            actividad = actividadSeleccionada;

            // Cargar los datos en los controles
            nombreTextBox.Text = actividad.Nombre;
            descripcionTextBox.Text = actividad.Descripcion;
            duracionSpinner.Value = actividad.DuracionMinutos;


        }

        private void ModificarActividadesForm_Load(object sender, EventArgs e)
        {

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var actividadDb = context.ActividadTipos.Find(actividad.Id);
                if (actividadDb != null)
                {
                    actividadDb.Nombre = nombreTextBox.Text;
                    actividadDb.Descripcion = descripcionTextBox.Text;
                    actividadDb.DuracionMinutos = (int)duracionSpinner.Value;


                    context.SaveChanges();
                    MessageBox.Show("Actividad modificada correctamente.");
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();

            GestionarActividadesForm gestionarForm = new GestionarActividadesForm();
            gestionarForm.ShowDialog();
            this.Close();
        }
    }
}
