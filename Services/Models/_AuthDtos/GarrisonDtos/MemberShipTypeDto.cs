using Services.Models._AuthDtos.UserDtos;

namespace Services.Models._AuthDtos.GarrisonDtos;

public class MemberShipTypeDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;

    public List<UserDto> Users { get; set; } = [];
}