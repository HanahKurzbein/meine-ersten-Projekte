using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    /// Interaktionslogik für SelectionWindow.xaml
    /// </summary>
    public partial class SelectionWindow : Window
    {
        private Helferlein helfer;

        public SelectionWindow(Helferlein helfer)
        {
            InitializeComponent();
            this.helfer = helfer;

            LoadButtonSelectionWindow.IsEnabled = true;
            SaveButtonSelectedWindow.IsEnabled = false;
            CancelButtonSelectedWindow.IsEnabled = false;
            ListBoxSelectionWindow.SelectedItem = null;

            if (helfer.GetDarkMode == true)
            {
                BorderGridSelectionWindow.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            else
            {
                BorderGridSelectionWindow.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }

        private void LoadButtonSelectionWindow_Click(object sender, RoutedEventArgs e)
        {
            ListBoxSelectionWindow.Items.Clear();
            LoadButtonSelectionWindow.IsEnabled = false;
            ListBoxSelectionWindow.SelectedItem = null;
            SaveButtonSelectedWindow.IsEnabled = true;
            CancelButtonSelectedWindow.IsEnabled = true;
            FillListBox();
        }

        private async void SaveButtonSelectedWindow_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxSelectionWindow.SelectedItem != null)
            {
                string saveSelected = TextBoxSelectionWindow.Text;
                helfer.FragenListe.RemoveAt(ListBoxSelectionWindow.SelectedIndex);
                helfer.FragenListe.Insert(ListBoxSelectionWindow.SelectedIndex, saveSelected);
                TextBoxSelectionWindow.Clear();
                ListBoxSelectionWindow.Items.Clear();
                ListBoxSelectionWindow.SelectedItem = null;
                FillListBox();
            }
            else
            {
                ListBoxSelectionWindow.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                ListBoxSelectionWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                await Task.Delay(200);
                ListBoxSelectionWindow.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                ListBoxSelectionWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                await Task.Delay(200);
                ListBoxSelectionWindow.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                ListBoxSelectionWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                await Task.Delay(200);
                ListBoxSelectionWindow.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                ListBoxSelectionWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                await Task.Delay(200);
                ListBoxSelectionWindow.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                ListBoxSelectionWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                await Task.Delay(200);
                ListBoxSelectionWindow.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                ListBoxSelectionWindow.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
        }

        private void CancelButtonSelectedWindow_Click(object sender, RoutedEventArgs e)
        {
            TextBoxSelectionWindow.Clear();
            ListBoxSelectionWindow.Items.Clear();
            ListBoxSelectionWindow.SelectedItem = null;
            FillListBox();
        }

        private void ListBoxSelectionWindow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxSelectionWindow.SelectedItem != null)
            {
                helfer.SelectedString = helfer.FragenListe.ElementAt(ListBoxSelectionWindow.SelectedIndex);
                CheckSelected(helfer.SelectedString);
                TextBoxSelectionWindow.Text = helfer.SelectedString;
                SaveButtonSelectedWindow.IsEnabled = true;
                CancelButtonSelectedWindow.IsEnabled = true;
            }
        }

        private string CheckSelected(string SelectedString)
        {
            if (SelectedString != null)
            {
                foreach (string line in helfer.GetFullList())
                {
                    if (ListBoxSelectionWindow.SelectedItem != null)
                    {
                        SelectedString = helfer.FragenListe.ElementAt(ListBoxSelectionWindow.SelectedIndex);
                        return line;
                    }
                }
            }
            return null;
        }

        private void FillListBox()
        {
            foreach (string line in helfer.GetFullList())
            {
                ListBoxSelectionWindow.Items.Add(line);
            }
        }

        private void ExitButtonSelectionWindow_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.Delete("..\\..\\FRAGEN.TXT");
            System.IO.File.WriteAllLines("..\\..\\FRAGEN.TXT", helfer.FragenListe);
            helfer.BlockClear();
            Close();
        }
    }
}
