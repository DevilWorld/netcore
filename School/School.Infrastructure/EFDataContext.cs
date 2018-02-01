using System.Data.Entity;
using School.Domain.Model;
using SchoolPortal.Infrastructure.Data.Mapping;


namespace SchoolPortal.Infrastructure
{
    public class EFDataContext : Context
    {
        public EFDataContext()
            : base("name=SchoolContext")
        { }

        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<PrincipalAddress> PrincipalAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder model)
        {
            //Add this code, otherwise, we get model backing exception
            Database.SetInitializer<EFDataContext>(null);

            //model.Configurations.Add(new PersonMap());
            model.Configurations.Add(new UserMap());
            model.Configurations.Add(new StudentMap());
            model.Configurations.Add(new TeacherMap());
            model.Configurations.Add(new StudentClassMap());
            model.Configurations.Add(new PrincipalAddressMap());
        }
    }
}
