using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Controls;

namespace Secondterminal
{
    class changeColorClass
    {
        public void changeColorRed(Button btn)
        {

            BitmapImage bitimg = new BitmapImage();

            bitimg.BeginInit();

            bitimg.UriSource = new Uri(@"pics\bordikkeledigtknap.jpg", UriKind.RelativeOrAbsolute);

            bitimg.EndInit();



            Image img = new Image();

            img.Stretch = Stretch.Fill;

            img.Source = bitimg;



            // Set Button.Content

            btn.Content = img;



            // Set Button.Background

            btn.Background = new ImageBrush(bitimg);





        }
        public void changeColorGreen(Button btn)
        {

            BitmapImage bitimg = new BitmapImage();

            bitimg.BeginInit();

            bitimg.UriSource = new Uri(@"pics\bordledigtknap.jpg", UriKind.RelativeOrAbsolute);

            bitimg.EndInit();



            Image img = new Image();

            img.Stretch = Stretch.Fill;

            img.Source = bitimg;



            // Set Button.Content

            btn.Content = img;



            // Set Button.Background

            btn.Background = new ImageBrush(bitimg);


        }
        public void setTimeOnTable()
        {

        }


    }
}
