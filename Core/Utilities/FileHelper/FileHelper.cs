using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static (string filePath, string imagePath) filePath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;
            string fileName = Guid.NewGuid().ToString() + fileExtension;

            string result = $@"{Environment.CurrentDirectory + @"\wwwroot\images"}\{fileName}";


            //if (!Directory.Exists(result))
            //{
            //    Directory.CreateDirectory(result);
            //}

            return (result, $"\\images\\{fileName}");
        }
        public static string Add(IFormFile file)
        {
            if (file == null)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files\\logo.png");
                return filePath;
            }

            var result = filePath(file);
            var path = Path.GetTempFileName();

            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Move(path, result.filePath);
            return result.imagePath;
        }
        public static string Update(string path, IFormFile file)
        {
            var result = filePath(file);
            if (path.Length > 0)
            {
                using (var stream = new FileStream(result.filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }

            File.Delete(path);
            return result.imagePath;
        }

        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
    }
}
