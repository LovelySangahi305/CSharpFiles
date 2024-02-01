using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqtoserver
{
    internal class Studentdb
    {
        linqtosqlDataContext db;

        public Studentdb()
        {
            db= new linqtosqlDataContext();
        }

        public void GetAllStudent()
        {
            List<student> stds= db.students.ToList();
            
            foreach (student s in stds)
            {
                Console.WriteLine($"Id : {s.Id} Name : {s.Name} Marks : {s.Marks}");
            }
        }

        public void GetStudentById()
        {
            Console.WriteLine("enter Id");
            int id = Convert.ToInt32(Console.ReadLine());

            student std = (from a in db.students
                         where a.Id == id
                         select a).Single();


           //Student std1 = db.Students.FirstOrDefault(s => s.Id == id);
           //Student st2 = db.Students.Where(s => s.Id == id).FirstOrDefault();

            Console.WriteLine($"Id : {std.Id} Name : {std.Name} Marks : {std.Marks}");
            
        }

        public void AddNewStudent()
        {
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Marks");
            int marks = Convert.ToInt32(Console.ReadLine());

            student newstudent = new student() { Id = id, Name = name, Marks = marks };

            db.students.InsertOnSubmit(newstudent);
            db.SubmitChanges();   
        }
        public void UpdateMarks()
        {
            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            
            student std = (from a in db.students
                           where a.Id == id
                           select a).Single();

            if(std != null)
            {
                Console.WriteLine("Enter updated Marks");
               std.Marks = Convert.ToInt32(Console.ReadLine());
                                db.SubmitChanges();

                Console.WriteLine("Updated Marks");
            }
            else
            {
                Console.WriteLine("No student with id exists");
            }

           
        }

        public void DeleteStudent()
        {

            Console.WriteLine("Enter id");
            int id = Convert.ToInt32(Console.ReadLine());

            student std = (from a in db.students
                           where a.Id == id
                           select a).Single();

            if (std != null)
            {
                db.students.DeleteOnSubmit(std);
                db.SubmitChanges();
                Console.WriteLine("Student deleted sucessfully");
            }
            else
            {
                Console.WriteLine("No student with id exists");
            }
        }
        }
}

