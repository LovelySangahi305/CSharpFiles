using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    internal class Openfile
    {
        FileStream fs;
        string filename;
        string path;

        public void GetDetails()
        {
            Console.WriteLine("Enter the file name whose content you want to see : ");
            filename = Console.ReadLine();
            Console.WriteLine("Enter the path of file  : ");
            path = Console.ReadLine();
        }
        public Openfile()
        {
            GetDetails();
           // fs = new FileStream($"{filename}.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None");
            //fs = new FileStream(@"D:\day3\StudentsList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            fs = new FileStream($"{path}/{filename}.cs", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            //fs = new FileStream("D:\\day3\\StudentsList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        }
        public void ReadFromFile()
        {
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string result = sr.ReadToEnd();
            Console.WriteLine($"{result}");
        }
    }
}
