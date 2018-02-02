using System.Data.Entity.ModelConfiguration;
using School.Domain.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolPortal.Infrastructure.Data.Mapping
{
    public class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            //Table configuration
            ToTable("dbo.tblUser");

            //Property-column configuration
            Property(p => p.Id).HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.UserId).HasColumnName("UserId");
            Property(p => p.Password).HasColumnName("Password");
            Property(p => p.CreatedBy).HasColumnName("CreatedBy");
            Property(p => p.CreatedDate).HasColumnName("CreatedDate");
            Property(p => p.ModifiedBy).HasColumnName("ModifiedBy");
            Property(p => p.ModifiedDate).HasColumnName("ModifiedDate");
            Property(p => p.Active).HasColumnName("Active");
        }
    }
}
