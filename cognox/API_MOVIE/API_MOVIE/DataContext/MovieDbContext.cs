using API_MOVIE.Models;
using Microsoft.EntityFrameworkCore;

namespace API_MOVIE.DataContext
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options) : base(options)
        {
            // Crea la base de datos con los datos correspondientes si no existe
            Database.EnsureCreated();
        }


        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>()
                .HasData(
                    new Movie()
                    {
                        Id = 1,
                        Titulo = "12 años de esclavitud",
                        Descripcion = " Pelicula nro 1 de la cartelera",
                        Url = "https://imagenes.canalrcn.com/lomaslike/preprate-para-conocer-los-12-aos-de-esclavitud-de-solomon-por-el-canal-rcn-este-domingo.jpg"
                    },
                    new Movie()
                    {
                        Id = 2,
                        Titulo = "Dos buenos tipos",
                        Descripcion = " Pelicula nro 2 de la cartelera",
                        Url = "https://pics.filmaffinity.com/Dos_buenos_tipos-118256026-large.jpg"
                    },
                    new Movie()
                    {
                        Id = 3,
                        Titulo = "Spiderman 2",
                        Descripcion = "Auxilio abuela me pico una araña",
                        Url = "https://static.wikia.nocookie.net/blackcoffe/images/1/1f/Spiderman2.jpg/revision/latest?cb=20120611025348&path-prefix=es"
                    }
                );
        }
    }
}
