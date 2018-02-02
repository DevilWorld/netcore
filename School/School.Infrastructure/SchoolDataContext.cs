using Microsoft.EntityFrameworkCore;
using School.Domain.Model;
using SchoolPortal.Infrastructure.Data.Mapping;
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
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<PrincipalAddress> PrincipalAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            //Add this code, otherwise, we get model backing exception
            //Database.SetInitializer<SchoolDataContext>(null);

            //model.Configurations.Add(new PersonMap());
            model.Entity.Add(new UserMap());
            model.Configurations.Add(new StudentMap());
            model.Configurations.Add(new TeacherMap());
            model.Configurations.Add(new StudentClassMap());
            model.Configurations.Add(new PrincipalAddressMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
// optionsBuilder.usesq
        }
    }
}
