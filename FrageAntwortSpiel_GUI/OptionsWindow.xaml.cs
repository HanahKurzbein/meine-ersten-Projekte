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
    /// Interaktionslogik für OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Window
    {
        private Helferlein helfer;
        public OptionsWindow(Helferlein helfer)
        {
            InitializeComponent();
            this.helfer = helfer;

            BackUpButtonOptions.IsEnabled = false;

            if (helfer.GetDarkMode == true)
            {
                BorderGridOptionsWindow.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            else
            {
                BorderGridOptionsWindow.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }

        private void EditorNewButtonOptions_Click(object sender, RoutedEventArgs e)
        {
            BackUpButtonOptions.IsEnabled = true;
            //helfer.Einlesen();
            var window = new Editor(helfer);
            window.Owner = this;
            window.ShowDialog();
        }

        private void EditorSelButtonOptions_Click(object sender, RoutedEventArgs e)
        {
            BackUpButtonOptions.IsEnabled = true;
            //helfer.Einlesen();
            var window = new SelectionWindow(helfer);
            window.Owner = this;
            window.ShowDialog();
        }

        private void EditorDelButtonOptions_Click(object sender, RoutedEventArgs e)
        {
            BackUpButtonOptions.IsEnabled = true;
            //helfer.Einlesen();
            var window = new DeleteWindow(helfer);
            window.Owner = this;
            window.ShowDialog();
        }

        private void BackUpButtonOptions_Click(object sender, RoutedEventArgs e)
        {
            BackUpButtonOptions.IsEnabled = false;
            helfer.AllClear();
            helfer.BackUpEinlesen();
            System.IO.File.Delete("..\\..\\FRAGEN.TXT");
            System.IO.File.WriteAllLines("..\\..\\FRAGEN.TXT", helfer.FragenListe);
            Close();
        }
    }
}
