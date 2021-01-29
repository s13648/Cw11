using System;
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

            modelBuilder
                .Entity<Patient>()
                .HasData(new Patient
                {
                    IdPatient = 1,
                    Birthdate = new DateTime(1992,12,12),
                    FirstName = "Adam",
                    LastName = "Kowalski"
                });

            modelBuilder
                .Entity<Doctor>()
                .HasData(new Doctor
                {
                    IdDoctor = 1,
                    FirstName = "Doctor",
                    LastName = "Kowaslki",
                    Email = "doc@email.com"
                });

            modelBuilder
                .Entity<Medicament>()
                .HasData(new Medicament
                {
                    IdMedicament = 1,
                    Description = "Test opis",
                    Name = "Name",
                    Type = "Type"
                });

            modelBuilder.Entity<Prescription>()
                .HasData(new Prescription
                {
                    IdPrescription = 1,
                    IdPatient = 1,
                    IdDoctor = 1,
                    Date = new DateTime(2021,01,21),
                    DueDate = new DateTime(2021,01,22)
                });

            modelBuilder.Entity<Prescription_Medicament>().HasData(new Prescription_Medicament
            {
                Details = "Details",
                Dose = 1,
                IdMedicament = 1,
                IdPrescription = 1
            });
        }
    }
}