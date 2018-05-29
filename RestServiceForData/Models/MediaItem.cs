using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestServiceForData.Models
{
    public class MediaItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Medium { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public int WatchedOn { get; set; }
    }
}
