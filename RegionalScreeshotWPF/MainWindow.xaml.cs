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
        Window myWin;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TakeScreenshotButton_Click(object sender, RoutedEventArgs e)
        {
            myWin = new MyWindow(SystemParameters.VirtualScreenWidth, SystemParameters.VirtualScreenHeight);
            myWin.WindowStyle = WindowStyle.ToolWindow;

            myWin.WindowState = WindowState.Maximized;
            myWin.WindowStyle = WindowStyle.None;


            myWin.Content += "\nTesting new window";

            myWin.MouseUp += new MouseButtonEventHandler(WindowClickUp);
            myWin.MouseLeftButtonUp += new MouseButtonEventHandler(MouseLeftUp);
            myWin.MouseRightButtonUp += new MouseButtonEventHandler(MouseRightUp);

            myWin.ShowDialog();
        }

        private void MouseRightUp(object sender, MouseButtonEventArgs e)
        {
            myWin.Hide();
            myWin.Close();
        }

        private void MouseLeftUp(object sender, MouseButtonEventArgs e)
        {
            myWin.Background = Brushes.Green;
            //throw new NotImplementedException();
        }

        void WindowClickUp(object sender, RoutedEventArgs e)
        {

            //myWin.Background = Brushes.Red;
            //myWin.Close();
        }
    }
}
