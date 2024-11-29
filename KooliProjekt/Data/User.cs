using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
     
        public string Email { get; set; }

        [Required]
        [Range(0,50)]
        public string Phone { get; set; }
    }
}
