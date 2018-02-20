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
    /// Interaction logic for ClassControl.xaml
    /// </summary>
    public partial class ClassControl : UserControl
    {
        public ClassControl()
        {
            InitializeComponent();
        }

    }

    public class CurrentClass
    {
        String name, semester, other;
        int classSize;
        bool[] attendance;
        Date day;
        List<Image> picture = new List<Image>; 

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

        public void UploadImage(Image image)
        {
            picture.Add(image);
        }

        public void RemoveImage(Image i)
        {
            picture.Remove(i);

        }

    }

    public class OndDate
    {
        Dictionary<Date, Image[]> datePictures = new Dictionary<Date, Image[]>();
        Dictionary<Student, Boolean> StudentAttendance = new Dictionary<Student, Boolean>();
    }
            

}
