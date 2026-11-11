namespace Services.Models.DossierDtos;

public class DossierGetDto
{
    public long Id { get; set; }
    public long EmployeId { get; set; }
    public long DossierTypeId { get; set; }
    public string Dossier { get; set; } = null!;
    public List<DossierGetDto> dossierGetDtos { get; set; } = [];
}