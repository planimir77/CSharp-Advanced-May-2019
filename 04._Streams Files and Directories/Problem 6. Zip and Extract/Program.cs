using System;
using System.IO;
using System.IO.Compression;

namespace Problem_6._Zip_and_Extract
{
    class Program
    { 
        static void Main(string[] args)
        {
            var zipFilePath = @"../../myZip.zip";
            var sourse = @"copyMe.png";
            var file = @"../";
            // Zip it in a directory
            using (var archive = ZipFile.Open(zipFilePath, ZipArchiveMode.Create))
            {
                                         //(sourse, Path.GetFileName(sourse))
                archive.CreateEntryFromFile(sourse, "extracted.png");
            }

            // Extract the zip file in another directory
            using (var archive = ZipFile.Open(zipFilePath, ZipArchiveMode.Update))
            {
                archive.ExtractToDirectory(file);
            }
        }
    }
}
