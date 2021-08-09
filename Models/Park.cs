using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkHouse.Models
{
    public class Park
    {
        [Key]
        public int Id { get; set; }
        [MinLength(1)] [MaxLength(32)]
        public string Name { get; set; }
        [MinLength(1)] [MaxLength(5)]
        public int Capacity { get; set; }
    }
}
