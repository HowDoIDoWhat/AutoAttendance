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
using System.Windows.Shapes;

namespace AutoAttendance
{
    /// <summary>
    /// Interaction logic for ClassInformation.xaml
    /// </summary>
    public partial class ClassInformation : Window
    {
        public ClassInformation(Course c, Boolean e)
        {
            Course ActiveCourse = c;
            InitializeComponent();
            
            if (e == true)
            {
                LoadClass();
                SaveClassButton.Visibility = Visibility.Visible;
                AddClassButton.Visibility = Visibility.Hidden;
            }

        }

        String ClassName, CRN,  Semester, ClassSize;
        DateTime StartDate, EndDate;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Saves to file
        }

        Boolean Monday, Tuesday, Wednseday, Thursday, Friday;

        public void LoadClass()
        {
            //load file from ("/Classes/" + ActiveCourse.CRN + "/info.txt");
            //parse file
            ClassName = "s";
            CRN = "s";
            Semester = "s";
            ClassSize = "s";
            StartDate = DateTime.Parse("Jan 1, 2000");
            EndDate = DateTime.Parse("Dec 31, 2000");
            Monday = false;
            Tuesday = true;
            Wednseday = false;
            Thursday = true;
            Friday = false;

            ClassNameTextBox.Text = ClassName;
            ClassCRNTextBox.Text = CRN;
            ClassSemesterTextBox.Text = Semester;
            ClassNumberOfStudentsTextBox.Text = ClassSize;
            StartDateDatePicker.SelectedDate = StartDate;
            EndDateDatePicker.SelectedDate = EndDate;
            MondayCheckBox.IsChecked = Monday;
            TuesdayCheckBox.IsChecked = Tuesday;
            WednesdayCheckBox.IsChecked = Wednseday;
            ThursdayCheckBox.IsChecked = Thursday;
            FridayCheckBox.IsChecked = Friday;

            //close file
        }

        public void SaveClass()
        {
            //format name:CRN:Semester:Size:Start:End:M:T:W:R:F
            //save -> (CourseName + ":" + CRN + ":" + Semester + ":" + ClassSize + ":" + StartDate.toString() + ":" + EndDate.toString() + ":" + Monday + ":" + Tuesday + ":" + Wednesday + ":" + Thursday + ":" + Friday)

        }


    }
}
