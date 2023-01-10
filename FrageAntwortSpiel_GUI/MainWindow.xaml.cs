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

namespace FrageAntwortSpiel_GUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Helferlein helfer = new Helferlein();
        public MainWindow()
        {
            InitializeComponent();
            helfer.GetDarkMode = false;
            OptionButtonMain.IsEnabled = false;
            helfer.Einlesen();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new GameWindows(helfer);
            window.Owner = this;
            window.ShowDialog();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {
            OptionButtonMain.IsEnabled = true;
            var window = new InfoWindow(helfer);
            window.Owner = this;
            window.ShowDialog();
        }

        private void OptionButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new OptionsWindow(helfer);
            window.Owner = this;
            window.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DarkModeButton_Click(object sender, RoutedEventArgs e)
        {
            if (helfer.GetDarkMode == false)
            {
                helfer.GetDarkMode = true;
                DarkModeButton.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                DarkModeButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                BorderGridMainWindow.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                QuestionMark_ls_top.Visibility = Visibility.Hidden;
                QuestionMark_ls_middle.Visibility = Visibility.Hidden;
                QuestionMark_ls_bottom.Visibility = Visibility.Hidden;
                QuestionMark_rs_top.Visibility = Visibility.Hidden;
                QuestionMark_rs_middle.Visibility = Visibility.Hidden;
                QuestionMark_rs_bottom.Visibility = Visibility.Hidden;
            }
            else
            {
                helfer.GetDarkMode = false;
                DarkModeButton.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                DarkModeButton.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                BorderGridMainWindow.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                QuestionMark_ls_top.Visibility = Visibility.Visible;
                QuestionMark_ls_middle.Visibility = Visibility.Visible;
                QuestionMark_ls_bottom.Visibility = Visibility.Visible;
                QuestionMark_rs_top.Visibility = Visibility.Visible;
                QuestionMark_rs_middle.Visibility = Visibility.Visible;
                QuestionMark_rs_bottom.Visibility = Visibility.Visible;
            }
        }        
    }
}
