// using School.Domain.Model;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;

// namespace School.Infrastructure.Data.Mapping
// {
//     public class UserConfiguration: IEntityTypeConfiguration<User>
//     {
//         public void Configure(EntityTypeBuilder<User> typeBuilder)
//         {
//             //Table configuration
//             typeBuilder.ToTable("dbo.tblUser");

//             //Property-column configuration
//             typeBuilder.Property(p => p.Id).HasColumnName("Id")
//                 .UseSqlServerIdentityColumn();
//             typeBuilder.Property(p => p.UserId).HasColumnName("UserId");
//             typeBuilder.Property(p => p.Password).HasColumnName("Password");
//             typeBuilder.Property(p => p.CreatedBy).HasColumnName("CreatedBy");
//             typeBuilder.Property(p => p.CreatedDate).HasColumnName("CreatedDate");
//             typeBuilder.Property(p => p.ModifiedBy).HasColumnName("ModifiedBy");
//             typeBuilder.Property(p => p.ModifiedDate).HasColumnName("ModifiedDate");
//             typeBuilder.Property(p => p.Active).HasColumnName("Active");
//         }
//     }
// }
