using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeFlix.Models
{
    public class MovieDetailViewModel
    {
        public Movie Movie { get; set; }
        public PaginatedList<Episode> Episodes { get; set; }
    }
}
