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

        private void LoadAutoAttendanceButton(object sender, RoutedEventArgs e)
        {
            OneWindow win2 = new OneWindow();
            win2.Show();
            this.Close();
        }

        private void HandleExitButton(object sender, RoutedEventArgs e)
        {
            //exit
        }

        private void HandleOptionsButton(object sender, RoutedEventArgs e)
        {
            //load options menu
        }

        private void HandleHelpButton(object sender, RoutedEventArgs e)
        {
            // load help menu
        }
    }

}
