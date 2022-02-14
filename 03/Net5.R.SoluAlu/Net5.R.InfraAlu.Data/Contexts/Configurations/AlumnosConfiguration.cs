using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5.R.InfraAlu.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.R.InfraAlu.Data.Contexts.Configurations
{
    public partial class AlumnosConfiguration : IEntityTypeConfiguration<Alumnos>
    {
        public void Configure(EntityTypeBuilder<Alumnos> entity)
        {
            entity.ToTable("Alumnos");

            entity.Property(e => e.AlumnosId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Specialty)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Alumnos> entity);
    }
}
