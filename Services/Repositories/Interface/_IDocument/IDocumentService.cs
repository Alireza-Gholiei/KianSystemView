using Microsoft.AspNetCore.Components.Forms;

namespace Services.Repositories.Interface._IDocument;

public interface IDocumentService
{
    Task<string> UploadFile(IBrowserFile? file);
    Task<MemoryStream> DownloadFile(string? fileName);
    Task<bool> DeleteFile(string fileName);
}