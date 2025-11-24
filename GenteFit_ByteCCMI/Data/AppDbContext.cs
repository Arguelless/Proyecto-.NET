using Microsoft.EntityFrameworkCore;


namespace EstructuraBBDD.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Encargado> Encargados { get; set; }
        public DbSet<Monitor> Monitores { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Sala> Salas { get; set; }


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

            // ---- 2️⃣ Relaciones con restricción para evitar múltiples cascadas ----
            // Actividad -> Monitor
            modelBuilder.Entity<Actividad>()
                .HasOne(a => a.Monitor)
                .WithMany(m => m.Actividades)
                .HasForeignKey(a => a.Id)
                .OnDelete(DeleteBehavior.Restrict); // evita ciclo

            // Reserva -> Cliente
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Cliente)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.Id)
                .OnDelete(DeleteBehavior.Restrict); // evita cascada múltiple

            // Si hay otras FK con Usuario, usa DeleteBehavior.Restrict o NoAction
        }
    }

}
