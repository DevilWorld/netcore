using System;
using School.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Infrastructure.Data.Mapping
{
    class SchoolConfiguration : IEntityTypeConfiguration<School.Domain.Model.School>
    {
        public void Configure(EntityTypeBuilder<School.Domain.Model.School> typeBuilder)
        {
            typeBuilder.ToTable("tblSchool");

            typeBuilder.HasKey(pk => pk.SchoolId);

            typeBuilder.Property(p => p.SchoolId).HasColumnName("SchoolId")
                .UseSqlServerIdentityColumn();
            typeBuilder.Property(p => p.SchoolName).HasColumnName("SchoolName");            
            //Property(p => p.PrincipalId).HasColumnName("PrincipalId");
            typeBuilder.Property(p => p.Address1).HasColumnName("Address1");
            typeBuilder.Property(p => p.Address2).HasColumnName("Address2");
            typeBuilder.Property(p => p.City).HasColumnName("City");
            typeBuilder.Property(p => p.State).HasColumnName("State");
            typeBuilder.Property(p => p.Zip).HasColumnName("Zip");

            //Relationships
            //HasOptional(p => p.Principal)               //1 to   0 or 1
            //    .WithMany().HasForeignKey(fk => fk.PrincipalId);
                
        }
    }
}
