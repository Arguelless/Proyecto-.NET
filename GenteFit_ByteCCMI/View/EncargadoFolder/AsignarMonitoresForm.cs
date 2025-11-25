using EstructuraBBDD.Data;
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

namespace GenteFit_ByteCCMI.View.EncargadoFolder
{
    public partial class AsignarMonitoresForm : Form
    {
        public AsignarMonitoresForm()
        {
            InitializeComponent();
        }

        private void AsignarMonitoresForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var monitores = context.Monitores.ToList();
                lstMonitores.DataSource = monitores;
                lstMonitores.DisplayMember = "Nombre"; // o Nombre + Apellidos
                lstMonitores.ValueMember = "Id";
            }

            lstMonitores.SelectedIndexChanged += lstMonitores_SelectedIndexChanged;
        }

        private void lstMonitores_SelectedIndexChanged(object sender, EventArgs e)
        {
            var monitorSeleccionado = lstMonitores.SelectedItem as Monitor;
            if (monitorSeleccionado == null) return;

            using (var context = new AppDbContext())
            {
                // Recargar monitor con sus actividades
                monitorSeleccionado = context.Monitores
                    .Include(m => m.Actividades)                 
                        .ThenInclude(a => a.ActividadTipo)      
                    .FirstOrDefault(m => m.Id == monitorSeleccionado.Id);

                var actividadesNoAsignadas = context.ActividadesProgramadas
                    .Include(a => a.Sala)
                    .Include(a => a.ActividadTipo) // si quieres mostrar el nombre
                    .Where(a => a.MonitorId == null) // solo sin monitor
                    .ToList();

                // Actividades asignadas
                var asignadas = monitorSeleccionado.Actividades.ToList();

                // Actividades no asignadas
                var noAsignadas = actividadesNoAsignadas;

                // Llenar los ListBox
                lstAsignadas.DataSource = asignadas;
                lstAsignadas.DisplayMember = "NombreCompleto";
                lstAsignadas.ValueMember = "Id";

                lstNoAsignadas.DataSource = noAsignadas;
                lstNoAsignadas.DisplayMember = "NombreCompleto";
                lstNoAsignadas.ValueMember = "Id";
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            var monitor = lstMonitores.SelectedItem as Monitor;
            var sesion = lstNoAsignadas.SelectedItem as ActividadProgramada;

            if (monitor == null || sesion == null) return;

            using (var context = new AppDbContext())
            {
                var sesionDb = context.ActividadesProgramadas.Find(sesion.Id);
                sesionDb.MonitorId = monitor.Id;
                context.SaveChanges();
            }

            lstMonitores_SelectedIndexChanged(null, null); // recargar listas
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var sesion = lstAsignadas.SelectedItem as ActividadProgramada;
            if (sesion == null) return;

            using (var context = new AppDbContext())
            {
                var sesionDb = context.ActividadesProgramadas.Find(sesion.Id);
                sesionDb.MonitorId = null; // quitar monitor
                context.SaveChanges();
            }

            lstMonitores_SelectedIndexChanged(null, null); // recargar listas
        }

        private void lstAsignadas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstNoAsignadas_SelectedIndexChanged(object sender, EventArgs e)
        {

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
