using System;

namespace Diagrammer
{
    public class MainEntry
    {
        public static void Main(string[] args)
        {
            var convert = new ConvertImageToPDF();
            convert.ConvertPngToPdf("/home/rebelinux/foto.png", "/home/rebelinux/foto.pdf");
        }

    }
}