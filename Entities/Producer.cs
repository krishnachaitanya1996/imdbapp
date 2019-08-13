
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Producer
    {
        [Required]
        public string name { get; set; }
        [Key]
        public int producerid { get; set; }
        [Required]
        public string sex { get; set; }
        [Required]
        public string Bio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
    }
}
