using FilmReleases.Data;
using FilmReleases.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmReleases.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmsController : ControllerBase
    {
        private readonly IDataRepository _repository;
        private readonly ILogger<FilmsController> _logger;
        public FilmsController(IDataRepository repository, ILogger<FilmsController> logger)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet()]
        public ActionResult<IEnumerable<Film>> Get([FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate)
        {
            if (fromDate == null)
                return _repository.GetAllFilms().ToList();
            var to_date = toDate ?? DateTime.MaxValue;
            return _repository.GetReleasedFilms(fromDate.Value, to_date).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Film> Get(int id)
        {
           var film= _repository.GetFilm(id);
            if (film == null)
            {
                return NotFound();
            }
            return Ok(film); 
        }
    }
}
