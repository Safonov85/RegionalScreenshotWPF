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
    // Main GUI Class
    public partial class MainWindow : Window
    {
        //Window myWin;
        MyWindow myWin = new MyWindow(SystemParameters.VirtualScreenWidth, SystemParameters.VirtualScreenHeight);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TakeScreenshotButton_Click(object sender, RoutedEventArgs e)
        {
            //myWin = new MyWindow(SystemParameters.VirtualScreenWidth, SystemParameters.VirtualScreenHeight);
            //myWin.WindowStyle = WindowStyle.ToolWindow;

            //myWin.WindowState = WindowState.Maximized;
            //myWin.WindowStyle = WindowStyle.None;


            //myWin.Content += "\nTesting new window";

            //myWin.MouseUp += new MouseButtonEventHandler(WindowClickUp);
            //myWin.MouseLeftButtonUp += new MouseButtonEventHandler(MouseLeftUp);
            //myWin.MouseRightButtonUp += new MouseButtonEventHandler(MouseRightUp);
            //myWin.KeyUp += new KeyEventHandler(MyWin_KeyUp);
            //myWin.MouseWheel += new MouseWheelEventHandler(MouseScroll);


            //myWin.ShowDialog();
            myWin.TakeScreenShot3();
            myWin.ShowDialog();
        }
        
        // SCROLL
        private void MouseScroll(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                myWin.Background = Brushes.LightBlue;
            }

            else if (e.Delta < 0)
            {
                myWin.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Mycomp\Desktop\CamillaMain.png")));
            }
        }

        // KEYBOARD
        private void MyWin_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                myWin.Close();
            }

        }

        // RIGHT CLICK
        private void MouseRightUp(object sender, MouseButtonEventArgs e)
        {
            //myWin.Hide();
            
            myWin.Close();
        }

        // LEFT CLICK
        private void MouseLeftUp(object sender, MouseButtonEventArgs e)
        {
            //myWin.Background = Brushes.Green;
            //throw new NotImplementedException();

            myWin.TakeScreenShot(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            //myWin.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Mycomp\Desktop\CamillaMain.png")));
        }

        // MOUSE CLICK (ANY)
        void WindowClickUp(object sender, RoutedEventArgs e)
        {

            //myWin.Background = Brushes.Red;
            //myWin.Close();
        }
    }
}
