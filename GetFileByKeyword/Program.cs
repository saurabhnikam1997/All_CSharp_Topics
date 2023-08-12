using System;
using System.IO;
using System.Linq;

namespace GetFileByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string path = @"C:\Build\RC_2.06.1_Latest\Alstom\UHMI\ProjectsISM";


            string dllFileName = "*Playgrounddd.dll";

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] files = directoryInfo.GetFiles(dllFileName, SearchOption.TopDirectoryOnly);

            if (files.Length > 0)
            {
                // Found the DLL file. You can access or process it here.
                string fileName = files[0].Name;
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            }
            else
            {
                Console.WriteLine("The DLL file was not found in the specified location.");
            }
        }
    }
}
