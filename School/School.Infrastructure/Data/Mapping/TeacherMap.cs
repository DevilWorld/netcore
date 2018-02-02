using School.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class TeacherMap : EntityTypeConfiguration<Teacher>
    {
        public TeacherMap()
        {
            //Table configuration
            ToTable("tblTeacher");

            //Primary Key
            HasKey(pk => pk.TeacherId);

            //Property to column mapping
            Property(p => p.TeacherId).HasColumnName("TeacherId").HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
            Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
            Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar");
            Property(p => p.Gender).HasColumnName("Gender").HasColumnType("varchar");
            Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime");

            //Relationships                 1 to 0 or 1
            HasRequired(a => a.TeacherAddress)
                .WithOptional(t => t.Teachers)
                .Map(m => m.MapKey("AddressId"));

            HasRequired(s => s.School)
                .WithMany(t => t.Teachers)
                .HasForeignKey(fk => fk.SchoolId);
        }
    }
}
