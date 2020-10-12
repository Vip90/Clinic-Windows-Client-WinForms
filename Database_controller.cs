using System.Data.Entity;
namespace Clinic
{
    class Database_controller
        : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Visit> Visits { get; set; }
    }
}
