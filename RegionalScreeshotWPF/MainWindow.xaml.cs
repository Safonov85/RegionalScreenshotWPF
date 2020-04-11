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

namespace RegionalScreeshotWPF
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

        private void TakeScreenshotButton_Click(object sender, RoutedEventArgs e)
        {
            Window myWin = new MyWindow(); // Create the Window object.

            // ToolWindow does not have any max or min buttons.


            myWin.WindowStyle = WindowStyle.ToolWindow;


            myWin.Content += "\nTesting new window"; // add more content


            myWin.Show();
        }
    }

    class MyWindow : Window

    {  // Declare a class that derives from the Window class

        public MyWindow()
        { // Constructor


            Width = 300;


            Height = 100;


            Title = "New Window";


            Content = "Is this working?";


        }

    }
}
