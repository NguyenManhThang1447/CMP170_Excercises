using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using static Ex4_Topic6.IComparable;
using static Ex4_Topic6.IComparer;

namespace Ex4_Topic6
{

    public class IComparable
    {
        public class Student : IComparable<Student>
        {


            public string StudentID { get; set; }
            public string FullName { get; set; }


            public Student()
            {
            }
            public Student(string id, string name)
            {
                StudentID = id;
                FullName = name;
            }

            public int CompareTo(Student other)
            {
                return this.StudentID.CompareTo(other.StudentID);
            }
        }


    }
    public class IComparer
    {
        public class SortPersonByName : IComparer<Student>
        {
            public int Compare([AllowNull] Student x, [AllowNull] Student y)
            {
                return x.FullName.CompareTo(y.FullName);
            }
        }
    }

    public class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<Student> ListStudents = new List<Student>();
            ListStudents.Add(new Student("1911060001", "Nguyễn Mạnh A"));
            ListStudents.Add(new Student("1911060002", "Nguyễn Mạnh B"));
            ListStudents.Add(new Student("1911060003", "Nguyễn Mạnh C"));
            ListStudents.Add(new Student("1911060004", "Nguyễn Mạnh D"));
            ListStudents.Add(new Student("1911060005", "Nguyễn Mạnh E"));
            ListStudents.Add(new Student("1911060006", "Nguyễn Mạnh F"));
            ListStudents.Add(new Student("1911060007", "Nguyễn Mạnh G"));
            ListStudents.Add(new Student("1911060008", "Nguyễn Mạnh H"));

            ListStudents.Sort();
            Console.WriteLine("Using IComparable");
            foreach (Student student in ListStudents)
            {
                Console.WriteLine("Name: {0}, ID: {1}", student.FullName, student.StudentID);

            }
            Console.WriteLine("");
            Console.WriteLine("Using IComparer");
            ListStudents.Sort(new SortPersonByName());
            foreach (Student student in ListStudents)
            {
                Console.WriteLine("Name: {0}, ID: {1}", student.FullName, student.StudentID);

            }
        }
    }
}