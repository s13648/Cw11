using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cw11.Models
{
    public class Doctor
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDoctor { get; set; }

        [MaxLength(100)] 
        [Required]
        public string FirstName { get; set; }

        [MaxLength(100)]
        [Required] 
        public string LastName { get; set; }

        [MaxLength(100)] 
        [Required]
        public string Email { get; set; }
    }
}