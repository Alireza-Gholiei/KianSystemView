namespace Services.Models.StartDtos.DossierListDtos;

public class DossierGetUploadedDto
{
    public long Id { get; set; }
    public long DossierId { get; set; }
    public string DossierListName { get; set; } = null!;
}