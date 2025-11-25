using EstructuraBBDD.Data;
using GenteFit_ByteCCMI.View;

namespace GenteFit_ByteCCMI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var context = new AppDbContext())
            {
                //context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                if (!context.Usuarios.Any())
                {
                    context.Administradores.Add(new Administrador { Nombre = "admin", Apellidos = "admin", Activo = true, Email = "admin@admin.com", Telefono = "123456789", Password="1234" });
                    context.Clientes.Add(new Cliente { Nombre = "cliente", Apellidos = "cliente", Activo = true, Email = "cliente@cliente.com", Telefono = "987654321", Password="1234", FechaCreacion=DateTime.Now });
                    context.Clientes.Add(new Cliente { Nombre = "cliente2", Apellidos = "cliente", Activo = true, Email = "cliente2@cliente.com", Telefono = "987654321", Password = "1234", FechaCreacion = DateTime.Now });
                    context.Clientes.Add(new Cliente { Nombre = "cliente3", Apellidos = "cliente", Activo = true, Email = "cliente3@cliente.com", Telefono = "987654321", Password = "1234", FechaCreacion = DateTime.Now });
                    context.Clientes.Add(new Cliente { Nombre = "cliente4", Apellidos = "cliente", Activo = true, Email = "cliente4@cliente.com", Telefono = "987654321", Password = "1234", FechaCreacion = DateTime.Now });

                    context.Encargados.Add(new Encargado { Nombre = "encargado", Apellidos = "encargado", Activo = true, Email = "e", Telefono = "555555555", Password="1234" });
                    context.Monitores.Add(new Monitor { Nombre = "monitor", Apellidos = "monitor", Activo = true, Email = "monitor@monitor.com", Telefono = "444444444", Password="1234" });
                    context.Monitores.Add(new Monitor { Nombre = "monitor2", Apellidos = "monitor", Activo = true, Email = "monitor2@monitor.com", Telefono = "444444444", Password = "1234" });
                    context.Monitores.Add(new Monitor { Nombre = "monitor3", Apellidos = "monitor", Activo = true, Email = "monitor3@monitor.com", Telefono = "444444444", Password = "1234" });
                    context.Monitores.Add(new Monitor { Nombre = "monitor4", Apellidos = "monitor", Activo = true, Email = "monitor4@monitor.com", Telefono = "444444444", Password = "1234" });
                    context.Recepcionistas.Add(new Recepcionista { Nombre = "recepcionista", Apellidos = "recepcionista", Activo = true, Email = "recepcionista@recepcionista.com@", Telefono = "333333333", Password="1234" });
                    context.Salas.Add(new Sala("Sala A", 16));
                    context.SaveChanges();
                }
                
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}