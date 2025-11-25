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
    public partial class CrearSesionForm : Form
    {
        private AppDbContext context = new AppDbContext();
        public CrearSesionForm()
        {
            InitializeComponent();
        }

        private void CrearSesionForm_Load(object sender, EventArgs e)
        {
            horaInicioPicker.Format = DateTimePickerFormat.Custom;
            horaInicioPicker.CustomFormat = "dd/MM/yyyy HH:mm";   // Día/Mes/Año + Hora:Minuto
            horaInicioPicker.ShowUpDown = false;                   // Necesario para mostrar el calendario

            horaFinPicker.Format = DateTimePickerFormat.Custom;
            horaFinPicker.CustomFormat = "dd/MM/yyyy HH:mm";
            horaFinPicker.ShowUpDown = false;

            tipoActividadCombo.DataSource = context.ActividadTipos
            .OrderBy(t => t.Nombre)
            .ToList();

            tipoActividadCombo.DisplayMember = "Nombre";
            tipoActividadCombo.ValueMember = "Id";

            // 2. Cargar monitores
            monitorCombo.DataSource = context.Monitores
                .Where(m => m.Activo)
                .OrderBy(m => m.Nombre)
                .ToList();

            monitorCombo.DisplayMember = "Nombre";
            monitorCombo.ValueMember = "Id";
            // 3. Cargar salas
            salaCombo.DataSource = context.Salas
                .OrderBy(s => s.Nombre)
                .ToList();

            salaCombo.DisplayMember = "Nombre";
            salaCombo.ValueMember = "Id";
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            if (tipoActividadCombo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de actividad.");
                return;
            }
            if (monitorCombo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un monitor.");
                return;
            }
            if (salaCombo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una sala.");
                return;
            }
            if (horaFinPicker.Value <= horaInicioPicker.Value)
            {
                MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio.");
                return;
            }

            // Crear nueva sesión
            var nuevaSesion = new ActividadProgramada
            {
                ActividadTipoId = (int)tipoActividadCombo.SelectedValue,
                MonitorId = (int)monitorCombo.SelectedValue,
                SalaId = (int)salaCombo.SelectedValue,
                HoraInicio = horaInicioPicker.Value,
                HoraFin = horaFinPicker.Value
            };
            context.ActividadesProgramadas.Add(nuevaSesion);
            context.SaveChanges();
            MessageBox.Show("Sesión creada con éxito.");
            this.DialogResult = DialogResult.OK;
            this.Hide();

            GestionarSesionesForm gestionarForm = new GestionarSesionesForm();
            gestionarForm.ShowDialog();
            this.Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            GestionarSesionesForm gestionarForm = new GestionarSesionesForm();
            gestionarForm.ShowDialog();
            this.Close();
        }
    }
}
