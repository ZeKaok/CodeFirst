using CodeFirstBTKAkademi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBTKAkademi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private BTKAkademiDbContext dbContext;

        public MoviesController(BTKAkademiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies = dbContext.Movie.ToList();
            return movies;
        }

        [HttpPost]
        public Movie FilmEkle(Movie movie)
        {
            dbContext.Movie.Add(movie);
            dbContext.SaveChanges();
            return movie;
        }
        [HttpPut]
        public Movie FilmGuncelle(Movie movie)
        {
            dbContext.Movie.Update(movie);
            dbContext.SaveChanges();
            return movie;

        }
    }
}
