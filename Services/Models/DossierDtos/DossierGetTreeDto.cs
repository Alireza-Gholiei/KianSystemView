namespace Services.Models.DossierDtos;

public class DossierGetTreeDto
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public string Photo { get; set; } = null!;

    public List<DossierGetTreeDto> SubDossier { get; set; } = [];
}