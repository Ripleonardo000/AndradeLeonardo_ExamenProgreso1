using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AndradeLeonardo_ExamenProgreso1.Models;

namespace AndradeLeonardo_ExamenProgreso1.Data
{
    public class AndradeLeonardo_ExamenProgreso1Context : DbContext
    {
        public AndradeLeonardo_ExamenProgreso1Context (DbContextOptions<AndradeLeonardo_ExamenProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<AndradeLeonardo_ExamenProgreso1.Models.Datoss> datosses { get; set; } = default!;
    }
}
