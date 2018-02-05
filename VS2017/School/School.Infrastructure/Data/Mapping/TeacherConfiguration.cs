// using School.Domain.Model;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;

// namespace School.Infrastructure.Data.Mapping
// {
//     class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
//     {
//         public void Configure(EntityTypeBuilder<Teacher> typeBuilder)
//         {
//             //Table configuration
//             typeBuilder.ToTable("tblTeacher");

//             //Primary Key
//             typeBuilder.HasKey(pk => pk.TeacherId);

//             //Property to column mapping
//             typeBuilder.Property(p => p.TeacherId).HasColumnName("TeacherId").HasColumnType("int")
//                 .UseSqlServerIdentityColumn();
//             typeBuilder.Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
//             typeBuilder.Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
//             typeBuilder.Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar");
//             typeBuilder.Property(p => p.Gender).HasColumnName("Gender").HasColumnType("varchar");
//             typeBuilder.Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime");

//             //Relationships                 1 to 0 or 1
//             // HasRequired(a => a.TeacherAddress)
//             //     .WithOptional(t => t.Teachers)
//             //     .Map(m => m.MapKey("AddressId"));

//             // HasRequired(s => s.School)
//             //     .WithMany(t => t.Teachers)
//             //     .HasForeignKey(fk => fk.SchoolId);
//         }
//     }
// }
