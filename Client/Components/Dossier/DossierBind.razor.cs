using Despro.Blazor.Display.Components.TreeViews;
using Despro.Blazor.Display.Models;
using Microsoft.AspNetCore.Components;
using Services.Models.DossierDtos;
using Services.Repositories.Interface._IDocument;
using Services.Repositories.Interface.IDossier;

namespace Client.Components.Dossier;

public partial class DossierBind : BaseComponent
{
    [Inject] private IDossierService _dossierService { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private IDocumentService _documentService { get; set; }

    private long EmployeId { get; set; }
    private TreeView<DossierGetTreeDto> treeView { get; set; }
    private List<DossierGetTreeDto> folders { get; set; } = new List<DossierGetTreeDto>();
    public DossierGetTreeDto selectedFolder { get; set; }

    private byte[] file { get; set; }
    private ImageContentTypes contentType { get; set; }
    private bool IsFileLoad { get; set; }


    private async Task EmployeSelect(long value)
    {
        try
        {
            folders = await _dossierService.GetTree(value);
        }
        catch (Exception e)
        {
            _toastService.ErrorAlert(e.Message);
        }
    }

    private async Task SelectDossier(DossierGetTreeDto model)
    {
        try
        {
            IsFileLoad = true;
            selectedFolder = model;
            file = null;
            if (model.Photo is not null)
            {
                var fileStream = await _documentService.DownloadFile(model.Photo);

                fileStream.Position = 0;

                //contentType = "image/" + Path.GetExtension(model.Photo).Replace(".", "");
                contentType = ImageContentTypes.png;

                file = fileStream.ToArray();
            }
            IsFileLoad = false;
        }
        catch (Exception e)
        {
            IsFileLoad = false;
            _toastService.ErrorAlert(e.Message);
        }
    }
}
