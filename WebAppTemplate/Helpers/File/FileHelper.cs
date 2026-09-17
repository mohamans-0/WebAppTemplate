using Microsoft.AspNetCore.Hosting;
using System.Linq;

namespace WebAppTemplate.Helpers.File
{
    public class FileHelper : iFileHelper
    {
        IWebHostEnvironment webHostEnvironment;

        public FileHelper(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public string SaveImage(IFormFile file, string FolderName, string oldImageName)
        {
            var finalImageName = "";

            var allowedExt = new List<string>
            {
                ".jpg",".png",".jpeg",".fig" , ".webp"
            };


            var File = file;
            if (File != null)
            {

                var rootPath = Path.Combine(webHostEnvironment.WebRootPath, FolderName);
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }
                FileInfo fileInfo = new FileInfo(File.FileName);


                if (  allowedExt.Contains(fileInfo.Extension.ToLower())  /*fileInfo.Extension == ".jpg" || fileInfo.Extension == ".png" || fileInfo.Extension == ".jpeg"*/)
                {
                    // hackers ==> .vbs
                    var newName = Guid.NewGuid() + "_" + File.FileName;
                    var fullPath = Path.Combine(rootPath, newName);
                    finalImageName = newName;
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        File.CopyTo(stream);
                    }
                }

                else
                {

                    finalImageName = "Error";
                }
            }
            else
            {
                finalImageName = oldImageName;
            }
                return finalImageName;
        }

        public string SavePDF(IFormFile file, string FolderName, string? oldImageName)
        {
            var finalImageName = "";

            var allowedExt = new List<string>
            {
                ".pdf",".word",".doc",".docx"
            };


            var File = file;
            if (File != null)
            {

                var rootPath = Path.Combine(webHostEnvironment.WebRootPath, FolderName);
                if (!Directory.Exists(rootPath))
                {
                    Directory.CreateDirectory(rootPath);
                }
                FileInfo fileInfo = new FileInfo(File.FileName);


                if (allowedExt.Contains(fileInfo.Extension)  /*fileInfo.Extension == ".jpg" || fileInfo.Extension == ".png" || fileInfo.Extension == ".jpeg"*/)
                {
                    // hackers ==> .vbs
                    var newName = Guid.NewGuid() + "_" + File.FileName;
                    var fullPath = Path.Combine(rootPath, newName);
                    finalImageName = newName;
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        File.CopyTo(stream);
                    }
                }

                else
                {

                    finalImageName = "Error";
                }
            }
            else
            {
                finalImageName = oldImageName;
            }
            return finalImageName;
        }
    }
}
