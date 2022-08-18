using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace API_MOVIE.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Titulo { get; set; }
        [Required, StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
