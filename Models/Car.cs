using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkHouse.Models
{
    public class Car
    {
        public virtual int Id { get; protected set; }
        public virtual string Brand { get; set; }
        public virtual string Type { get; set; }
        public virtual string Color { get; set; }
        public virtual string LicencePlateNumber { get; set; }
    }
}
