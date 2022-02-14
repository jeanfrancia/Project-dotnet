using Microsoft.EntityFrameworkCore;
using Net5.R.InfraAlu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.R.InfraAlu.Data.Contexts
{
    public partial class LibraryContext:DbContext

    {
        public LibraryContext()
        {

        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options) 
        {
            Database.Migrate();
        }

        public virtual DbSet<Alumnos> Alumnos { get; set; } 
        public virtual DbSet<course> course  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collection", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.ApplyConfiguration(new Configurations.AlumnosConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.courseConfiguration());
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
