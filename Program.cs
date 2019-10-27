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
						if (Path.GetExtension(file).ToLower().Contains("heic"))
							ConvertImage(file, exportPath);
						Console.WriteLine(--fileLeft + " files left");
					}
				}
			}
			Console.WriteLine("Press AnyKey to continue");
			Console.ReadKey();
		}

		static void ConvertImage(string heicImagePath, string exportPath)
		{
			string exportFilePath = Path.Combine(exportPath, Path.GetFileNameWithoutExtension(Path.GetFileName(heicImagePath))) + ".jpg";
			Console.Write("Converting " + exportFilePath + "...");
			using (MagickImage image = new MagickImage(heicImagePath))
			{
				image.Write(exportFilePath);
				Console.WriteLine("Ok");
			}
		}
	}
}
