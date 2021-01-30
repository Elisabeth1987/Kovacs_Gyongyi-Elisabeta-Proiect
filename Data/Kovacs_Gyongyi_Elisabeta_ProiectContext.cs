using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kovacs_Gyongyi_Elisabeta_Proiect.Models;

namespace Kovacs_Gyongyi_Elisabeta_Proiect.Data
{
    public class Kovacs_Gyongyi_Elisabeta_ProiectContext : DbContext
    {
        public Kovacs_Gyongyi_Elisabeta_ProiectContext (DbContextOptions<Kovacs_Gyongyi_Elisabeta_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Kovacs_Gyongyi_Elisabeta_Proiect.Models.Student> Student { get; set; }

        public DbSet<Kovacs_Gyongyi_Elisabeta_Proiect.Models.Specializare> Specializare { get; set; }

        public DbSet<Kovacs_Gyongyi_Elisabeta_Proiect.Models.Ciclu> Ciclu { get; set; }
    }
}
