using System;
using System.Collections.Generic;
using School.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class HomeWorkMap : EntityTypeConfiguration<HomeWork>
    {
        public HomeWorkMap()
        {
            ToTable("tblHomeWork");

            Property(p => p.HomeWorkId).HasColumnName("HomeWorkId").HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //PK configurations
            HasKey(pk => new { pk.StudentId, pk.ClassId });

            Property(p => p.HomeWorkContent).HasColumnName("HomeWorkContent").HasColumnType("varchar");
            Property(p => p.CreatedBy).HasColumnName("CreatedBy").HasColumnType("int");
            Property(p => p.DateCreated).HasColumnName("DateCreated").HasColumnType("datetime");
            Property(p => p.CompletedOn).HasColumnName("CompletedOn").HasColumnType("datetime");

            //Relationships
            HasRequired(s => s.Student)
                .WithMany(c => c.HomeWork)
                .HasForeignKey(fk => fk.StudentId);

            HasRequired(s => s.Class)
                .WithMany(c => c.HomeWork)
                .HasForeignKey(fk => fk.ClassId);
        }
    }
}
