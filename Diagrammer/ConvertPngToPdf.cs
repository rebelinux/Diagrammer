using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using System.IO;

namespace Diagrammer
{
    public class DiaConvertImageToPDF
    {
        public static bool ConvertPngToPdf(string pngFilePath, string pdfFilePath)
        {
            try
            {
                // Create a new PDF document
                using var pdfWriter = new PdfWriter(pdfFilePath);
                using var pdfDocument = new PdfDocument(pdfWriter);
                var document = new Document(pdfDocument);

                // Load the PNG image
                ImageData imageData = ImageDataFactory.Create(pngFilePath);
                Image image = new(imageData);

                // Adjust image size and position
                image.SetAutoScaleWidth(true); // Scale image to fit page width
                image.SetFixedPosition(0, 0); // Set image position

                // Add the image to the document
                document.Add(image);

                // Close the document
                document.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating pdf from image: {ex.Message}");
                return false; // Or throw a more specific exception
            }
        }
    }
}