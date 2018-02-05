// using School.Domain.Model;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;

// namespace School.Infrastructure.Data.Mapping
// {
//     class PrincipalConfiguration : IEntityTypeConfiguration<Principal>
//     {
//         public void Configure(EntityTypeBuilder<Principal> typeBuilder)
//         {
//             typeBuilder.ToTable("tblPrincipal");

//             //Primary Key
//             typeBuilder.HasKey(pk => pk.PrincipalId);

//             //Property-column mapping
//             typeBuilder.Property(P => P.PrincipalId).HasColumnName("PrincipalId")
//                 .UseSqlServerIdentityColumn();
//             typeBuilder.Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
//             typeBuilder.Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
//             typeBuilder.Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar");
//             typeBuilder.Property(p => p.Gender).HasColumnName("Gender").HasColumnType("varchar");
//             typeBuilder.Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime");

            
//         }
//     }
// }