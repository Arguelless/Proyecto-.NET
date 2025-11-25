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
    public partial class EstadoReservasForm : Form
    {
        private readonly AppDbContext context = new AppDbContext();


        public EstadoReservasForm()
        {
            InitializeComponent();
        }

        private void EstadoReservasForm_Load(object sender, EventArgs e)
        {
            var actividades = context.ActividadesProgramadas
                .Include(a => a.ActividadTipo)
                .ToList();

            sesionesListBox.DataSource = actividades;
            sesionesListBox.DisplayMember = "NombreCompleto"; // muestra el nombre de la plantilla
            sesionesListBox.ValueMember = "Id";

            sesionesListBox.SelectedIndexChanged += sesionesListBox_SelectedIndexChanged;

        }

        private void sesionesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var actividadSeleccionada = sesionesListBox.SelectedItem as ActividadProgramada;
            if (actividadSeleccionada == null) return;

            using (var context = new AppDbContext())
            {
                // Recargar actividad con reservas y clientes
                var actividadDb = context.ActividadesProgramadas
                    .Include(a => a.Reservas)
                        .ThenInclude(r => r.Cliente)
                    .FirstOrDefault(a => a.Id == actividadSeleccionada.Id);

                // Clientes confirmados (EstadoReserva == Confirmado)
                var clientesReservados = actividadDb.Reservas
                    .Where(r => r.EstadoReserva == EstadoReserva.Confirmada)
                    .Select(r => r.Cliente)
                    .ToList();

                // Clientes en espera (EstadoReserva == Espera)
                var clientesEspera = actividadDb.Reservas
                    .Where(r => r.EstadoReserva == EstadoReserva.Espera)
                    .Select(r => r.Cliente)
                    .ToList();

                // Llenar los ListBox
                clientesReservaListBox.DataSource = clientesReservados;
                clientesReservaListBox.DisplayMember = "Nombre"; // o Nombre + Apellidos
                clientesReservaListBox.ValueMember = "Id";

                listaEsperaListbox.DataSource = clientesEspera;
                listaEsperaListbox.DisplayMember = "Nombre";
                listaEsperaListbox.ValueMember = "Id";
            }
        }

        private void clientesReservaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
