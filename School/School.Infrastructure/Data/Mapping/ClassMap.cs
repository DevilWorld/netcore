using School.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class ClassMap : EntityTypeConfiguration<Class>
    {
        public ClassMap()
        {
            ToTable("tblClass");

            HasKey<int>(pk => pk.ClassId);

            Property(p => p.ClassId).HasColumnName("ClassId").HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.ClassName).HasColumnName("ClassName").HasColumnType("varchar");
            Property(p => p.TeacherFromDate).HasColumnName("TeacherFromDate").HasColumnType("datetime");
            Property(p => p.TeacherToDate).HasColumnName("TeacherToDate").HasColumnType("datetime");

            //Relationships
            HasRequired(t => t.Teacher)
                .WithMany(c => c.Class)
                .HasForeignKey(m => m.TeacherId);

            HasRequired(s => s.Subject)
                .WithMany(c => c.Class)
                .HasForeignKey(fk => fk.SubjectId);
        }
    }
}
