using System;
using System.ComponentModel.DataAnnotations;

namespace Cw11.Models
{
    public class Prescription
    {
        [Key] public int IdPrescription { get; set; }

        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
    }
}