using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
    internal class Directoryinfo
    {
        public void CreateDirectory()
        {
            String path = @"C:\Installers\MyDirectory";
            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }
        }

        public void CreateSubDirectory()
        {
            String path = @"C:\Installers\MyDirectory";
            DirectoryInfo fl = new DirectoryInfo(path);
            DirectoryInfo dis = fl.CreateSubdirectory("MySubDirectory");
            {
                Console.WriteLine("Directory has been created");
            }


        }

        public void MoveToDirectory()
        {
            String path = @"C:\Installers\MyDirectory";
            string path1 = @"C:\Installers\NewDirectory";
            DirectoryInfo f1 = new DirectoryInfo(path);
            DirectoryInfo f2 = new DirectoryInfo(path1);
            f1.MoveTo(path1);
            {
                Console.WriteLine("Directory has been Moved");
            }
        }

        public void DeleteDirectory()
        {
            string path = @"C:\Installers\NewDirectory";
            DirectoryInfo f1 = new DirectoryInfo(path);
            f1.Delete();
            {
                Console.WriteLine("Directory has been deleted");
            }
        }
        public void GetSubDirectory()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(@"C:\Users\LSANGAHI\Desktop\csharp\day4\");

                DirectoryInfo[] dir1 = di.GetDirectories();
                foreach (var a in dir1)
                {
                    Console.WriteLine($"{a.Name}");
                }
                Console.WriteLine("The number of directories containing is {0}.", dir1.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        public void GetFilesFromDirectory()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\LSANGAHI\Desktop\csharp\day4");
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo diNext in dirs)
            {
                Console.WriteLine("The number of files in {0} is {1}", diNext, diNext.GetFiles().Length);
            }
        }

        public void GetDirectoryDetails()
        {
            DirectoryInfo fi = new DirectoryInfo(@"C:\Users\LSANGAHI\Desktop\csharp\day4");
            Console.WriteLine("Directory name is {0} ", fi.Name);
            Console.WriteLine("Directory creation time is {0} ", fi.CreationTime.ToLongTimeString());
            Console.WriteLine("Directory Lastaccesstime is {0} ", fi.LastAccessTime.ToLongDateString());
            Console.WriteLine("Directory exist is: ", fi.Exists);
            Console.WriteLine("Directory LastWriteTime is {0} ", fi.LastWriteTime);
            Console.WriteLine("Directory root is {0} ", fi.Root);
        }
    }
}
