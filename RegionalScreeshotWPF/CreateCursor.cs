using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace RegionalScreeshotWPF
{
    public class CreateCursor
    {
		public CreateCursor()
		{

		}

		public string manualTutorial = "Scroll (+ Hold Ctrl) ( ← → ↑ ↓ )";

		Cursor CreateNewCursor(int x, int y)
		{
			Bitmap image = new Bitmap(x, y);
			BitmapImage bitmapImg = new BitmapImage();
			//Stream stream = new Stream();

			Graphics graphics = Graphics.FromImage(image);

			Pen pen = new Pen(Color.Red, 2);
			pen.DashPattern = new float[] { 2.0F, 2.0F, 2.0F, 2.0F };
			Point myPoint1 = new Point(10, 20);
			Point myPoint2 = new Point(30, 40);
			graphics.DrawRectangle(pen, 0, 0, x - 1, y - 1);

			// blue circle
			//graphics.DrawEllipse(Pens.Blue, 0, 0, 50, 50);

			// Text
			graphics.DrawString(manualTutorial, new Font("Calibri", 20, FontStyle.Regular), Brushes.Black, 0, y - 50);
			//image.Save("cursor.bmp");

			//image = bitmapImg;

			//Stream thisStream = image.str

			//return new Cursor(image.GetHicon());
			return new Cursor("nothing yet");
		}
	}
}
