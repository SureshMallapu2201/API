using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [StringLength(15)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(15)]
        [Required]
        public string LastName { get; set; }
    }
}
