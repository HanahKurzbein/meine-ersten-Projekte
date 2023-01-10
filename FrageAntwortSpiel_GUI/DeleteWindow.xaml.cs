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

namespace FrageAntwortSpiel_GUI
{
    /// <summary>
    /// Interaktionslogik für DeleteWindow.xaml
    /// </summary>
    public partial class DeleteWindow : Window
    {
        private Helferlein helfer;
        public DeleteWindow(Helferlein helfer)
        {
            InitializeComponent();
            this.helfer = helfer;

            LoadButtonDeleteWindow.IsEnabled = true;
            DelButtonDelWin.IsEnabled = false;

            if (helfer.GetDarkMode == true)
            {
                BorderGridDeleteWindow.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            else
            {
                BorderGridDeleteWindow.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }

        private void LoadButtonDeleteWindow_Click(object sender, RoutedEventArgs e)
        {
            LoadButtonDeleteWindow.IsEnabled = false;
            DataGridDeleteWindow.ItemsSource = helfer.FragenListe.Select(x => new { Value = x }).ToList();
            DelButtonDelWin.IsEnabled = true;
        }

        private async void DelButtonDelWin_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridDeleteWindow.SelectedItem != null)
            {
                CheckSelected(helfer.SelectedString);
                helfer.FragenListe.RemoveAt(DataGridDeleteWindow.SelectedIndex);
                DataGridDeleteWindow.ItemsSource = helfer.FragenListe.Select(x => new { Value = x }).ToList();
            }
            else
            {
                DataGridDeleteWindow.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                DataGridDeleteWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                await Task.Delay(200);
                DataGridDeleteWindow.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                DataGridDeleteWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                await Task.Delay(200);
                DataGridDeleteWindow.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                DataGridDeleteWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                await Task.Delay(200);
                DataGridDeleteWindow.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                DataGridDeleteWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                await Task.Delay(200);
                DataGridDeleteWindow.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                DataGridDeleteWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                await Task.Delay(200);
                DataGridDeleteWindow.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                DataGridDeleteWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
        }

        private string CheckSelected(string SelectedString)
        {
            if (SelectedString != null)
            {
                foreach (string line in helfer.GetFullList())
                {
                    if (DataGridDeleteWindow.SelectedItem != null)
                    {
                        SelectedString = helfer.FragenListe.ElementAt(DataGridDeleteWindow.SelectedIndex);
                        return line;
                    }
                }
            }
            return null;
        }

        private void ExitButtonDeleteWindow_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.Delete("..\\..\\FRAGEN.TXT");
            System.IO.File.WriteAllLines("..\\..\\FRAGEN.TXT", helfer.FragenListe);
            helfer.BlockClear();
            Close();
        }
    }
}
