using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegionalScreeshotWPF
{
    public class MyWindow : Window
    {
        Image mainImage;
        public MyWindow(double width, double height)
        {


            Width = width;


            Height = height;


            Title = "New Window";


            Content = "Is this working?";


        }
    }
}
