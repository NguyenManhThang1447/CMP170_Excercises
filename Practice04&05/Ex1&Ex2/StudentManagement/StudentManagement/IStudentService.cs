using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static StudentManagement.SearchStudentViewModel;

namespace StudentManagement
{
    public interface IStudentService
    {
        IList<Student> SearchStudent(string keyword, string hutechClass);
        Student LoadStudentById(long id);
        void UpdateOrCreateStudent(Student student);
        void DeleteStudentById(int id);
    }
}
