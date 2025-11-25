using EstructuraBBDD.Data;
using GenteFit_ByteCCMI.View.EncargadoFolder.GestionarActividades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenteFit_ByteCCMI.View.EncargadoFolder.GestionarSesiones
{
    public partial class GestionarSesionesForm : Form
    {
        private readonly AppDbContext context = new AppDbContext();

        public GestionarSesionesForm()
        {
            InitializeComponent();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearSesionForm crearSesionForm = new CrearSesionForm();
            crearSesionForm.ShowDialog();
            this.Close();

        }

        private void sesionesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sesionSeleccionada = sesionesListBox.SelectedItem as ActividadProgramada;
            if (sesionSeleccionada != null)
            {

                // Habilitar botones si quieres
                modificarButton.Enabled = true;
                eliminarButton.Enabled = true;
                consultarButton.Enabled = true;
            }
            else
            {
                // Si nada seleccionado, limpiar o deshabilitar botones
                modificarButton.Enabled = false;
                eliminarButton.Enabled = false;
                consultarButton.Enabled = false;
            }
        }
        private void CargarActividades()
        {
            // Traemos todas las actividades, incluyendo Monitor y Sala
            var actividades = context.ActividadesProgramadas
                .Include(a => a.ActividadTipo)
                .Include(a => a.Monitor)
                .Include(a => a.Sala)
                .ToList();

            // Asignamos la lista al ListBox
            sesionesListBox.DataSource = actividades;
            sesionesListBox.DisplayMember = "NombreCompleto";  // solo se muestra el nombre
            sesionesListBox.ValueMember = "Id";        // opcional, para obtener el Id directamente
        }

        private void GestionarSesionesForm_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            var sesionSeleccionada = sesionesListBox.SelectedItem as ActividadProgramada;

            if (sesionSeleccionada == null)
            {
                MessageBox.Show("Selecciona una sesión primero.");
                return;
            }

            // Abrir el formulario de modificación pasando la actividad
            this.Hide();
            ModificarSesionForm modificarForm = new ModificarSesionForm(sesionSeleccionada);
            modificarForm.ShowDialog();
            this.Show();

            // Opcional: recargar la lista después de modificar
            CargarActividades();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (sesionesListBox.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una actividad para eliminar.");
                return;
            }

            // Recuperar la entidad seleccionada
            var sesionSeleccionada = (ActividadProgramada)sesionesListBox.SelectedItem;

            // Confirmación
            var confirm = MessageBox.Show(
                $"¿Seguro que desea eliminar la actividad '{sesionSeleccionada.ActividadTipo.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
                return;

            // Eliminar de la base de datos
            context.ActividadesProgramadas.Remove(sesionSeleccionada);
            context.SaveChanges();

            // Refrescar la lista
            sesionesListBox.DataSource = context.ActividadesProgramadas.ToList();

            MessageBox.Show("Actividad eliminada correctamente.");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PanelEncargadoForm panelEncargadoForm = new PanelEncargadoForm();
            panelEncargadoForm.ShowDialog();
            this.Close();
        }
    }
}
