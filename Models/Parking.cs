using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkHouse.Models
{
    public class Parking
    {
         public virtual int Id { get; protected set; }
         public virtual DateTime StartDateTime { get; set; }
         public virtual DateTime EndDateTime{ get; set; }
         public virtual Car Car { get; set; }
         public virtual ParkingLot ParkingLot { get; set; }
    }
}
