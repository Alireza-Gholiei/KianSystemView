namespace Services.Models._AuthDtos.FormDtos;

public class FormGetChildDto
{
    public long Id { get; set; }
    public long? ParentId { get; set; }
    public string Name { get; set; } = null!;
    public FormType FormType { get; set; }
}