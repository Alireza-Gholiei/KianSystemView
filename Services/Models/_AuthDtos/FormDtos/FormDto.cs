namespace Services.Models._AuthDtos.FormDtos;

public class FormDto
{
    public long Id { get; set; }
    public long? ParentId { get; set; }
    public long FormTypeId { get; set; }
    public string FormNamePersian { get; set; } = null!;
    public string FormUrl { get; set; } = null!;
    public string Parent { get; set; } = null!;
    public string Icon { get; set; } = null!;
    public int Order { get; set; }
}