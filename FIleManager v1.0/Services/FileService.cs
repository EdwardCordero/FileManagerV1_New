using FIleManager_v1._0.Models.Files.Request;

namespace FIleManager_v1._0.Services;
public class FileService
{
    public FileService()
    { }

    public async Task<string> CreateFile(FileUploadRequest fileUpload)
    {
        return "Creating File";
    }
}
