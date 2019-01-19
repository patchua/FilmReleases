using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmReleases.Data.Entities;

namespace FilmReleases.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly FilmsDbContext _context;
        public DataRepository(FilmsDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Film> GetAllFilms()
        {
            return _context
                .Films
                .ToList();
        }

        public Film GetFilm(int id)
        {
            return _context
                .Films
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Film> GetReleasedFilms(DateTime fromDate, DateTime toDate)
        {
            return _context
                .Films
                .Where(x => x.Release >= fromDate && x.Release <= toDate)
                .ToList();
        }
    }
}
