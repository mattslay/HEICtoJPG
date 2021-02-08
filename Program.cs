using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using System.IO;
using System.Threading;

namespace HEICtoJPG
{
	class Program
	{
		//public static string imageType;
		static void Main(string[] args)
		{
			int fileLeft = 0;
			string sourcePath = "", targetPath = "";
			string[] filesInFolder;
			bool deleteFlag = false;
			string sourceType = ".heic";
			string outputType = ".jpg";

			sourcePath = Directory.GetCurrentDirectory();
			targetPath = sourcePath;

			for (int x = 0; x < args.Length; x++)
			{
				if (args[x].ToLower().Contains("/source"))
					sourcePath = GetPath(args[x]);
				if (args[x].ToLower().Contains("/target"))
					targetPath = GetPath(args[x]);
				if (args[x].ToLower() == "/delete")
					deleteFlag = true;
				if (args[x].ToLower() == "/png")
					outputType = ".png";
			}

			filesInFolder = Directory.GetFiles(sourcePath, "*" + sourceType);

			foreach (var file in filesInFolder)
			{
				Console.WriteLine(file);
				ConvertImage(file, targetPath, outputType, deleteFlag);
			}
		}

		
		static void ConvertImage(string fileToConvert, string exportPath, string convertTo, bool deleteOriginalFile = false)
		{
			string exportFilePath = Path.Combine(exportPath, Path.GetFileNameWithoutExtension(Path.GetFileName(fileToConvert))) + convertTo;
			string outFilename = Path.GetFileName(exportFilePath);
			string ext = Path.GetExtension(outFilename);
			string imageExtension = Path.GetExtension(fileToConvert).ToLower();
			string inFilename = Path.GetFileName(fileToConvert);

			if (File.Exists(exportFilePath))
			{
				Console.WriteLine("Skipped file  " + inFilename + " because it has already been converted.");
				return;
			}

			if (File.Exists(fileToConvert))
			{
				Console.Write("Processing Item " + inFilename + "...");

				using (MagickImage image = new MagickImage(File.ReadAllBytes(fileToConvert)))
				{
					image.Write(exportFilePath);
					Console.WriteLine("Ok");
				}

				if (deleteOriginalFile && File.Exists(exportFilePath))
				{
					File.Delete(fileToConvert);
					Console.WriteLine("  ... deleted source file.");
				}
			}

		}
		static string GetPath(string str)
		{

			string[] ptr = str.Split(new char[] { '=' });
			return ptr[1];

		}
	}
}
