using Microsoft.EntityFrameworkCore;
using School.Domain.Model;
using School.Infrastructure.Data.Mapping;
using System;


namespace School.Infrastructure
{
    public class SchoolDataContext : DbContext
    {
        // public SchoolDataContext()
        //     : base("name=SchoolContext")
        // { }

        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Person> Persons { get; set; }
        // public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        // public DbSet<Teacher> Teachers { get; set; }
        // public DbSet<StudentClass> StudentClasses { get; set; }
        // public DbSet<PrincipalAddress> PrincipalAddresses { get; set; }
        public DbSet<Address> Addresses{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add this code, otherwise, we get model backing exception
            //Database.SetInitializer<SchoolDataContext>(null);

            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            // modelBuilder.ApplyConfiguration(new ClassConfiguration());
            // modelBuilder.ApplyConfiguration(new HomeWorkConfiguration());
            modelBuilder.ApplyConfiguration(new ParentConfiguration());
            // modelBuilder.ApplyConfiguration(new PrincipalAddressConfiguration());
            // modelBuilder.ApplyConfiguration(new PrincipalConfiguration());
            // modelBuilder.ApplyConfiguration(new SchoolConfiguration());
            // modelBuilder.ApplyConfiguration(new StudentClassConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            // modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            // modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            // modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Dinesh-pc\SQLEXPRESS;Initial Catalog=SchoolTest;Integrated Security=true;");
        }
    }
}
