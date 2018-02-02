using System;
using School.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class StudentClassMap:EntityTypeConfiguration<StudentClass>
    {
        public StudentClassMap()
        {
            ToTable("tblStudentClasses");

            HasKey(pk => new { pk.StudentId, pk.ClassId });

            Property(p => p.StudentClassId).HasColumnName("StudentClassId").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            Property(p => p.FromDate).HasColumnName("FromDate");
            Property(p => p.ToDate).HasColumnName("ToDate");

            HasRequired(a => a.Student)
                .WithMany(sc => sc.StudentClasses)
                .HasForeignKey(t => t.StudentId);

            HasRequired(c => c.Class)
                .WithMany(sc => sc.StudentClasses)
                .HasForeignKey(fk => fk.ClassId);

        }
    }
}
