using System.Data.Entity.ModelConfiguration;
using SchoolPortal.Domain.Model;
using System.Data.Entity;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class ParentMap : EntityTypeConfiguration<Parent>
    {
        public ParentMap()
        {
            ToTable("tblParents");

            //Primary Key configuration
            HasKey(p => p.ParentId);

            //Property-column mapping
            Property(p => p.ParentId).HasColumnName("ParentId");
            Property(p => p.FirstName).HasColumnName("FirstName");
            Property(p => p.MiddleName).HasColumnName("MiddleName");
            Property(p => p.LastName).HasColumnName("LastName");
            Property(p => p.Gender).HasColumnName("Gender");
            Property(p => p.DOB).HasColumnName("DOB");

            //Many-to-Many relationship for the parents with addresses
            HasMany(a => a.Addresses)
                .WithMany(p => p.Parents)
                .Map(t => t.ToTable("tblParentAddresses")
                    .MapLeftKey("ParentId")
                    .MapRightKey("AddressId")
                );

            //Many-to-Many relationship for the parents with Students
            HasMany(s => s.Students)
                .WithMany(p => p.Parents)
                .Map(t => t.ToTable("tblStudentParents")
                    .MapLeftKey("StudentId")
                    .MapRightKey("ParentId")
                );
        }
    }
}
