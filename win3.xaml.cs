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
using System.Windows.Shapes;

namespace ramm
{
    /// <summary>
    /// Interakční logika pro win3.xaml
    /// </summary>
    public partial class win3 : Window
    {
        public win3()
        {
            InitializeComponent();

        }

        private void richard(object sender, MouseButtonEventArgs e)
        {
            if (popup.IsOpen)
                popup.IsOpen = false;
            else
                popup.IsOpen = true;
        }

        private void flake(object sender, MouseButtonEventArgs e)
        {
            if (popup2.IsOpen)
                popup2.IsOpen = false;
            else
                popup2.IsOpen = true;
        }

        private void paul(object sender, MouseButtonEventArgs e)
        {
            if (popup3.IsOpen)
                popup3.IsOpen = false;
            else
                popup3.IsOpen = true;
        }

        private void lindemann(object sender, MouseButtonEventArgs e)
        {
            if (popup4.IsOpen)
                popup4.IsOpen = false;
            else
                popup4.IsOpen = true;
        }

        private void schneider(object sender, MouseButtonEventArgs e)
        {
            if (popup5.IsOpen)
                popup5.IsOpen = false;
            else
                popup5.IsOpen = true;
        }

        private void riedel(object sender, MouseButtonEventArgs e)
        {
            if (popup6.IsOpen)
                popup6.IsOpen = false;
            else
                popup6.IsOpen = true;
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
