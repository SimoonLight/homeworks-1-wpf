using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_task_1
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

        private void show_message(string num)
        {
            Random obj = new Random();
            byte r = (byte)obj.Next(256);
            byte g = (byte)obj.Next(256);
            byte b = (byte)obj.Next(256);

            Color randomColor = Color.FromArgb(255, r, g, b);

            if (num.Equals("1"))
            {
                btn_1.Background = new SolidColorBrush(randomColor);
            }
            else if (num.Equals("2"))
            {
                btn_2.Background = new SolidColorBrush(randomColor);
            }
            else if (num.Equals("3"))
            {
                btn_3.Background = new SolidColorBrush(randomColor);
            }
            else if (num.Equals("4"))
            {
                btn_4.Background = new SolidColorBrush(randomColor);
            }
            else if (num.Equals("5"))
            {
                btn_5.Background = new SolidColorBrush(randomColor);
            }
            else if (num.Equals("6"))
            {
                btn_6.Background = new SolidColorBrush(randomColor);
            }
            MessageBox.Show($"I am No{num} button ");
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            show_message("1");
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            show_message("2");
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            show_message("3");
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            show_message("4");
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            show_message("5");
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            show_message("6");
        }

        private void btn_1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main_w.Title="1";
            main_grid.Children.Remove(btn_1);
        }

        private void btn_2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main_w.Title = "2";
            main_grid.Children.Remove(btn_2);
        }

        private void btn_3_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main_w.Title = "3";
            main_grid.Children.Remove(btn_3);
        }

        private void btn_4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main_w.Title = "4";
            main_grid.Children.Remove(btn_4);
        }

        private void btn_5_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main_w.Title = "5";
            main_grid.Children.Remove(btn_5);
        }

        private void btn_6_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main_w.Title = "6";
            main_grid.Children.Remove(btn_6);
        }
    }
}