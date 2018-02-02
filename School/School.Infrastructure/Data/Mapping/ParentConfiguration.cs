using School.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Infrastructure.Data.Mapping
{
    class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> typeBuilder)
        {
            typeBuilder.ToTable("tblParents");

            //Primary Key configuration
            typeBuilder.HasKey(p => p.ParentId);

            //Property-column mapping
            typeBuilder.Property(p => p.ParentId).HasColumnName("ParentId");
            typeBuilder.Property(p => p.FirstName).HasColumnName("FirstName");
            typeBuilder.Property(p => p.MiddleName).HasColumnName("MiddleName");
            typeBuilder.Property(p => p.LastName).HasColumnName("LastName");
            typeBuilder.Property(p => p.Gender).HasColumnName("Gender");
            typeBuilder.Property(p => p.DOB).HasColumnName("DOB");

            //Many-to-Many relationship for the parents with addresses
            // typeBuilder.HasMany(a => a.Addresses)
            //     .WithMany(p => p.Parents)
            //     .Map(t => t.ToTable("tblParentAddresses")
            //         .MapLeftKey("ParentId")
            //         .MapRightKey("AddressId")
            //     );

            // //Many-to-Many relationship for the parents with Students
            // HasMany(s => s.Students)
            //     .WithMany(p => p.Parents)
            //     .Map(t => t.ToTable("tblStudentParents")
            //         .MapLeftKey("StudentId")
            //         .MapRightKey("ParentId")
            //     );
        }
    }
}
