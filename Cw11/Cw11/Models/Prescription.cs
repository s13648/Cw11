using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cw11.Models
{
    public class Prescription
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPrescription { get; set; }

        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public DateTime DueDate { get; set; }
        
        [Required]
        public int IdPatient { get; set; }
        
        [Required]
        public int IdDoctor { get; set; }
    }
}