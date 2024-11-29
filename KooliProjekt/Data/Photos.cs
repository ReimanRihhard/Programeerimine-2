using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Photos
    {
        public string Title  { get; set; }
        [Required]
        [StringLength(30)]
        public string Description { get; set; }
        [Required]
        public int Coordinates { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
    }
}
