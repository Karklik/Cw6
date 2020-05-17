using System.ComponentModel.DataAnnotations;

namespace Cw6.Models
{
    public class Studies
    {
        [Required]
        public int IdStudy { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
