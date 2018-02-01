using System;
using System.Data.Entity.ModelConfiguration;
using SchoolPortal.Domain.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class SchoolMap : EntityTypeConfiguration<School>
    {
        public SchoolMap()
        {
            ToTable("tblSchool");

            HasKey(pk => pk.SchoolId);

            Property(p => p.SchoolId).HasColumnName("SchoolId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.SchoolName).HasColumnName("SchoolName");            
            //Property(p => p.PrincipalId).HasColumnName("PrincipalId");
            Property(p => p.Address1).HasColumnName("Address1").IsOptional();
            Property(p => p.Address2).HasColumnName("Address2").IsOptional();
            Property(p => p.City).HasColumnName("City").IsOptional();
            Property(p => p.State).HasColumnName("State").IsOptional();
            Property(p => p.Zip).HasColumnName("Zip").IsOptional();

            //Relationships
            //HasOptional(p => p.Principal)               //1 to   0 or 1
            //    .WithMany().HasForeignKey(fk => fk.PrincipalId);
                
        }
    }
}
