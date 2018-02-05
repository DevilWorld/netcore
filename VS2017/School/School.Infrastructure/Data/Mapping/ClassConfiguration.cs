// using School.Domain.Model;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;

// namespace School.Infrastructure.Data.Mapping
// {
//     class ClassConfiguration : IEntityTypeConfiguration<Class>
//     {
//         public void Configure(EntityTypeBuilder<Class> typeBuilder)
//         {
//             typeBuilder.ToTable("tblClass");

//             typeBuilder.HasKey(pk => pk.ClassId);
//             typeBuilder.Property(p => p.ClassId).HasColumnName("ClassId").HasColumnType("int")
//                 .UseSqlServerIdentityColumn();
//             typeBuilder.Property(p => p.ClassName).HasColumnName("ClassName").HasColumnType("varchar");
//             typeBuilder.Property(p => p.TeacherFromDate).HasColumnName("TeacherFromDate").HasColumnType("datetime");
//             typeBuilder.Property(p => p.TeacherToDate).HasColumnName("TeacherToDate").HasColumnType("datetime");

//             //Relationships
//             // typeBuilder.HasOne(t => t.Teacher)
//             //     .WithMany(c => c.Class)
//             //     .HasForeignKey(m => m.TeacherId);

//             // typeBuilder.HasOne(s => s.Subject)
//             //     .WithMany(c => c.Class)
//             //     .HasForeignKey(fk => fk.SubjectId);
//         }

        
//     }
// }
