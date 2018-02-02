using School.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Infrastructure.Data.Mapping
{
    class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> typeBuilder)
        {
            typeBuilder.ToTable("tblStudents");
            typeBuilder.HasKey(k => k.StudentId);
            typeBuilder.Property(p => p.StudentId).HasColumnName("StudentId").HasColumnType("int").IsRequired();
            typeBuilder.Property(p => p.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
            typeBuilder.Property(p => p.LastName).HasColumnName("LastName").HasColumnType("varchar");
            typeBuilder.Property(p => p.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
            typeBuilder.Property(p => p.Sex).HasColumnName("Gender").HasColumnType("varchar");
            typeBuilder.Property(p => p.DOB).HasColumnName("DOB").HasColumnType("datetime2");

            //One-to-One relationship for the student with address      
            typeBuilder.HasOne(a => a.Address)                           //Address ----> Principal Entity        Student ---> Dependent Entity
                .WithMany(s => s.Students)
                .HasForeignKey(fk => fk.AddressId);

            //One-to-Many relationship for the parents with Students
            typeBuilder.HasOne(p => p.Parent)       //Parent --> Principal Entity       Student --> Dependent Entity
                .WithMany(s => s.Students)
                .HasForeignKey(fk => fk.ParentId);
        }
    }
}
