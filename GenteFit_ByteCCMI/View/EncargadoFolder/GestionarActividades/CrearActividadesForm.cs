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

        private void CrearActividadesForm_Load(object sender, EventArgs e)
        {
            comboMonitor.DataSource = context.Monitores.ToList();
            comboMonitor.DisplayMember = "Nombre"; // muestra Nombre en el ComboBox
            comboMonitor.ValueMember = "Id";

            // Llenar ComboBox de Salas
            comboSala.DataSource = context.Salas.ToList();
            comboSala.DisplayMember = "Nombre";
            comboSala.ValueMember = "Id";

        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            if (comboMonitor.SelectedItem == null || comboSala.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un monitor y una sala");
                return;
            }

            // Crear nueva actividad
            var actividad = new Actividad
            {
                Nombre = nombreTextBox.Text,
                Descripcion = descripcionTextBox.Text,
                HoraInicio = horaInicioDatetime.Value,
                HoraFin = horaFinDatetime.Value,
                Monitor = (Monitor)comboMonitor.SelectedItem,
                Sala = (Sala)comboSala.SelectedItem
            };

            context.Actividades.Add(actividad);
            context.SaveChanges();

            MessageBox.Show("Actividad creada correctamente");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
