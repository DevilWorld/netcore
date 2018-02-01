using SchoolPortal.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable("tblStudents");
            HasKey(k => k.StudentId);
            Property(p => p.StudentId).HasColumnName("StudentId").HasColumnType("int").IsRequired();
            Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
            Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar");
            Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
            Property(p => p.Sex).HasColumnName("Gender").HasColumnType("varchar");
            Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime2");

            //Many-to-Many relationship for the student with addresses
            HasMany(a => a.Addresses)
                .WithMany(s => s.Students)
                .Map(t => t.ToTable("tblStudentAddresses")
                .MapLeftKey("StudentId")
                .MapRightKey("AddressId")
                );

            //Many-to-Many relationship for the parents with Students
            HasMany(p => p.Parents)
                .WithMany(s => s.Students)
                .Map(t => t.ToTable("tblStudentParents")
                    .MapLeftKey("StudentId")
                    .MapRightKey("ParentId")
                );
        }
    }
}
