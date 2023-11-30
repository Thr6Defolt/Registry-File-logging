using System.IO;

namespace Registry___File_logging
{
    internal class Program
    {
        public const string directoryPath = @"C:\test";
        public const string fileName = "Sample.txt";
        public static string filePath = Path.Combine(directoryPath, fileName);

        static void Main(string[] args)
        {
            DirectoryInfo myDirectory = new DirectoryInfo(directoryPath);
            FileInfo myFile = new FileInfo(filePath);
            if (!myDirectory.Exists)
            {
                myDirectory.Create();
                Console.WriteLine("Directory created successfully.");
            }

            if (!myFile.Exists)
            {
                using (File.Create(filePath))
                {
                    Console.WriteLine("File created successfully.");
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(DateTime.Now);
                }
                Console.WriteLine("File already exists.");
            }
        }
    }
}