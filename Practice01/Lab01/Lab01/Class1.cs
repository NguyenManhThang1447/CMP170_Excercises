using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student
    {
        private string studentID;
        private string fullname;
        private float averageScore;
        private string faculty;
        private string StudentID { get; set; }
        private string FullName { get; set; }
        private float AverageScore { get; set; }
        private string Faculty { get; set; }
        public Student()
        {

        }
        public Student(string id, string name, float score, string faculty)
        {
            StudentID = id;
            FullName = name;
            AverageScore = score;
            Faculty = faculty;
        }
        public void Input()
        {
            Console.Write("Enter your StudentID: ");
            StudentID = Console.ReadLine();
            Console.Write("Enter your FullName: ");
            FullName = Console.ReadLine();
            Console.Write("Enter your AveragePoint: ");
            AverageScore = float.Parse(Console.ReadLine());
            Console.Write("Enter your department: ");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("StudentID:{0} FullName:{1} Department{2} AveragePoint{3}", this.StudentID, this.FullName, this.Faculty, this.AverageScore);
        }
        static void Main(string[] args)
        {
            //Console.Write("Enter total Student List: ");
            //int N = Convert.ToInt32(Console.ReadLine());
            //Student[] arrStudents = new Student[N];
            //Console.WriteLine("\n ====Enter Student List====");
            //for (int i = 0; i < N; i++)
            //{
               // Console.WriteLine("\n - Enter Student Information {0}", i + 1);
               // arrStudents[i] = new Student();
                //arrStudents[i].Input();
            //}
            //Console.WriteLine("\n ====Export Student List====");
            //foreach (Student sv in arrStudents)
            //{
            //    sv.Show();
            //}
           // Console.ReadKey();
            List<Student> students = new List<Student>();
            students.Add(new Student("SV001", "Nguyen Van A", 4, "CNTT"));
            students.Add(new Student("SV002", "Nguyen Van B", 5, "CNTT"));
            students.Add(new Student("SV003", "Nguyen Van C", 9, "QTKD"));
            students.Add(new Student("SV004", "Nguyen Van D", 10, "CNTT"));
            students.Add(new Student("SV005", "Nguyen Van E", 6, "NHKS"));
            students.Add(new Student("SV006", "Nguyen Van F", 8, "CNTT"));
            students.Add(new Student("SV007", "Nguyen Van G", 7, "CNTT"));

            var cnttStudents = students.FindAll(x => x.Faculty == "CNTT");

            var DTBlonhon5 = students.FindAll(x => x.AverageScore >= 5);

            var DTBTANGDAN = students.OrderBy(x => x.AverageScore).ToList();

            var CAU4 = students.FindAll(x => (x.AverageScore >= 5 && x.Faculty == "CNTT"));

            var findmax = students.Max(x => x.AverageScore);
            var cnttmost = students.FindAll(x => x.AverageScore == findmax && x.Faculty == "CNTT");

            Console.WriteLine("----------Question 1---------");
            foreach (var item in cnttStudents)
            {
                Console.WriteLine(item.StudentID);
            }

            Console.WriteLine("----------Question 2---------");
            foreach (var item in DTBlonhon5)
            {
                Console.WriteLine(item.StudentID + " " + item.AverageScore);
            }

            Console.WriteLine("----------Question 3---------");
            foreach (var item in DTBTANGDAN)
            {
                Console.WriteLine(item.StudentID + " " + item.AverageScore);
            }

            Console.WriteLine("----------Question 4----------");
            foreach (var item in CAU4)
            {
                Console.WriteLine(item.StudentID);
            }

            Console.WriteLine("----------Question 5------------");
            foreach (var item in cnttmost)
            {
                Console.WriteLine(item.StudentID);
            }
        }
    }
}
