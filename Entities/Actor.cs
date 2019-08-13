using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Actor
    {
        [Key]
        public int actorid { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string sex { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string Bio { get; set; }
    }
}
