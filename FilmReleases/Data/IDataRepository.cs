using FilmReleases.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmReleases.Data
{
    public interface IDataRepository
    {
        IEnumerable<Film> GetAllFilms();
        IEnumerable<Film> GetReleasedFilms(DateTime fromDate, DateTime toDate);
        Film GetFilm(int id);
    }
}
