using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sbidu.Helper
{
    public interface IFileManager
    {
        string Upload(IFormFile file, string path = "wwwroot/uploads");
        void Delete(string filename, string deletePath = "wwwroot/uploads");
    }

    public class FileManager : IFileManager
    {
        public void Delete(string filename, string deletePath = "wwwroot/uploads")
        {
            var file = Path.Combine(Directory.GetCurrentDirectory(), deletePath, filename);

            if (!File.Exists(file))
            {
                throw new FileNotFoundException();
            }

            File.Delete(file);
        }

        public string Upload(IFormFile file, string path = "wwwroot/uploads")
        {
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmssff") + Path.GetExtension(file.FileName);

            var uploadPath = Path.Combine(Directory.GetCurrentDirectory(), path, fileName);

            using (var stream = new FileStream(uploadPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return fileName;
        }
    }
}
