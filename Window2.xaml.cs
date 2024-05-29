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
using System.Diagnostics;
using static System.Net.WebRequestMethods;


namespace ramm
{
    /// <summary>
    /// Interakční logika pro Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        public void album1(object sender, MouseEventArgs e)
        {
            string url = "https://open.spotify.com/album/6HlDm9fzYxk4vkkr3YEvSv?si=6cG1hjpzSsOO7AMpZPikHg";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the URL is opened with the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void album2(object sender, MouseEventArgs e)
        {
            string url = "https://open.spotify.com/album/6hh5ax5BomINXGoi4q7FDP?si=4E86poQPQByM9hXlbG7_ow";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the URL is opened with the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void album3(object sender, MouseEventArgs e)
        {
            string url = "https://open.spotify.com/album/1CtTTpKbHU8KbHRB4LmBbv?si=dIO00ehKR5qdlgiac1bavQ";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the URL is opened with the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void album4(object sender, MouseEventArgs e)
        {
            string url = "https://open.spotify.com/album/74ydDCcXTco741y42ceRJ5?si=FJOJc4I-Sry7cxHxRemKew";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the URL is opened with the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void album5(object sender, MouseEventArgs e)
        {
            string url = "https://open.spotify.com/album/3PrS5X3QNdDUlBIE4bz6J2?si=JY5-OG0RRseK8J61220spw";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the URL is opened with the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void album6(object sender, MouseEventArgs e)
        {
            string url = "https://open.spotify.com/album/29J0MchD0OWNeiMNbPDwfa?si=T1dpcgT9TZyJOh0iBfBm9A";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the URL is opened with the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void album7(object sender, MouseEventArgs e)
        {
            string url = "https://open.spotify.com/album/1LoyJQVHPLHE3fCCS8Juek?si=mQM-9vsnSNesylJO4tHOzg";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the URL is opened with the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        public void album8(object sender, MouseEventArgs e)
        {
            string url = "https://open.spotify.com/album/75OE7M0wduJyffbffehHuR?si=9atRAxp3SHqK75oAUZZaCw";
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // This ensures the URL is opened with the default web browser
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
