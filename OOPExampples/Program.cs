using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExampples
{
    class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public bool DepositPaid { get; set; }
        public DateTime Dob { get; set; }
        public int AttendancePercent { get; set; }
        public ConsoleColor HairColour { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            for (int i = 0; i < 4; i++)
            {
                Student aStudent = new Student();
                string teststr = "hello";
                aStudent.FirstName = "Geoff-" + i;
                studentList.Add(aStudent);
                teststr = "bye";
            }


            foreach (var item in studentList)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }
}
