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
        Window myWin = new MyWindow(SystemParameters.VirtualScreenWidth, SystemParameters.VirtualScreenHeight);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TakeScreenshotButton_Click(object sender, RoutedEventArgs e)
        {

            myWin.WindowStyle = WindowStyle.ToolWindow;

            myWin.WindowState = WindowState.Maximized;
            myWin.WindowStyle = WindowStyle.None;


            myWin.Content += "\nTesting new window";

            myWin.MouseUp += new MouseButtonEventHandler(WindowClickUp);

            myWin.Show();
        }

        void WindowClickUp(object sender, RoutedEventArgs e)
        {

            myWin.Background = Brushes.Red;
            //myWin.Close();
        }
    }

    class MyWindow : Window
    {

        public MyWindow(double width, double height)
        {


            Width = width;


            Height = height;


            Title = "New Window";


            Content = "Is this working?";


        }
    }
}
