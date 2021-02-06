using BeeFlix.Data;
using BeeFlix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeFlix.Controllers
{
    public class MovieController : Controller
    {
        private readonly BeeFlixContext _context;

        public MovieController(BeeFlixContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var genres = from g in _context.Genre select g;

            genres = genres.Include(g => g.Movies);

            return View(await genres.ToListAsync());
        }

        public async Task<IActionResult> Details(int id, int episodePage = 1)
        {
            var movieQuery = from m in _context.Movie select m;

            movieQuery = movieQuery.Include(m => m.Genre);

            var movie = await movieQuery.FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            int pageSize = 3;

            var episodeQuery = from e in _context.Episode select e;
            episodeQuery = episodeQuery.Where(e => e.Movie.Id == id).OrderBy(e => e.Order);

            var episodes = await PaginatedList<Episode>.CreateAsync(episodeQuery.AsNoTracking(), episodePage, pageSize);

            return View(
                new MovieDetailViewModel {
                    Movie = movie,
                    Episodes = episodes
                });
        }

        public async Task<IActionResult> ByGenre(int id)
        {
            var genre = await _context.Genre
                .Include(g => g.Movies)
                .FirstOrDefaultAsync(g => g.Id == id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }
    }
}
