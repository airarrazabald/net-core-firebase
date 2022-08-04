using FirebaseStorageApp.Model;
using FirebaseStorageApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FirebaseStorageApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileStorageController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FileModel file)
        {
            string fileUrlFirebase = await Upload(file);
            return Ok(new { fileUrlFirebase });
        }

        private static async Task<string> Upload(FileModel file)
        {
            var fileFromBase64ToStream = FirebaseStorageService.ConvertBase64ToStream(file.FileBase64);
            var fileStream = fileFromBase64ToStream.ReadAsStream();

            string fileUrlFirebase = await FirebaseStorageService.UploadFile(fileStream, file);
            return fileUrlFirebase;
        }
    }
}
