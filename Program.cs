using ImageMagick;
using System;
using System.IO;

namespace HEICtoJPG
{
	class Program
	{
		static void Main(string[] args)
		{
			int fileLeft;
			foreach (var arg in args)
			{
				Console.WriteLine("Checking directory: " + arg);
				if (Directory.Exists(arg))
				{
					string exportPath = Path.Combine(arg, "jpg");
					if (!Directory.Exists(exportPath))
						Directory.CreateDirectory(exportPath);
					var filesInFolder = Directory.GetFiles(arg);
					fileLeft = filesInFolder.Length;
					foreach (var file in filesInFolder)
					{
						ConvertImage(file, exportPath);
						Console.WriteLine(--fileLeft + " files left");
					}
				}
			}
			Console.WriteLine("Press AnyKey to continue");
			Console.ReadKey();
		}

		static void ConvertImage(string fileToConvert, string exportPath)
		{
			string exportFilePath = Path.Combine(exportPath, Path.GetFileNameWithoutExtension(Path.GetFileName(fileToConvert))) + ".jpg";
			if (File.Exists(exportFilePath))
			{
				Console.WriteLine("File already exist " + exportFilePath);
				return;
			}
			string imageExtension = Path.GetExtension(fileToConvert).ToLower();
			if (imageExtension.Contains("heic") || imageExtension.Contains("png"))
			{
				if (File.Exists(exportFilePath))
					Console.WriteLine("File already exist " + exportFilePath);
				Console.Write("Converting " + fileToConvert + "...");
				using (MagickImage image = new MagickImage(fileToConvert))
				{
					image.Write(exportFilePath);
					Console.WriteLine("Ok");
				}
			}
			else if (imageExtension.Contains("jpg"))
				File.Copy(fileToConvert, exportFilePath);
		}
	}
}
