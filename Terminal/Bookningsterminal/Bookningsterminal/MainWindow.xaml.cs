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

namespace Bookningsterminal
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
        public void button_Click(int whatBtnClick1,RoutedEventArgs e)
        {
            switch (whatBtnClick1)
            {
                case 1: //code here
                   
                    break;
                case 2: //code here
                
                    break;
                case 3: //code here
                
                    break;
                case 4: //code here
                
                    break;
                case 5: //code here
                
                    break;
                case 6: //code here
                
                    break;
                case 7: //code here
                
                    break;
                case 8: //code here
                
                    break;
                case 9: //code here
                
                    break;


               default:
                    break;
            }

        }

        //--------------------------------------------------Bord knapper på main screen------------------------------------
        
         public void _1_1_Click(object sender, RoutedEventArgs e)
         {
             this.Tablebooking_Canvas.Visibility = Visibility.Visible;
             button_Click(1, e);
         }
         
         private void _1_2_Click(object sender, RoutedEventArgs e)
         {
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            button_Click(2, e);

        }
         
         private void _1_3_Click(object sender, RoutedEventArgs e)
         {
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            button_Click(3, e);
        }
         
         private void _1_4_Click(object sender, RoutedEventArgs e)
         {
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            button_Click(4, e);
        }
         
         private void _1_5_Click(object sender, RoutedEventArgs e)
         {
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            button_Click(5, e);
        }
         
         private void _1_6_Click(object sender, RoutedEventArgs e)
         {
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            button_Click(6, e);
        }
         
         private void _1_7_Click(object sender, RoutedEventArgs e)
         {
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            button_Click(7, e);
        }
         
         private void _1_8_Click(object sender, RoutedEventArgs e)
         {
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            button_Click(8, e);
        }
         
         private void _1_9_Click(object sender, RoutedEventArgs e)
         {
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            button_Click(9, e);
        }
         //------------------------------------------Knapper i canvas------------------------------------------------------
         
         private void Back_BTN_Click(object sender, RoutedEventArgs e) // skal kun gemme Canvaset væk. 
         {
             this.Tablebooking_Canvas.Visibility = Visibility.Hidden;
         }

        private void Reserve_BTN_Click(object sender, RoutedEventArgs e, int whatBtnClick)
        {
            
        }
    }
}
