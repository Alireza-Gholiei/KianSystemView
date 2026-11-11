using Services.Models._AuthDtos.GarrisonDtos;

namespace Services.Models._AuthDtos.LocationDtos;

public class LocationDto
{
    public long Id { get; set; }
    public long? ParentId { get; set; }
    public string Name { get; set; } = null!;
    public string Parent { get; set; } = null!;
    public long? LocationTypeId { get; set; }

    public LocationTypeDto? LocationType { get; set; }
    public List<GarrisonDto>? Garrisons { get; set; }
}