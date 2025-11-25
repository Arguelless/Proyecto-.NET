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
    public partial class CrearActividadesForm : Form
    {
        private AppDbContext context;

        public CrearActividadesForm()
        {
            InitializeComponent();
            context = new AppDbContext();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            // Crear nueva actividad
            var actividad = new ActividadTipo
            {
                Nombre = nombreTextBox.Text,
                Descripcion = descripcionTextBox.Text,
                DuracionMinutos = (int)duracionSpinner.Value,
            };

            context.ActividadTipos.Add(actividad);
            context.SaveChanges();

            MessageBox.Show("Actividad creada correctamente");
            this.DialogResult = DialogResult.OK;
            this.Hide();

            GestionarActividadesForm gestionarForm = new GestionarActividadesForm();
            gestionarForm.ShowDialog();
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

        private void CrearActividadesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
