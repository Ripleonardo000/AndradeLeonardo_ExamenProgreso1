using AndradeLeonardo_ExamenProgreso1.Models;
using Microsoft.EntityFrameworkCore;

namespace AndradeLeonardo_ExamenProgreso1.DatosLeonardoAndrade
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        //AQUI VOY A PONER LOS MODELOS QUE CORRESPONDEN A UNA TABLA DE DATOS

        public DbSet<Tabla> Tablas { get; set; }
    }

    

    
}
