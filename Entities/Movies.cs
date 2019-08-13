using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Entities
{
    public class Movies
    {
        [Key]
        public int movieid { get; set; }
        public int actorid { get; set; }
        public int yearofrelease { get; set; }
        public string plot { get; set; }
        public byte[] poster { get; set; }
        public int producerid { get; set; }
    }
}
