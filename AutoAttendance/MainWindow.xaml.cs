﻿using System;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OneWindow win2 = new OneWindow();
            win2.Show();
            this.Close();
        }


    }



    public class Class
    {
        String className, classSemester;
        int classSize = 0;
        Student[] Roster;
        
        public void AddStudent(Student s)
        {
            Roster[classSize] = s;
            this.classSize++;
        }

        public void RemoveStudent(Student s)
        {
            
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
        String name, year;
        double gpa, attendance;
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

        public void DeleteProfile()
        {
            this. = null;
        }

        public void UpdateInfo(string info, string data)
            // info: name, year, gpa
        {
            if (info == "name")
            {
                this.name = data;
            }
            
            if (info == "year")
            {
                this.year = data;
            }

            if (info == "gpa")
            {
                this.gpa = Convert.ToDouble(data);
            }
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
