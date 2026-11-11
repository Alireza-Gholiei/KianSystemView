using Microsoft.AspNetCore.Components.Forms;
using Services.Repositories.Interface._IDocument;
using Storebook.Service.HttpRequest;

namespace Services.Repositories.Service._Document;

public class DocumentService(IHttp http) : IDocumentService
{
    public async Task<string> UploadFile(IBrowserFile? file)
    {
        try
        {
            if (file != null)
                return await http.UploadFile<string>($"{StaticUrls.DocUrl}UploadFile", file);

            return "";
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<MemoryStream> DownloadFile(string? fileName)
    {
        try
        {
            var url = $"{StaticUrls.DocUrl}DownloadFile/{fileName}";

            var file = await http.GetFileAsync(url);

            return file;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<bool> DeleteFile(string fileName)
    {
        try
        {
            return await http.DeleteAsync<bool>($"{StaticUrls.DocUrl}DeleteFile/{fileName}");
        }
        catch (Exception)
        {
            throw;
        }
    }
}