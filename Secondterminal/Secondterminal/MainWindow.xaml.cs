using BLL;
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
using System.Windows.Threading;
namespace Secondterminal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Button tableClicked { get; set; } // sender TableClicked til changeColorClass
        public string cnn = "Server=192.168.132.33;Database=restaurant;User Id=db_user;Password=Password1";

        BLL.BuisnessLogicLayer bll = new BuisnessLogicLayer();
        changeColorClass cCC = new changeColorClass();
        public MainWindow()
        {

            InitializeComponent();

            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            LiveTimeLabel.Content = DateTime.Now.ToString("HH:mm:ss");
        }



        //--------------------------------------------------Bord knapper på main screen------------------------------------

        public void _1_1_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button; // sætter TableClicked til Button _1_1
            bord1.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
            
        }


        private void _1_2_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button;
            bord2.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
        }

        private void _1_3_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button;
            bord3.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;

        }

        private void _1_4_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button;
            bord4.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
        }

        private void _1_5_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button;
            bord5.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
        }

        private void _1_6_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button;
            bord6.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
        }

        private void _1_7_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button;
            bord7.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
        }

        private void _1_8_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button;
            bord8.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
        }

        private void _1_9_Click(object sender, RoutedEventArgs e)
        {
            tableClicked = sender as Button;
            bord9.Content = DateTime.Now.ToShortTimeString();
            this.Tablebooking_Canvas.Visibility = Visibility.Visible;
        }
        //------------------------------------------Knapper i canvas------------------------------------------------------

        private void Back_BTN_Click(object sender, RoutedEventArgs e) // skal kun gemme Canvaset væk. 
        {
            this.Tablebooking_Canvas.Visibility = Visibility.Hidden;
        }

        private void Reserve_BTN_Click(object sender, RoutedEventArgs e/*, int whatBtnClick*/)
        {

            cCC.changeColorRed(tableClicked);
            bll.C_Reservations(1, 1, DateTime.Now, cnn);

        }

        private void Free_BTN_Click(object sender, RoutedEventArgs e)
        {
            cCC.changeColorGreen(tableClicked);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Stol5_Click(object sender, RoutedEventArgs e)
        {

        }
    }



}



