using SchoolPortal.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class PrincipalMap : EntityTypeConfiguration<Principal>
    {
        public PrincipalMap()
        {
            ToTable("tblPrincipal");

            //Primary Key
            HasKey(pk => pk.PrincipalId);

            //Property-column mapping
            Property(P => P.PrincipalId).HasColumnName("PrincipalId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
            Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
            Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar");
            Property(p => p.Gender).HasColumnName("Gender").HasColumnType("varchar");
            Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime");

            
        }
    }
}