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
    /// Interaktionslogik für InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        private Helferlein helfer;
        public InfoWindow(Helferlein helfer)
        {
            InitializeComponent();
            this.helfer = helfer;
            
            if (helfer.GetDarkMode == true)
            {
                BorderGridInfoWindow.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            else
            {
                BorderGridInfoWindow.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }

            ListBoxInfo.Items.Clear();
            helfer.InfoListe.Clear();
            helfer.InfoEinlesen();

            foreach (string item in helfer.GetInfoList())
            {
                ListBoxInfo.Items.Add(item);
            }
        }
    }
}
