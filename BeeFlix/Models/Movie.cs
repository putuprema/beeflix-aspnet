using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeFlix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public short Rating { get; set; } 
        public string Photo { get; set; }
        public Genre Genre { get; set; }
        public List<Episode> Episodes { get; set; }
    }
}
