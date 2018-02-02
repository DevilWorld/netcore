using System;
using System.Collections.Generic;
using School.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System.ComponentModel.DataAnnotations.Schema;

namespace School.Infrastructure.Data.Mapping
{
    class HomeWorkConfiguration : IEntityTypeConfiguration<HomeWork>
    {
        public void Configure(EntityTypeBuilder<HomeWork> typeBuilder)
        {
            typeBuilder.ToTable("tblHomeWork");

            typeBuilder.Property(p => p.HomeWorkId).HasColumnName("HomeWorkId").HasColumnType("int")
                .UseSqlServerIdentityColumn();

            //PK configurations
            typeBuilder.HasKey(pk => new { pk.StudentId, pk.ClassId });

            typeBuilder.Property(p => p.HomeWorkContent).HasColumnName("HomeWorkContent").HasColumnType("varchar");
            typeBuilder.Property(p => p.CreatedBy).HasColumnName("CreatedBy").HasColumnType("int");
            typeBuilder.Property(p => p.DateCreated).HasColumnName("DateCreated").HasColumnType("datetime");
            typeBuilder.Property(p => p.CompletedOn).HasColumnName("CompletedOn").HasColumnType("datetime");

            //Relationships
            // typeBuilder.HasOne(s => s.Student)
            //     .WithMany(c => c.HomeWork)
            //     .HasForeignKey(fk => fk.StudentId);

            // typeBuilder.HasOne(s => s.Class)
            //     .WithMany(c => c.HomeWork)
            //     .HasForeignKey(fk => fk.ClassId);
        }
    }
}
