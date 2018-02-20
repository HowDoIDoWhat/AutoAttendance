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
    /// Interaction logic for StudentControl.xaml
    /// </summary>
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
        }

        public void LoadStudent (CurrentStudent l)
        {
            // load "name-id.txt"
            // load "name-id.jpg"
            // load name:id:year:other:attendance:profile
        }
        public void SaveStudent(CurrentStudent s)
        {
            // save "name-id.txt"
            // save "name-id.jpg"
            // save name:id:year:other:attendance:profile
        }

        public void NewProfile(CurrentStudent s)
        {
            // selects from faces generated from class
            // todo
        }
    }

    public class CurrentStudent
    {
        String name, studentID, year, other;
        double attendance;
        Image profile;

        private void Create(String name, String studentID, String year, String other)
        {
            if (name == null || studentID == null || year == null || other == null)
            this.name = name;
            this.studentID = studentID;
            this.year = year;
            this.other = other;

        }
        private void ChangeName(String s)
        {
            this.name = s;
        }

        private void ChangeID(String s)
        {
            this.studentID = s;
        }

        private void ChangeYear(String s)
        {
            this.year = s;
        }

        private void ChangeOther(String s)
        {
            this.other = s;
        }

        private void ChangeProfile(Image i)
        {
            this.profile = i;
        }

    }
}
