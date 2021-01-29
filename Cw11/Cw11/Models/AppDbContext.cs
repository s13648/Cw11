using Microsoft.EntityFrameworkCore;

namespace Cw11.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Prescription_Medicament> PrescriptionMedicaments { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prescription_Medicament>().HasKey(n => new { n.IdMedicament, n.IdPrescription });
        }
    }
}