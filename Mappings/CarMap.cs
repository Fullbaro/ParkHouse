using System;

public class CarMap : ClassMap(Car)	
{
	public CarMap()
	{
		Id(x => x.Id);

	}
}
