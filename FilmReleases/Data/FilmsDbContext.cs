using FilmReleases.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmReleases.Data
{
    public class FilmsDbContext:DbContext 
    {
        public FilmsDbContext(DbContextOptions<FilmsDbContext> contextOptions):base(contextOptions)
        {
        }
        public DbSet<Film> Films { get; set; }
    }
}
