using SchoolPortal.Domain.Model;
using System.Data.Entity.ModelConfiguration;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class PrincipalAddressMap:EntityTypeConfiguration<PrincipalAddress>
    {
        public PrincipalAddressMap()
        {
            ToTable("tblPricipalAddress");

            //Primary Key Configuration
            HasKey(pk => pk.PrincipalId);

            //Property-Column mapping
            Property(p => p.PrincipalId).HasColumnName("PrincipalId").HasColumnType("int");
            Property(p => p.Address1).HasColumnName("Address1").HasColumnType("varchar");
            Property(p => p.Address2).HasColumnName("Address2").HasColumnType("varchar");
            Property(p => p.City).HasColumnName("City").HasColumnType("varchar");
            Property(p => p.State).HasColumnName("State").HasColumnType("varchar");
            Property(p => p.Zip).HasColumnName("Zip").HasColumnType("int");

            HasRequired(p => p.Principal).WithRequiredDependent(d=>d.PrincipalAddress);
        }
    }
}
