using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoAttendance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    }

    public class Class
    {
        String className, classSemester;
        int classSize;
        
        public void AddStudent()
        {
            //todo
        }

        public void RemoveStudent()
        {
            //todo
        }

        public void LoadClass()
        {
            //todo
        }

        public void SaveClass()
        {
            //todo
        }

        public void EditClass()
        {
            // todo
        }
    }

    public class Student
    { 
        String sutdentName, year;
        int[] attedance;
        Image profile;
        Image[] pictureList;

        public void AddImage()
        {
            // todo
        }

        public void RemoveImage()
        {
            // todo
        }

        public void SetProfile()
        {
            // todo
        }

    }

    public class Date
    {
        String Day;
        int[] Attednance;
        Image[] today;

        public void UploadImage()
        {
            //todo
        }

        public void DeleteImage()
        {
            //todo
        }

    }

    public class HandleImages
    {
        public void UploadImage()
        {
            // todo
        }

        public void GetImage()
        {
            // todo
        }

        public void DeleteImage()
        {
            // todo
        }

    }

}
