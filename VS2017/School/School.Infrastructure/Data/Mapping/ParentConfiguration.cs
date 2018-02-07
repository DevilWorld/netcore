using School.Domain.Models;
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
            typeBuilder.Property(p => p.ParentId).HasColumnName("ParentId").HasColumnType("int");
            typeBuilder.Property(p => p.AddressId).HasColumnName("AddressId").HasColumnType("int");
            typeBuilder.Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar(30)").HasMaxLength(30);
            typeBuilder.Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar(30)").HasMaxLength(30);
            typeBuilder.Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar(30)").HasMaxLength(30);
            typeBuilder.Property(p => p.Gender).HasColumnName("Gender").HasColumnType("char(2)").HasMaxLength(1);
            typeBuilder.Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime");

            //One-to-One relationship for parent with Address   
            typeBuilder.HasOne(x => x.Address)                                 //Address --> Principal Entity      Parent --> Dependent Entity
                .WithOne(x => x.Parent)
                .HasForeignKey<Parent>(fk => fk.AddressId);

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
