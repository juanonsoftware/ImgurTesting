using Rabbit.Net.Imgur;
using System;
using System.IO;

namespace ImgurTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var uploader = new ImgurUploader();
            var result = uploader.Upload("fb39e7076e0e8cd",
                  new ImageData(File.ReadAllBytes(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg"))
                  {
                      Title = "Testing",
                      Description = "A Testing DESC"
                  });

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
