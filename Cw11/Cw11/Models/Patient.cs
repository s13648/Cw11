using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cw11.Models
{
    public class Patient
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPatient { get; set; }

        [MaxLength(100)] 
        [Required]
        public string FirstName { get; set; }

        [MaxLength(100)] 
        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }
    }
}