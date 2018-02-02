using System;
using School.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class SubjectMap : EntityTypeConfiguration<Subject>
    {
        public SubjectMap()
        {
            //Table configuration
            ToTable("tblSubjects");

            //Primary key configuration
            HasKey<int>(pk => pk.SubjectId);

            //Property-column mapping
            Property(p => p.SubjectId).HasColumnName("SubjectId").HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.SubjectName).HasColumnName("SubjectName").HasColumnType("varchar");
        }
    }
}
