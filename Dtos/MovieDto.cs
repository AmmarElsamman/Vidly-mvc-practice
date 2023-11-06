using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Required(ErrorMessage = "The Release Date field is required")]
        public DateTime ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        [Range(1, 20, ErrorMessage = "The field Number in Stock must be between 1 and 20")]
        public byte InStock { get; set; }
    }
}