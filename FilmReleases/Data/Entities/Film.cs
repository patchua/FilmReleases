using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmReleases.Data.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int AdDuration { get; set; } //Duration of Advertisement that is mandatory
        public string Distributor { get; set; }
        public int MinimumAge { get; set; }
        public DateTime Release { get; set; }
    }
}
