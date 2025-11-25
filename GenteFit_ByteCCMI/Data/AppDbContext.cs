using Microsoft.EntityFrameworkCore;


namespace EstructuraBBDD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Encargado> Encargados { get; set; }
        public DbSet<Monitor> Monitores { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }

        public DbSet<Sala> Salas { get; set; }
        public DbSet<ActividadTipo> ActividadTipos { get; set; }
        public DbSet<ActividadProgramada> ActividadesProgramadas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }


        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=GenteFitBBDD;Trusted_Connection=True;";


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(connectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ---- 1️⃣ Herencia TPH para usuarios ----
            modelBuilder.Entity<Usuario>()
                .HasDiscriminator<string>("TipoUsuario")
                .HasValue<Administrador>("Administrador")
                .HasValue<Cliente>("Cliente")
                .HasValue<Encargado>("Encargado")
                .HasValue<Monitor>("Monitor")
                .HasValue<Recepcionista>("Recepcionista");

            // ActividadTipo -> ActividadProgramada
            modelBuilder.Entity<ActividadProgramada>()
                .HasOne(ap => ap.ActividadTipo)
                .WithMany(at => at.ActividadesProgramadas)
                .HasForeignKey(ap => ap.ActividadTipoId)
                .OnDelete(DeleteBehavior.Restrict);

            // Monitor -> ActividadProgramada
            modelBuilder.Entity<ActividadProgramada>()
                .HasOne(ap => ap.Monitor)
                .WithMany(m => m.Actividades)
                .HasForeignKey(ap => ap.MonitorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Sala -> ActividadProgramada
            modelBuilder.Entity<ActividadProgramada>()
                .HasOne(ap => ap.Sala)
                .WithMany()
                .HasForeignKey(ap => ap.SalaId)
                .OnDelete(DeleteBehavior.Restrict);

            // Cliente -> Reserva
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Cliente)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            // ActividadProgramada -> Reserva
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.ActividadProgramada)
                .WithMany(ap => ap.Reservas)
                .HasForeignKey(r => r.ActividadProgramadaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
