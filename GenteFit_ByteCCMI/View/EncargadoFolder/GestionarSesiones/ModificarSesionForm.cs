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

namespace GenteFit_ByteCCMI.View.EncargadoFolder.GestionarSesiones
{
    public partial class ModificarSesionForm : Form
    {
        private ActividadProgramada actividadProgramada;
        private AppDbContext context = new AppDbContext();
        public ModificarSesionForm(ActividadProgramada sesionSeleccionada)
        {
            InitializeComponent();
            actividadProgramada = sesionSeleccionada;

            CargarCombos();
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {

                var sesionDb = context.ActividadesProgramadas.Find(actividadProgramada.Id);
                if (sesionDb != null)
                {
                    sesionDb.ActividadTipoId = (int)tipoActividadCombo.SelectedValue;
                    sesionDb.MonitorId = (int)monitorCombo.SelectedValue;
                    sesionDb.SalaId = (int)salaCombo.SelectedValue;
                    sesionDb.HoraInicio = horaInicioPicker.Value;
                    sesionDb.HoraFin = horaFinPicker.Value;
                    context.SaveChanges();
                    MessageBox.Show("Sesión modificada correctamente.");
                }

            }

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();

            GestionarSesionesForm gestionarForm = new GestionarSesionesForm();
            gestionarForm.ShowDialog();
            this.Close();
        }

        private void CargarCombos()
        {
            // Tipos de actividad
            var tipos = context.ActividadTipos.ToList();
            tipoActividadCombo.DataSource = tipos;
            tipoActividadCombo.DisplayMember = "Nombre";
            tipoActividadCombo.ValueMember = "Id";

            // Monitores
            var monitores = context.Monitores.ToList();
            monitorCombo.DataSource = monitores;
            monitorCombo.DisplayMember = "Nombre";   // O la propiedad que tengas
            monitorCombo.ValueMember = "Id";

            // Salas
            var salas = context.Salas.ToList();
            salaCombo.DataSource = salas;
            salaCombo.DisplayMember = "Nombre";
            salaCombo.ValueMember = "Id";
        }

        private void ModificarSesionForm_Load(object sender, EventArgs e)
        {
            horaInicioPicker.Format = DateTimePickerFormat.Custom;
            horaInicioPicker.CustomFormat = "dd/MM/yyyy HH:mm";   // Día/Mes/Año + Hora:Minuto
            horaInicioPicker.ShowUpDown = false;                   // Necesario para mostrar el calendario

            horaFinPicker.Format = DateTimePickerFormat.Custom;
            horaFinPicker.CustomFormat = "dd/MM/yyyy HH:mm";
            horaFinPicker.ShowUpDown = false;
        }
    }
}
