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
    public partial class courseConfiguration : IEntityTypeConfiguration<course>
    {
        public void Configure(EntityTypeBuilder<course> entity)
        {
            entity.ToTable("course");

            entity.Property(e => e.courseId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.courseName)
                .IsRequired()
                .HasMaxLength(80)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(e => e.Alumnos)
                .WithMany(p => p.Courses)
                .HasForeignKey(d => d.AlumnosId)
                .HasConstraintName("FK_courseAlumnos");


        OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<course> entity);
    }
}
