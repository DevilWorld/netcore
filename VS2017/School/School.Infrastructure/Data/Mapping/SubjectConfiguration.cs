// using System;
// using School.Domain.Model;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;

// namespace School.Infrastructure.Data.Mapping
// {
//     class SubjectConfiguration : IEntityTypeConfiguration<Subject>
//     {
//         public void Configure(EntityTypeBuilder<Subject> typeBuilder)
//         {
//             //Table configuration
//             typeBuilder.ToTable("tblSubjects");

//             //Primary key configuration
//             typeBuilder.HasKey(pk => pk.SubjectId);

//             //Property-column mapping
//             typeBuilder.Property(p => p.SubjectId).HasColumnName("SubjectId").HasColumnType("int")
//                 .UseSqlServerIdentityColumn();
//             typeBuilder.Property(p => p.SubjectName).HasColumnName("SubjectName").HasColumnType("varchar");
//         }
//     }
// }
