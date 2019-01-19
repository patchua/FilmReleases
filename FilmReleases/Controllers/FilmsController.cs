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
            try
            {
                return _repository.GetReleasedFilms(fromDate.Value, to_date).ToList();
            }
            catch 
            {
                _logger.LogError($"Error while fetching films");
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Film> Get(int id)
        {
            Film film;
            try
            {
                film = _repository.GetFilm(id);
            }
            catch
            {
                _logger.LogError($"Error while trying to get film id={id}");
                return BadRequest();
            }
            if (film == null)
            {
                _logger.LogInformation($"Film not found id={id}");
                return NotFound();
            }
            return Ok(film); 
        }
    }
}
