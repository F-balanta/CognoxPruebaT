using System.Collections;
using System.Collections.Generic;
using API_MOVIE.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using API_MOVIE.Models;

namespace API_MOVIE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext _context;

        // Constructor
        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }

        // Obtener Peliculas
        [HttpGet (Name = "GetMovies")]
        public IEnumerable<Movie> GetMovies()
        {

            return _context.Movies.OrderBy(x => x.Titulo).ToList();
        }

        [HttpGet]
        [Route("{id}")]
        public Movie GetMoviebyId(int id)
        {
            return _context.Movies.FirstOrDefault(x => x.Id == id);
        }

        [HttpPost]
        [Route("CreateMovie")]
        public IActionResult CreateMovie([FromBody]Movie movie)
        {
            if (movie == null)
                return BadRequest();

            // Se agrega lo que envia el usuario hacia el 
            _context.Movies.Add(movie);
            // Se guardan los cambios
            _context.SaveChanges();
            return CreatedAtRoute("GetMovies", new
                {
                    Id = movie.Id,
                    Titulo = movie.Titulo,
                    Descripcion = movie.Descripcion,
                    Url = movie.Url
                }, movie);
        }

        [HttpPut]
        [Route("Update/{id}")]
        public IActionResult UpdateMovie([FromBody]Movie movie, int movieId)
        {
            if (movie == null)
                return NotFound();
            var movieUpdate = _context.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movieUpdate == null)
                return NotFound();

            if (movieUpdate != null)
            {
                movieUpdate.Id = movie.Id;
                movieUpdate.Titulo = movie.Titulo;
                movieUpdate.Descripcion = movie.Descripcion;
                movieUpdate.Url = movie.Url;
            }

            _context.SaveChanges();
            return Ok(movieUpdate);

        }

    }
}
