using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;

public class ImageProcessor
{
    public static int GetImageWidthFromFile(string imagePath)
    {
        try
        {
            using var image = Image.Load(imagePath);
            return image.Width;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image from file: {ex.Message}");
            return -1; // Or throw a more specific exception
        }
    }
    public static int GetImageHeightFromFile(string imagePath)
    {
        try
        {
            using var image = Image.Load(imagePath);
            return image.Height;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image from file: {ex.Message}");
            return -1; // Or throw a more specific exception
        }
    }

    public static SixLabors.ImageSharp.Image? GetImagePropertiesFromFile(string imagePath)
    {
        try
        {
            using var image = Image.Load(imagePath);
            return image;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image: {ex.Message}");
            return null; // Or throw a more specific exception
        }
    }
    public static int GetImageWidthFromBase64(string base64String)
    {
        try
        {
            using var image = Image.Load(Convert.FromBase64String(base64String));
            return image.Width;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image from Base64: {ex.Message}");
            return -1; // Or throw a more specific exception
        }
    }
        public static int GetImageHeightFromBase64(string base64String)
    {
        try
        {
            using var image = Image.Load(Convert.FromBase64String(base64String));
            return image.Height;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image from Base64: {ex.Message}");
            return -1; // Or throw a more specific exception
        }
    }

    public static bool RotateImageFromFile(string imagePath, string outputPath, int angle)
    {
        try
        {
            using var image = Image.Load(imagePath);
            image.Mutate(x => x.Rotate(angle));
            image.Save(outputPath);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image from file: {ex.Message}");
            return false; // Or throw a more specific exception
        }
    }

    public static bool ResizeImageFromFile(string imagePath, int newWidth, int newHeight, string outputPath)
    {
        try
        {
            using var image = Image.Load(imagePath);
            image.Mutate(x => x.Resize(newWidth, newHeight));
            image.Save(outputPath);
            image.Dispose();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading image from file: {ex.Message}");
            return false; // Or throw a more specific exception
        }
    }

    public static void Main(string[] args)
    {

    }
}