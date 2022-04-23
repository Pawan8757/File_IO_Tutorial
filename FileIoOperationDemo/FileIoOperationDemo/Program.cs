using System;
using System.IO;

namespace FileTutorial
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tutorial going on File Operation");
            Console.WriteLine(" \n \n");
            string path = @"C:\Users\DELL\Desktop\Fellowship_Internship\FileIoOperationDemo\FileIoOperationDemo\Intro.txt.txt";
            //ReadLineByLine( path);
           // ReadAtOnce(path);
            //CopyFile(path);
           // DeleteFile(path);
           // ReadingDataUsingStreamReader(path);
            WrittingDataUsingStreamReader(path);
            Console.ReadLine();
            


        }
        
        public static bool FileExist(string path)
        {
            
            
            if(File.Exists(path))
            {
                Console.WriteLine("File Exist");
                return true;
            }
            else
            {
                Console.WriteLine("File not exist");
                return false;
            }
        }
        public static void ReadLineByLine(string path)
        {
            if(File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
        }
        
        public static void ReadAtOnce(string path)
        {
            if(File.Exists(path))
            {
                string lines = File.ReadAllText(path);
                Console.WriteLine(lines);
            }
        }
 
        public static void CopyFile(string path)
        {
            string distination = @"C:\Users\DELL\Desktop\Fellowship_Internship\FileIoOperationDemo\FileIoOperationDemo\Duplicate.txt";
            if (File.Exists(path))
            {
                File.Copy(path, distination);
            }
        }
        public static void DeleteFile(string path)
        {
            string distination = @"C:\Users\DELL\Desktop\Fellowship_Internship\FileIoOperationDemo\FileIoOperationDemo\Duplicate.txt";
            if(File.Exists(distination))
            {
                File.Delete(distination);
            }
        }
        public static void ReadingDataUsingStreamReader(string path)
        {
            StreamReader sr=File.OpenText(path);
            string line = "";
           while ((line=sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void WrittingDataUsingStreamReader(string path)
        {
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine("");
            sw.WriteLine("Practise makes man perfect");
            sw.Close();
            ReadingDataUsingStreamReader(path);
        }
    }
}