using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuThiNgocYen_KTPMK22C_B6_Ver2.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "Genre name must be between 2 and 100 characters.")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}