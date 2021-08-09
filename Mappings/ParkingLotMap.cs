using System;

namespace ParkHouse.Mappings
{
    
    public class ParkingLotMap : ClassMap<ParkingLotMap>
    {
        public ParkingLotMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Capacity);
        }
    }

}