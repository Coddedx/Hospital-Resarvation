using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HospitalResarvation.Web.Models
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext()
        {

        }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
            
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Salary> Salaries { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //override onc yaz tab bas direk çıkıyo
        {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-QT5SFJG4\\SQLEXPRESS; Database=HospitalDb; Trusted_Connection=true; Encrypt=false;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
