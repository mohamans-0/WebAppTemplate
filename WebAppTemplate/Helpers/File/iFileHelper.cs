namespace WebAppTemplate.Helpers.File
{
    public interface iFileHelper
    {
        string SaveImage(IFormFile file,string FolderName , string? oldImageName);
        // string SaveVideo(IFormFile file,string FolderName , string? oldImageName);
        string SavePDF(IFormFile file,string FolderName , string? oldImageName);
    }
}
