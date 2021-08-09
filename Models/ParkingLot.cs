using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ParkHouse.Models
{
    public class CarPark
    {        
        public virtual int Id { get; protected set; }     
        public virtual string Name { get; set; }     
        public virtual int Capacity { get; set; }
    }
}
