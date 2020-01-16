using System;
using System.Linq;
using System.IO;

namespace Problem_4._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copyMe-copy.png";
            using (var streamReader = new FileStream(picPath,FileMode.OpenOrCreate))
            {
                using (var streamWriter = new FileStream(picCopyPath,FileMode.Create))
                {
                    byte[] byteArray = new byte[4096];
                    while (true)
                    {
                        int size = streamReader.Read(byteArray, 0, byteArray.Length);
                        if (size == 0)
                        {
                            break;
                        }
                        streamWriter.Write(byteArray, 0, size);
                    }

                }
                
            }
        }
    }
}
