using School.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Infrastructure.Data.Mapping
{
    class AddressConfiguration:IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("tblAddress");
            builder.HasKey(k => k.AddressId);
            builder.Property(p => p.AddressId).HasColumnName("AddressId").HasColumnType("int").UseSqlServerIdentityColumn();
            builder.Property(p => p.Address1).HasColumnName("Address1").HasColumnType("varchar(100)");
            builder.Property(p => p.Address2).HasColumnName("Address2").HasColumnType("varchar(30)");
            builder.Property(p => p.City).HasColumnName("City").HasColumnType("varchar(30)");
            builder.Property(p => p.State).HasColumnName("State").HasColumnType("varchar(30)");
            builder.Property(p => p.Zip).HasColumnName("Zip").HasColumnType("int");            
        }
    }
}
