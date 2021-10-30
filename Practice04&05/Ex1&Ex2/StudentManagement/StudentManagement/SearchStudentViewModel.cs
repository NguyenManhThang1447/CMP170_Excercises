using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Text.Json.Serialization;
using static StudentManagement.IStudentService;
using HelloWpfApp;

namespace StudentManagement
{
    public class SearchStudentViewModel : BaseViewModel
    {
        public class Student
        {
            public int studentId { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string Class { get; set; }
        }
        private string m_searchKeyword;
        public string SearchKeyword
        {
            get => m_searchKeyword;
            set
            {
                m_searchKeyword = value;
                OnPropertyChanged(nameof(SearchKeyword));
            }
        }
        private string m_selectedClass;
        public string SelectedClass
        {
            get => m_selectedClass;
            set
            {
                m_selectedClass = value;
                OnPropertyChanged(nameof(SelectedClass));
            }
        }
        private Student m_selectedStudent;
        private object m_studentSrv;

        public Student SelectedStudent
        {
            get => m_selectedStudent;
            set
            {
                m_selectedStudent = value;
                OnPropertyChanged(nameof(SelectedStudent));
            }
        }

        public void DoOpenDetail()
        {
            var StudentDetailViewModel1 = new StudentDetailViewModel(SelectedStudent);
            Window1 window1 = new Window1();
            window1.DataContext = StudentDetailViewModel1;
            window1.ShowDialog();
        }
        public void DoReset()
        {
            Students.Clear();
            SearchKeyword = null;
            SelectedClass = null;
        }
        private void DoSearch()
        {
            Students.Clear();
            var result = m_studentsSrv.SearchStudent(SearchKeyword, SelectedClass);
            foreach (var s in result)
            {
                Students.Add(s);
            }
        }

        public ObservableCollection<Student> Students { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand OpenDetailCommand { get; set; }
        
        private IStudentService m_studentsSrv;

        public SearchStudentViewModel()
        {
            m_studentsSrv = new StudentServiceWithEF();
            Students = new ObservableCollection<Student>(m_studentsSrv.SearchStudent(string.Empty, string.Empty));
            OpenDetailCommand = new ConditionalCommand(x => DoOpenDetail());
            SearchCommand = new ConditionalCommand(x => DoSearch());
            ResetCommand = new ConditionalCommand(x => DoReset());

        }
    }
}