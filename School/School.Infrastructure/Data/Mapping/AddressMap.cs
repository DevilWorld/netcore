using SchoolPortal.Domain.Model;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    class AddressMap:EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            ToTable("tblAddress");
            HasKey(k => k.AddressId);
            Property(p => p.AddressId).HasColumnName("AddressId").HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Address1).HasColumnName("Address1").HasColumnType("varchar");
            Property(p => p.Address2).HasColumnName("Address2").HasColumnType("varchar");
            Property(p => p.City).HasColumnName("City").HasColumnType("varchar");
            Property(p => p.State).HasColumnName("State").HasColumnType("varchar");
            Property(p => p.Zip).HasColumnName("Zip").HasColumnType("int");            
        }
    }
}
