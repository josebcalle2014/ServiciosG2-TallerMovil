using Microsoft.EntityFrameworkCore;
using ServiciosClinicaUNMSM.Modelos;

namespace ServiciosClinicaUNMSM.Datos
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Noticias> Noticias { get; set;} 

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(

                new Usuario()
                {
                    id_usuario = 1,
                    nombre = "Jose Bryan",
                    apellidoPaterno = "Calle",
                    apellidoMaterno = "Soraluz",
                    correo = "jose.callesoraluz@unmsm.edu.pe",
                    contrasenia = "12345",
                    fechaCreacion = DateTime.Now,
                    fechaActualizacion = DateTime.Now,
                    imagen = "",
                    estado=1
                });
        }*/
    }
}
