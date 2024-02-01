using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
    internal class BinarySerializable
    {
        [Serializable]
        internal class Employee
        {
            public int EmpId { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
        }
        public void SerializeEmployee()
        {
            FileStream fs = new FileStream("EmployeeDetails.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);


            Employee emp = new Employee() { EmpId = 1, Name = "Samatha", Designation = "HOP" };

            //BinaryFormatter binaryFormatter = new BinaryFormatter();

            //binaryFormatter.Serialize(fs, emp);

            //Console.WriteLine("Employee stored into file");

        }

        public void DeserializeEmployee()
        {
            FileStream fs2 = new FileStream("EmployeeDetails.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);

            Employee emp2 = new Employee();

            //BinaryFormatter binaryFormatter2 = new BinaryFormatter();
            //emp2 = (Employee)binaryFormatter2.Deserialize(fs2);
            //Console.WriteLine($"{emp2.EmpId} {emp2.Name} {emp2.Designation}");

        }
    }
}
