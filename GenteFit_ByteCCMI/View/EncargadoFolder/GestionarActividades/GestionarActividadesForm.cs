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

namespace GenteFit_ByteCCMI.View
{
    public partial class GestionarActividadesForm : Form
    {
        private readonly AppDbContext context1 = new AppDbContext();

        public GestionarActividadesForm()
        {
            InitializeComponent();
        }



        private void crearButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearActividadesForm crearActividadForm = new CrearActividadesForm();
            crearActividadForm.ShowDialog();
            this.Close();

        }

        private void actividadesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actividadSeleccionada = actividadesList.SelectedItem as ActividadTipo;
            if (actividadSeleccionada != null)
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
            using (var context = new AppDbContext())
            {
                // Traemos todas las actividades, incluyendo Monitor y Sala
                var actividades = context.ActividadTipos.ToList();

                // Asignamos la lista al ListBox
                actividadesList.DataSource = actividades;
                actividadesList.DisplayMember = "Nombre";  // solo se muestra el nombre
                actividadesList.ValueMember = "Id";        // opcional, para obtener el Id directamente
            }
        }

        private void GestionarActividadesForm_Load(object sender, EventArgs e)
        {
            CargarActividades();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            var actividadSeleccionada = actividadesList.SelectedItem as ActividadTipo;

            if (actividadSeleccionada == null)
            {
                MessageBox.Show("Selecciona una actividad primero.");
                return;
            }

            // Abrir el formulario de modificación pasando la actividad
            this.Hide();
            ModificarActividadesForm modificarForm = new ModificarActividadesForm(actividadSeleccionada);
            modificarForm.ShowDialog();
            this.Show();

            // Opcional: recargar la lista después de modificar
            CargarActividades();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            if (actividadesList.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una actividad para eliminar.");
                return;
            }

            // Recuperar la entidad seleccionada
            var actividadSeleccionada = (ActividadTipo)actividadesList.SelectedItem;

            // Confirmación
            var confirm = MessageBox.Show(
                $"¿Seguro que desea eliminar la actividad '{actividadSeleccionada.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
                return;

            // Eliminar de la base de datos
            context1.ActividadTipos.Remove(actividadSeleccionada);
            context1.SaveChanges();

            // Refrescar la lista
            actividadesList.DataSource = context1.ActividadTipos.ToList();

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
