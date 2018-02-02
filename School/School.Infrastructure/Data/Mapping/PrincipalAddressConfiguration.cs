using School.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Infrastructure.Data.Mapping
{
    class PrincipalAddressConfiguration:IEntityTypeConfiguration<PrincipalAddress>
    {
        public void Configure(EntityTypeBuilder<PrincipalAddress> typeBuilder)
        {
            typeBuilder.ToTable("tblPricipalAddress");

            //Primary Key Configuration
            typeBuilder.HasKey(pk => pk.PrincipalId);

            //Property-Column mapping
            typeBuilder.Property(p => p.PrincipalId).HasColumnName("PrincipalId").HasColumnType("int");
            typeBuilder.Property(p => p.Address1).HasColumnName("Address1").HasColumnType("varchar");
            typeBuilder.Property(p => p.Address2).HasColumnName("Address2").HasColumnType("varchar");
            typeBuilder.Property(p => p.City).HasColumnName("City").HasColumnType("varchar");
            typeBuilder.Property(p => p.State).HasColumnName("State").HasColumnType("varchar");
            typeBuilder.Property(p => p.Zip).HasColumnName("Zip").HasColumnType("int");

            // HasRequired(p => p.Principal).WithRequiredDependent(d=>d.PrincipalAddress);
        }
    }
}
