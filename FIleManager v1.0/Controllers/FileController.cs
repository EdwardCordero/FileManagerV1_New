using Microsoft.AspNetCore.Mvc;
using FIleManager_v1._0.Models.Files.Request;
using FIleManager_v1._0.Services;


namespace FIleManager_v1._0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly ILogger<FileController> _logger;
        private readonly FileService _fileService;
        public FileController(ILogger<FileController> logger, FileService fileService)
        {
            _logger = logger;
            _fileService = fileService;
        }

        [HttpPost("create-file")]
        public async Task<IActionResult> FileUpload(IFormFile file)
        {
            var request = new FileUploadRequest
            {
                FileName = file.FileName,
                FileType = file.ContentType,
            };

            var response = await _fileService.CreateFile(request);
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok();
        }
    }
}
