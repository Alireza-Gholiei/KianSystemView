namespace Services.Models._AuthDtos.LocationDtos;

public class LocationTypeDto
{
    public string Name { get; set; } = null!;
    public long? GKey { get; set; }

    public List<LocationDto> Locations { get; set; } = [];
}