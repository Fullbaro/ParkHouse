using System;

public class ParkingMap : ClassMap<ParkingMap>
{
	public ParkingMap()
    {
        Id(x => x.Id);
        Map(x => x.StartDateTime);
        Map(x => x.EndDateTime);

    }
}
