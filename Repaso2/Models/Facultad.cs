using System.ComponentModel.DataAnnotations;

namespace Repaso2.Models
{
    public class Facultad
    {
        [Key]

        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Nombre { get; set; }

    }

}
