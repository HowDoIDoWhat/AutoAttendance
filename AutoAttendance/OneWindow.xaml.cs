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
    /// Interaction logic for OneWindow.xaml
    /// </summary>
    public partial class OneWindow : Window
    {
        public OneWindow()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.testCC.Content = new testControl.testControl();
        }
    }
}
