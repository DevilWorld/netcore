using System;
using School.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Infrastructure.Data.Mapping
{
    class StudentClassConfiguration:IEntityTypeConfiguration<StudentClass>
    {
        public void Configure(EntityTypeBuilder<StudentClass> typeBuilder)
        {
            typeBuilder.ToTable("tblStudentClasses");

            typeBuilder.HasKey(pk => new { pk.StudentId, pk.ClassId });

            typeBuilder.Property(p => p.StudentClassId).HasColumnName("StudentClassId").UseSqlServerIdentityColumn();
            
            typeBuilder.Property(p => p.FromDate).HasColumnName("FromDate");
            typeBuilder.Property(p => p.ToDate).HasColumnName("ToDate");

            // HasRequired(a => a.Student)
            //     .WithMany(sc => sc.StudentClasses)
            //     .HasForeignKey(t => t.StudentId);

            // HasRequired(c => c.Class)
            //     .WithMany(sc => sc.StudentClasses)
            //     .HasForeignKey(fk => fk.ClassId);

        }
    }
}
