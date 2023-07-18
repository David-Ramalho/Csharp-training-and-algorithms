using System;
using System.IO;

namespace Files
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string sourcePath = @"C:\Users\David\Documents\GIT\Csharp-training-and-algorithms\Files/File1.txt";
			string targetPath = @"C:\Users\David\Documents\GIT\Csharp-training-and-algorithms\Files/File2.txt";
			string path= @"C:\Users\David\Documents\GIT\Csharp-training-and-algorithms\Files/File1.txt";
			try
			{
				FileInfo fileInfo = new FileInfo(sourcePath);
				//fileInfo.CopyTo(targetPath);
				string[] lines = File.ReadAllLines(sourcePath);
				foreach(string line in lines)
				{
                    Console.WriteLine(line);
                }
			}
			catch (IOException e)
			{
				Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

		}
	}
}
