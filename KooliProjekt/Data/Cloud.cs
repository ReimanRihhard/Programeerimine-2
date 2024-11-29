using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Cloud
    {
        public string Owner { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
    } 
}
