using System.ComponentModel.DataAnnotations;

namespace ChuThiNgocYen_KTPMK22C_B6_Ver2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2,
            ErrorMessage = "Title cannot be longer than 200 characters.")]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public int GenreId { get; set; }

        public Genre? Genre { get; set; }
    }
}