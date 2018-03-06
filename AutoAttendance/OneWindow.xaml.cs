using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace AutoAttendance
{
    // <summary>
    // Interaction logic for OneWindow.xaml
    // </summary>
    //

    public partial class OneWindow : Window
    {

        Boolean editing;
        public OneWindow()
        {
            InitializeComponent();
        }

        Course CurrentCourse = new Course();
        Student CurrentStudent = new Student();
        Date CurrentDate = new Date();
        Image[] DateImages;
        Image CurrentImage = new Image();

        private void ReturnToMainMenuButton(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void DateChanged(object sender, RoutedEventArgs e)
        {
            //save current day
            //load new day
            CurrentDateLabel.Content = "Images for " + DateSelector.SelectedDate.Value.Date.ToShortDateString();
        }

        private void HandleAddPhotoButton(object sender, RoutedEventArgs e)
        {
            //browse for image
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
               // Image FromStream(dlg.OpenFile);
               // CurrentCourse.UploadImage(image);
            }

            

        }

        private void HandleRemoveImageButton(object sender, RoutedEventArgs e)
        {
            CurrentCourse.RemoveImage(CurrentImage);
        }

        private void HandleCountAttendanceButton(object sender, RoutedEventArgs e)
        {
            //for date image array do facial recognition
            //count of faces
            //facial recognition
            //assign present to date attendance array
            //disaply unrecognized/nonpresent
        }

        private void HandleEditAttendacneButton(object sender, RoutedEventArgs e)
        {
            //load menu with data from date attendace array
            //display all students w/ present attribute
            //allow editing-save
        }

        private void HandleAddClassButton(object sender, RoutedEventArgs e)
        {
            ClassInformation win3 = new ClassInformation(CurrentCourse, false);
            win3.Show();
        }

        private void HandleRemoveClassButton(object sender, RoutedEventArgs e)
        {
            //select class for deletion
            //remove or delete
            //
        }

        private void HandleEditClassButton(object sender, RoutedEventArgs e)
        {
            ClassInformation win3 = new ClassInformation(CurrentCourse, true);
            win3.Show();
            /*
            if (EditClassButton.Content.Equals("Edit"))
            {
                ClassNameTextBox.IsEnabled = true;
                ClassCRNTextBox.IsEnabled = true;
                ClassSemesterTextBox.IsEnabled = true;
                ClassSizeTextBox.IsEnabled = true;
                EditClassButton.Content = "Save";
            }
            else
            {
                ClassNameTextBox.IsEnabled = false;
                ClassCRNTextBox.IsEnabled = false;
                ClassSemesterTextBox.IsEnabled = false;
                ClassSizeTextBox.IsEnabled = false;
                EditClassButton.Content = "Edit";
            }
            */
        }

        private void HandleManualEntryButton(object sender, RoutedEventArgs e)
        {

        }

        private void HandleChangeProfileButton(object sender, RoutedEventArgs e)
        {

        }

        private void HandleEditStudentInformationButton(object sender, RoutedEventArgs e)
        {
            if (EditStudentButton.Content.Equals("Edit"))
            {
                StudentNameTextBox.IsEnabled = true;
                StudentIDTextBox.IsEnabled = true;
                StudentYearTextBox.IsEnabled = true;
                EditStudentButton.Content = "Save";
            }
            else
            {
                StudentNameTextBox.IsEnabled = false;
                StudentIDTextBox.IsEnabled = false;
                StudentYearTextBox.IsEnabled = false;
                EditStudentButton.Content = "Edit";
            }
        }
    }

    public class Student
    {
        public String studentName, studentID, year, Course, FaceID;
        public int studentNumber;
        double present;
        Image profile;
        

        private void ChangeName(String s)
        {
            this.studentName = s;
        }

        private void ChangeID(String s)
        {
            this.studentID = s;
        }

        private void ChangeYear(String s)
        {
            this.year = s;
        }

        private void ChangeProfile(Image i)
        {
            this.profile = i;
        }

    }

    public class Course
    {
        String name, crn, semester, other;
        int classSize;
        List<Student> ClassList;
        bool[] attendance;
        Date day;
        List<Image> DatePicutres = new List<Image>();

        public void ChangeName(String name)
        {
            this.name = name;
        }

        public void ChangeSemester(String semester)
        {
            this.semester = semester;
        }

        public void ChangeOther(String other)
        {
            this.other = other;
        }

        public void ChangeDate(Date day)
        {
            this.day = day;
        }

        public void UploadImage(Image i)
        {
            DatePicutres.Add(i);
        }

        public void RemoveImage(Image i)
        {
            DatePicutres.Remove(i);
        }

        public void Addstudent(string name, string id, string year)
        {
            Student newStudent = new Student();
            newStudent.studentName = name;
            newStudent.studentID = id;
            newStudent.year = year;
            newStudent.studentNumber = ClassList.Count + 1;
            newStudent.Course = this.crn;
            ClassList.Insert(newStudent.studentNumber, newStudent);
            classSize++;
        }

        public void RemoveStudent(Student SelectedStudent)
        {
            ClassList.Remove(SelectedStudent);
            classSize--;
        }


    }

    public class Date
    {

    }
}
