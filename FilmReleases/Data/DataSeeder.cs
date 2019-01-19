using FilmReleases.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmReleases.Data
{
    public class DataSeeder
    {
        private FilmsDbContext _context;
        public DataSeeder(FilmsDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();
            if (!_context.Films.Any())
            {
                var film1 = new Film { Name = "Die hard", AdDuration = 10, Distributor = "Volga", Duration = 120, MinimumAge = 16,Release=new DateTime(1998,12,31) };
                _context.Films.Add(film1);
                var film2 = new Film { Name = "Die hard 2", AdDuration = 10, Distributor = "MJN", Duration = 100, MinimumAge = 16, Release= new DateTime(2001,10,23) };
                _context.Films.Add(film2);
                var film3 = new Film { Name = "Die hard 3", AdDuration = 10, Distributor = "jsf", Duration = 122, MinimumAge = 16 , Release= new DateTime(2002,11,20)};
                _context.Films.Add(film3);
            }

            _context.SaveChanges();
        }
    }
}
