using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaktionslogik für Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        private string boxThema;
        private string box1Frage;
        private string box2Frage;
        private string box3Frage;
        private string box4Frage;
        private string box5Frage;
        private string box6Frage;
        private string boxAntwort1;
        private string boxAntwort2;
        private string boxAntwort3;
        private string boxAntwort4;
        private string boxAntwort5;
        private string boxAntwort6;
        private string boxAntwort7;
        private string boxRichtigeAntwort;
        private int nextBlockNumber;

        private Helferlein helfer;
        public Editor(Helferlein helfer)
        {
            InitializeComponent();
            this.helfer = helfer;
            
            EditorButtonFrageZ2.IsEnabled = false;
            EditorButtonFrageZ3.IsEnabled = false;
            EditorButtonFrageZ4.IsEnabled = false;
            EditorButtonFrageZ5.IsEnabled = false;
            EditorButtonAntwort5.IsEnabled = false;
            EditorButtonAntwort6.IsEnabled = false;
            EditorButtonAntwort7.IsEnabled = false;

            if (helfer.GetDarkMode == true)
            {
                BorderGridEditor.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            else
            {
                BorderGridEditor.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }

        private async void EditorButtonAntwort1_Click(object sender, RoutedEventArgs e)
        {
            EditorTextBoxAntwort1.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
            EditorTextBoxAntwort1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            await Task.Delay(200);
            EditorTextBoxAntwort1.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            EditorTextBoxAntwort1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        private async void EditorButtonAntwort2_Click(object sender, RoutedEventArgs e)
        {
            EditorTextBoxAntwort2.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
            EditorTextBoxAntwort2.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            await Task.Delay(200);
            EditorTextBoxAntwort2.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            EditorTextBoxAntwort2.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        private async void EditorButtonAntwort3_Click(object sender, RoutedEventArgs e)
        {
            EditorTextBoxAntwort3.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
            EditorTextBoxAntwort3.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            await Task.Delay(200);
            EditorTextBoxAntwort3.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            EditorTextBoxAntwort3.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }

        private void EditorButtonAntwort4_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBoxAntwort4.IsEnabled == false)
            {
                EditorTextBoxAntwort4.IsEnabled = true;
                EditorButtonAntwort4.Content = "4";
                EditorButtonAntwort4.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonAntwort4.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonAntwort5.IsEnabled = true;
            }

            else
            {
                EditorTextBoxAntwort4.IsEnabled = false;
                EditorButtonAntwort4.Content = "4";
                EditorButtonAntwort4.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonAntwort4.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonAntwort5.IsEnabled = false;
            }
        }

        private void EditorButtonAntwort5_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBoxAntwort5.IsEnabled == false)
            {
                EditorTextBoxAntwort5.IsEnabled = true;
                EditorButtonAntwort5.Content = "5";
                EditorButtonAntwort5.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonAntwort5.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonAntwort4.IsEnabled = false;
                EditorButtonAntwort4.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonAntwort6.IsEnabled = true;
            }

            else
            {
                EditorTextBoxAntwort5.IsEnabled = false;
                EditorButtonAntwort5.Content = "5";
                EditorButtonAntwort5.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonAntwort5.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonAntwort4.IsEnabled = true;
                EditorButtonAntwort6.IsEnabled = false;
            }
        }

        private void EditorButtonAntwort6_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBoxAntwort6.IsEnabled == false)
            {
                EditorTextBoxAntwort6.IsEnabled = true;
                EditorButtonAntwort6.Content = "6";
                EditorButtonAntwort6.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonAntwort6.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonAntwort5.IsEnabled = false;
                EditorButtonAntwort5.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonAntwort7.IsEnabled = true;
            }

            else
            {
                EditorTextBoxAntwort6.IsEnabled = false;
                EditorButtonAntwort6.Content = "6";
                EditorButtonAntwort6.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonAntwort6.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonAntwort5.IsEnabled = true;
                EditorButtonAntwort7.IsEnabled = false;
            }
        }

        private void EditorButtonAntwort7_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBoxAntwort7.IsEnabled == false)
            {
                EditorTextBoxAntwort7.IsEnabled = true;
                EditorButtonAntwort7.Content = "7";
                EditorButtonAntwort7.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonAntwort7.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonAntwort6.IsEnabled = false;
                EditorButtonAntwort6.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }

            else
            {
                EditorTextBoxAntwort7.IsEnabled = false;
                EditorButtonAntwort7.Content = "7";
                EditorButtonAntwort7.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonAntwort7.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonAntwort6.IsEnabled = true;
            }
        }

        private void EditorButtonFrageZ1_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBox2Frage.IsEnabled == false)
            {
                EditorTextBox2Frage.IsEnabled = true;
                EditorButtonFrageZ1.Content = "- 1";
                EditorButtonFrageZ1.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonFrageZ1.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonFrageZ2.IsEnabled = true;
                EditorButtonFrageZ2.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
            }

            else
            {
                EditorTextBox2Frage.IsEnabled = false;
                EditorButtonFrageZ1.Content = "+ 1";
                EditorButtonFrageZ1.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonFrageZ1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ2.IsEnabled = false;
            }
        }

        private void EditorButtonFrageZ2_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBox3Frage.IsEnabled == false)
            {
                EditorTextBox3Frage.IsEnabled = true;
                EditorButtonFrageZ2.Content = "- 1";
                EditorButtonFrageZ2.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonFrageZ2.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonFrageZ3.IsEnabled = true;
                EditorButtonFrageZ3.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonFrageZ1.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ1.IsEnabled = false;
            }

            else
            {
                EditorTextBox3Frage.IsEnabled = false;
                EditorButtonFrageZ2.Content = "+ 1";
                EditorButtonFrageZ2.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonFrageZ2.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ3.IsEnabled = false;
                EditorButtonFrageZ1.IsEnabled = true;
            }
        }

        private void EditorButtonFrageZ3_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBox4Frage.IsEnabled == false)
            {
                EditorTextBox4Frage.IsEnabled = true;
                EditorButtonFrageZ3.Content = "- 1";
                EditorButtonFrageZ3.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonFrageZ3.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonFrageZ4.IsEnabled = true;
                EditorButtonFrageZ4.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonFrageZ2.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ2.IsEnabled = false;
            }

            else
            {
                EditorTextBox4Frage.IsEnabled = false;
                EditorButtonFrageZ3.Content = "+ 1";
                EditorButtonFrageZ3.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonFrageZ3.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ4.IsEnabled = false;
                EditorButtonFrageZ2.IsEnabled = true;
            }
        }

        private void EditorButtonFrageZ4_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBox5Frage.IsEnabled == false)
            {
                EditorTextBox5Frage.IsEnabled = true;
                EditorButtonFrageZ4.Content = "- 1";
                EditorButtonFrageZ4.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonFrageZ4.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonFrageZ5.IsEnabled = true;
                EditorButtonFrageZ5.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonFrageZ3.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ3.IsEnabled = false;
            }

            else
            {
                EditorTextBox5Frage.IsEnabled = false;
                EditorButtonFrageZ4.Content = "+ 1";
                EditorButtonFrageZ4.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonFrageZ4.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ5.IsEnabled = false;
                EditorButtonFrageZ3.IsEnabled = true;
            }
        }

        private void EditorButtonFrageZ5_Click(object sender, RoutedEventArgs e)
        {
            if (EditorTextBox6Frage.IsEnabled == false)
            {
                EditorTextBox6Frage.IsEnabled = true;
                EditorButtonFrageZ5.Content = "- 1";
                EditorButtonFrageZ5.Background = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
                EditorButtonFrageZ5.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                EditorButtonFrageZ4.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ4.IsEnabled = false;
            }

            else
            {
                EditorTextBox6Frage.IsEnabled = false;
                EditorButtonFrageZ5.Content = "+ 1";
                EditorButtonFrageZ5.Background = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
                EditorButtonFrageZ5.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                EditorButtonFrageZ4.IsEnabled = true;
            }
        }

        private void SaveButtonEditor_Click(object sender, RoutedEventArgs e)
        {
            SaveEditor();
        }

        private void ClearButtonEditor_Click(object sender, RoutedEventArgs e)
        {
            EditorTextBoxenClear();
        }

        private void SaveEditor()
        {
            nextBlockNumber = helfer.AntwortListe.Count();
            if (nextBlockNumber <= 9)
            {
                boxThema = $"000{nextBlockNumber.ToString()}0 {EditorTextBoxThema.Text}";
                box1Frage = $"000{nextBlockNumber.ToString()}1 {EditorTextBox1Frage.Text}";
                box2Frage = $"000{nextBlockNumber.ToString()}1 {EditorTextBox2Frage.Text}";
                box3Frage = $"000{nextBlockNumber.ToString()}1 {EditorTextBox3Frage.Text}";
                box4Frage = $"000{nextBlockNumber.ToString()}1 {EditorTextBox4Frage.Text}";
                box5Frage = $"000{nextBlockNumber.ToString()}1 {EditorTextBox5Frage.Text}";
                box6Frage = $"000{nextBlockNumber.ToString()}1 {EditorTextBox6Frage.Text}";
                boxAntwort1 = $"000{nextBlockNumber.ToString()}2 {EditorTextBoxAntwort1.Text}";
                boxAntwort2 = $"000{nextBlockNumber.ToString()}3 {EditorTextBoxAntwort2.Text}";
                boxAntwort3 = $"000{nextBlockNumber.ToString()}4 {EditorTextBoxAntwort3.Text}";
                boxAntwort4 = $"000{nextBlockNumber.ToString()}5 {EditorTextBoxAntwort4.Text}";
                boxAntwort5 = $"000{nextBlockNumber.ToString()}6 {EditorTextBoxAntwort5.Text}";
                boxAntwort6 = $"000{nextBlockNumber.ToString()}7 {EditorTextBoxAntwort6.Text}";
                boxAntwort7 = $"000{nextBlockNumber.ToString()}8 {EditorTextBoxAntwort7.Text}";
                boxRichtigeAntwort = $"000{nextBlockNumber.ToString()}9 000{nextBlockNumber.ToString()}{(Convert.ToInt32(EditorTextBoxRichtigeAntwort.Text) + 1).ToString()}";
            }
            else if (nextBlockNumber >= 10 && nextBlockNumber <= 99)
            {
                boxThema = $"00{nextBlockNumber.ToString()}0 {EditorTextBoxThema.Text}";
                box1Frage = $"00{nextBlockNumber.ToString()}1 {EditorTextBox1Frage.Text}";
                box2Frage = $"00{nextBlockNumber.ToString()}1 {EditorTextBox2Frage.Text}";
                box3Frage = $"00{nextBlockNumber.ToString()}1 {EditorTextBox3Frage.Text}";
                box4Frage = $"00{nextBlockNumber.ToString()}1 {EditorTextBox4Frage.Text}";
                box5Frage = $"00{nextBlockNumber.ToString()}1 {EditorTextBox5Frage.Text}";
                box6Frage = $"00{nextBlockNumber.ToString()}1 {EditorTextBox6Frage.Text}";
                boxAntwort1 = $"00{nextBlockNumber.ToString()}2 {EditorTextBoxAntwort1.Text}";
                boxAntwort2 = $"00{nextBlockNumber.ToString()}3 {EditorTextBoxAntwort2.Text}";
                boxAntwort3 = $"00{nextBlockNumber.ToString()}4 {EditorTextBoxAntwort3.Text}";
                boxAntwort4 = $"00{nextBlockNumber.ToString()}5 {EditorTextBoxAntwort4.Text}";
                boxAntwort5 = $"00{nextBlockNumber.ToString()}6 {EditorTextBoxAntwort5.Text}";
                boxAntwort6 = $"00{nextBlockNumber.ToString()}7 {EditorTextBoxAntwort6.Text}";
                boxAntwort7 = $"00{nextBlockNumber.ToString()}8 {EditorTextBoxAntwort7.Text}";
                boxRichtigeAntwort = $"00{nextBlockNumber.ToString()}9 00{nextBlockNumber.ToString()}{(Convert.ToInt32(EditorTextBoxRichtigeAntwort.Text) + 1).ToString()}";
            }
            else if (nextBlockNumber >= 100 && nextBlockNumber <= 999)
            {
                boxThema = $"0{nextBlockNumber.ToString()}0 {EditorTextBoxThema.Text}";
                box1Frage = $"0{nextBlockNumber.ToString()}1 {EditorTextBox1Frage.Text}";
                box2Frage = $"0{nextBlockNumber.ToString()}1 {EditorTextBox2Frage.Text}";
                box3Frage = $"0{nextBlockNumber.ToString()}1 {EditorTextBox3Frage.Text}";
                box4Frage = $"0{nextBlockNumber.ToString()}1 {EditorTextBox4Frage.Text}";
                box5Frage = $"0{nextBlockNumber.ToString()}1 {EditorTextBox5Frage.Text}";
                box6Frage = $"0{nextBlockNumber.ToString()}1 {EditorTextBox6Frage.Text}";
                boxAntwort1 = $"0{nextBlockNumber.ToString()}2 {EditorTextBoxAntwort1.Text}";
                boxAntwort2 = $"0{nextBlockNumber.ToString()}3 {EditorTextBoxAntwort2.Text}";
                boxAntwort3 = $"0{nextBlockNumber.ToString()}4 {EditorTextBoxAntwort3.Text}";
                boxAntwort4 = $"0{nextBlockNumber.ToString()}5 {EditorTextBoxAntwort4.Text}";
                boxAntwort5 = $"0{nextBlockNumber.ToString()}6 {EditorTextBoxAntwort5.Text}";
                boxAntwort6 = $"0{nextBlockNumber.ToString()}7 {EditorTextBoxAntwort6.Text}";
                boxAntwort7 = $"0{nextBlockNumber.ToString()}8 {EditorTextBoxAntwort7.Text}";
                boxRichtigeAntwort = $"0{nextBlockNumber.ToString()}9 0{nextBlockNumber.ToString()}{(Convert.ToInt32(EditorTextBoxRichtigeAntwort.Text) + 1).ToString()}";
            }
            else if (nextBlockNumber >= 1000 && nextBlockNumber <= 9999)
            {
                boxThema = $"{nextBlockNumber.ToString()}0 {EditorTextBoxThema.Text}";
                box1Frage = $"{nextBlockNumber.ToString()}1 {EditorTextBox1Frage.Text}";
                box2Frage = $"{nextBlockNumber.ToString()}1 {EditorTextBox2Frage.Text}";
                box3Frage = $"{nextBlockNumber.ToString()}1 {EditorTextBox3Frage.Text}";
                box4Frage = $"{nextBlockNumber.ToString()}1 {EditorTextBox4Frage.Text}";
                box5Frage = $"{nextBlockNumber.ToString()}1 {EditorTextBox5Frage.Text}";
                box6Frage = $"{nextBlockNumber.ToString()}1 {EditorTextBox6Frage.Text}";
                boxAntwort1 = $"{nextBlockNumber.ToString()}2 {EditorTextBoxAntwort1.Text}";
                boxAntwort2 = $"{nextBlockNumber.ToString()}3 {EditorTextBoxAntwort2.Text}";
                boxAntwort3 = $"{nextBlockNumber.ToString()}4 {EditorTextBoxAntwort3.Text}";
                boxAntwort4 = $"{nextBlockNumber.ToString()}5 {EditorTextBoxAntwort4.Text}";
                boxAntwort5 = $"{nextBlockNumber.ToString()}6 {EditorTextBoxAntwort5.Text}";
                boxAntwort6 = $"{nextBlockNumber.ToString()}7 {EditorTextBoxAntwort6.Text}";
                boxAntwort7 = $"{nextBlockNumber.ToString()}8 {EditorTextBoxAntwort7.Text}";
                boxRichtigeAntwort = $"{nextBlockNumber.ToString()}9 {nextBlockNumber.ToString()}{(Convert.ToInt32(EditorTextBoxRichtigeAntwort.Text) + 1).ToString()}";
            }

            WriteToList();
        }

        private void WriteToList()
        {
            
            if (Convert.ToInt32(EditorTextBoxRichtigeAntwort.Text) >= 1 && Convert.ToInt32(EditorTextBoxRichtigeAntwort.Text) <= 7)
            {
                helfer.FragenListe.Add(boxThema);
                helfer.FragenListe.Add(box1Frage);

                if (EditorTextBox2Frage.IsEnabled)
                {
                    helfer.FragenListe.Add(box2Frage);
                }

                if (EditorTextBox3Frage.IsEnabled)
                {
                    helfer.FragenListe.Add(box3Frage);
                }

                if (EditorTextBox4Frage.IsEnabled)
                {
                    helfer.FragenListe.Add(box4Frage);
                }

                if (EditorTextBox5Frage.IsEnabled)
                {
                    helfer.FragenListe.Add(box5Frage);
                }

                if (EditorTextBox6Frage.IsEnabled)
                {
                    helfer.FragenListe.Add(box6Frage);
                }

                helfer.FragenListe.Add(boxAntwort1);
                helfer.FragenListe.Add(boxAntwort2);
                helfer.FragenListe.Add(boxAntwort3);

                if (EditorTextBoxAntwort4.IsEnabled)
                {
                    helfer.FragenListe.Add(boxAntwort4);
                }

                if (EditorTextBoxAntwort5.IsEnabled)
                {
                    helfer.FragenListe.Add(boxAntwort5);
                }

                if (EditorTextBoxAntwort6.IsEnabled)
                {
                    helfer.FragenListe.Add(boxAntwort6);
                }

                if (EditorTextBoxAntwort7.IsEnabled)
                {
                    helfer.FragenListe.Add(boxAntwort7);
                }

                helfer.FragenListe.Add(boxRichtigeAntwort);
                EditorTextBoxenClear();
            }
            else
            {
                WrongNumber();
            }
        }

        private async void WrongNumber()
        {
            BorderClearButtonEditor.Visibility = Visibility.Hidden;
            ClearButtonEditor.Visibility = Visibility.Hidden;
            LabelRichtigeAntwortNumber.Visibility = Visibility.Visible;
            await Task.Delay(750);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Hidden;
            await Task.Delay(250);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Visible;
            await Task.Delay(750);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Hidden;
            await Task.Delay(250);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Visible;
            await Task.Delay(750);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Hidden;
            await Task.Delay(250);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Visible;
            await Task.Delay(750);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Hidden;
            await Task.Delay(250);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Visible;
            await Task.Delay(750);
            LabelRichtigeAntwortNumber.Visibility = Visibility.Hidden;
            BorderClearButtonEditor.Visibility = Visibility.Visible;
            ClearButtonEditor.Visibility = Visibility.Visible;
        }
        private void EditorTextBoxenClear()
        {
            EditorTextBoxThema.Clear();
            EditorTextBoxRichtigeAntwort.Clear();
            EditorTextBox1Frage.Clear();
            EditorTextBox2Frage.Clear();
            EditorTextBox3Frage.Clear();
            EditorTextBox4Frage.Clear();
            EditorTextBox5Frage.Clear();
            EditorTextBox6Frage.Clear();
            EditorTextBoxAntwort1.Clear();
            EditorTextBoxAntwort2.Clear();
            EditorTextBoxAntwort3.Clear();
            EditorTextBoxAntwort4.Clear();
            EditorTextBoxAntwort5.Clear();
            EditorTextBoxAntwort6.Clear();
            EditorTextBoxAntwort7.Clear();
            nextBlockNumber = 0;
        }

        private void EditorTextBoxRichtigeAntwort_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                UInt32 Variable = Convert.ToUInt32(EditorTextBoxRichtigeAntwort.Text);
            }
            catch (FormatException)
            {
                EditorTextBoxRichtigeAntwort.Clear();
            }
        }

        private void ExitButtonEditor_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.Delete("..\\..\\FRAGEN.TXT");
            System.IO.File.WriteAllLines("..\\..\\FRAGEN.TXT", helfer.FragenListe);
            helfer.BlockClear();
            Close();
        }
    }
}
