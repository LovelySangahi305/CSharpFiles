using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
    internal class BinStream
    {
        public void Writer()
        {
            try
            {
                Console.Out.WriteLine("Preparing to Write ...");

                //Open a FileStream on the file "aboutme"
                FileStream fout = new FileStream("BinStreamWrite_Aboutme.txt", FileMode.OpenOrCreate,
                    FileAccess.Write, FileShare.ReadWrite);

                //Create a BinaryWriter from the FileStream
                BinaryWriter bw = new BinaryWriter(fout);

                //Create some arbitrary variables
                string name = "Lovely sangahi";
                int age = 23;
                double height = 5.1;
                bool single = true;
                char gender = 'F';

                //Write the values to file
                bw.Write(name);
                bw.Write(age);
                bw.Write(height);
                bw.Write(single);
                bw.Write(gender);

                //Close the file and free resources
                bw.Close();
                Console.WriteLine("Data Written!");
                Console.WriteLine();
            }

            catch (IOException e)
            {
                Console.WriteLine("An IO Exception Occurred :" + e);
            }
        }

        public void Reader()
        {
            try
            {
                Console.WriteLine("Preparing to Read ...");

                //Open a FileStream in Read mode
                FileStream fin = new FileStream("BinStreamWrite_Aboutme.txt", FileMode.Open,
                FileAccess.Read, FileShare.ReadWrite);

                //Create a BinaryReader from the FileStream
                BinaryReader br = new BinaryReader(fin);

                //Seek to the start of the file
                br.BaseStream.Seek(0, SeekOrigin.Begin);

                //Read from the file and store the values to the variables
                string name = br.ReadString();
                int age = br.ReadInt32();
                double height = br.ReadDouble();
                bool single = br.ReadBoolean();
                char gender = br.ReadChar();

                //Display the data on the console
                Console.WriteLine("Name :" + name);
                Console.WriteLine("Age :" + age);
                Console.WriteLine("Height :" + height);
                Console.WriteLine("Single? :" + single);
                Console.WriteLine("Gender M/F:" + gender);

                //Close the stream and free the resources
                br.Close();
                Console.WriteLine("Data Read!");
            }

            catch (IOException e)
            {
                Console.WriteLine("An IO Exception Occurred :" + e);
            }
        }
    }
}

        