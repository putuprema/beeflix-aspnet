using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeeFlix.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }
        public Movie Movie { get; set; }
    }
}
