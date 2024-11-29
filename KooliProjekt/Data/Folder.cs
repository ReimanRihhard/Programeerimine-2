using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Folder
    {
        public string Owner { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
