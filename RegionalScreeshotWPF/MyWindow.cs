using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace RegionalScreeshotWPF
{
    public class MyWindow : Window
    {
        Image mainImage;
        System.Windows.Media.Brush mainScreenShot;
        public BitmapImage mainScreenShotImage;
        public MyWindow(double width, double height)
        {
            //mainImage = new Image();
            //mainScreenShot = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/myapp;component/Images/icon.png")));

            Width = width;


            Height = height;


            Title = "New Window";


            Content = "Is this working?";


        }

        double screenLeft = SystemParameters.VirtualScreenLeft;
        double screenTop = SystemParameters.VirtualScreenTop;
        double screenWidth = SystemParameters.VirtualScreenWidth;
        double screenHeight = SystemParameters.VirtualScreenHeight;

        public void TakeScreenShot(string FilePath)
        {
            //this.Hide();
            using (var screen = new Bitmap(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height))
            {
                Graphics graphics = Graphics.FromImage(screen);
                //Graphics.FromImage(bitmap).CopyFromScreen(0, 0, Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height, Screen.PrimaryScreen.Bounds.Size);
                graphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height, 0, 0, screen.Size);

                //mainScreenShotImage.UriSource = screen.;
                //bitmap.Save(DateTime.Now.ToString("yyyyMMdd") + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() +
                //    DateTime.Now.Second.ToString() + ".jpg", ImageFormat.Jpeg);
            }
        }
    }
}
