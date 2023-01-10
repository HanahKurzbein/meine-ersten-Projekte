using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaktionslogik für GameWindows.xaml
    /// </summary>
    public partial class GameWindows : Window
    {
        int x = 0;     // Hier wird der Wert definiert, um zu Vergleichen und dadurch die Blöcke zu ermitteln
        int z = 1;
        string antwort;
        DateTime startzeit;
        DateTime endzeit;

        private Helferlein helfer;
        public GameWindows(Helferlein helfer)
        {
            InitializeComponent();
            this.helfer = helfer;
            ButtonsAnAus(false, false, true);
            PressStartAnimation(false);

            if (helfer.GetDarkMode == true)
            {
                BorderGridGameWindows.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
                LabelPressStart.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 165, 0));
            }
            else
            {
                BorderGridGameWindows.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
                LabelPressStart.Foreground = new SolidColorBrush(Color.FromArgb(255, 32, 42, 68));
            }
        }

        private async void StartButton_Click(object sender, RoutedEventArgs e)
        {
            StandardValues();
            ButtonsAnAus(false, false, false);
            PressStartAnimation(true);
            GameStartup();
            await Task.Delay(13750);
            helfer.FragenBlöcke(x, 0);
            ListBoxFill();        // ListBox wird mit FragenListe gefüllt
            ButtonsAnAus(true, false, false);
            ButtonText();
            startzeit = DateTime.Now;
        }

        private void ButtonAntwort1_Click(object sender, RoutedEventArgs e)
        {
            ButtonsAnAus(false, false, false);
            antwort = $"000{x}9 000{x}2";
            helfer.AntwortenVergleich(antwort);
            Ergebnis();
            ButtonsAnAus(false, true, false);
        }

        private void ButtonAntwort2_Click(object sender, RoutedEventArgs e)
        {
            ButtonsAnAus(false, false, false);
            antwort = $"000{x}9 000{x}3";
            helfer.AntwortenVergleich(antwort);
            Ergebnis();
            ButtonsAnAus(false, true, false);
        }

        private void ButtonAntwort3_Click(object sender, RoutedEventArgs e)
        {
            ButtonsAnAus(false, false, false);
            antwort = $"000{x}9 000{x}4";
            helfer.AntwortenVergleich(antwort);
            Ergebnis();
            ButtonsAnAus(false, true, false);
        }

        private void ButtonAntwort4_Click(object sender, RoutedEventArgs e)
        {
            ButtonsAnAus(false, false, false);
            antwort = $"000{x}9 000{x}5";
            helfer.AntwortenVergleich(antwort);
            Ergebnis();
            ButtonsAnAus(false, true, false);
        }

        private void ButtonAntwort5_Click(object sender, RoutedEventArgs e)
        {
            ButtonsAnAus(false, false, false);
            antwort = $"000{x}9 000{x}6";
            helfer.AntwortenVergleich(antwort);
            Ergebnis();
            ButtonsAnAus(false, true, false);
        }

        private void ButtonAntwort6_Click(object sender, RoutedEventArgs e)
        {
            ButtonsAnAus(false, false, false);
            antwort = $"000{x}9 000{x}7";
            helfer.AntwortenVergleich(antwort);
            Ergebnis();
            ButtonsAnAus(false, true, false);
        }

        private void ButtonAntwort7_Click(object sender, RoutedEventArgs e)
        {
            ButtonsAnAus(false, false, false);
            antwort = $"000{x}9 000{x}8";
            helfer.AntwortenVergleich(antwort);
            Ergebnis();
            ButtonsAnAus(false, true, false);
        }

        private void ButtonWeiterGame_Click(object sender, RoutedEventArgs e)
        {
            ButtonsAnAus(false, false, false);
            if (z < helfer.AntwortListe.Count)
            {
                x = z;
                ListBoxGame.Items.Clear();       // Items sollen verschwinden
                helfer.FBLöschen();              // Liste wird greinigt, aber Einträge bleiben bestehen
                helfer.FragenBlöcke(z++, 0);     // Wert wird um eins erhöht 
                ListBoxFill();
                ButtonText();
                ButtonsAnAus(true, false, false);
            }
            else
            {
                endzeit = DateTime.Now;
                ButtonsTextReset();
                EndErgebnis();
                ButtonsAnAus(false, false, true);
            }
        }

        private void ButtonsAnAus(bool antwortButton, bool weiterButton, bool startButton)
        {
            ButtonAntwort1.IsEnabled = antwortButton;
            ButtonAntwort2.IsEnabled = antwortButton;
            ButtonAntwort3.IsEnabled = antwortButton;
            ButtonAntwort4.IsEnabled = antwortButton;
            ButtonAntwort5.IsEnabled = antwortButton;
            ButtonAntwort6.IsEnabled = antwortButton;
            ButtonAntwort7.IsEnabled = antwortButton;
            ButtonWeiterGame.IsEnabled = weiterButton;
            StartButtonGame.IsEnabled = startButton;
        }

        private void ButtonText()
        {
            ButtonAntwort1.Content = $"000{x}2";
            ButtonAntwort2.Content = $"000{x}3";
            ButtonAntwort3.Content = $"000{x}4";
            ButtonAntwort4.Content = $"000{x}5";
            ButtonAntwort5.Content = $"000{x}6";
            ButtonAntwort6.Content = $"000{x}7";
            ButtonAntwort7.Content = $"000{x}8";

            if (helfer.BtnVisibleAntwort4 == true)
            {
                BorderAntwort4.Visibility = Visibility.Visible;
                ButtonAntwort4.Visibility = Visibility.Visible;
            }

            if (helfer.BtnVisibleAntwort4 == false)
            {
                BorderAntwort4.Visibility = Visibility.Hidden;
                ButtonAntwort4.Visibility = Visibility.Hidden;
            }

            if (helfer.BtnVisibleAntwort5 == true)
            {
                BorderAntwort5.Visibility = Visibility.Visible;
                ButtonAntwort5.Visibility = Visibility.Visible;
            }

            if (helfer.BtnVisibleAntwort5 == false)
            {
                BorderAntwort5.Visibility = Visibility.Hidden;
                ButtonAntwort5.Visibility = Visibility.Hidden;
            }

            if (helfer.BtnVisibleAntwort6 == true)
            {
                BorderAntwort6.Visibility = Visibility.Visible;
                ButtonAntwort6.Visibility = Visibility.Visible;
            }

            if (helfer.BtnVisibleAntwort6 == false)
            {
                BorderAntwort6.Visibility = Visibility.Hidden;
                ButtonAntwort6.Visibility = Visibility.Hidden;
            }

            if (helfer.BtnVisibleAntwort7 == true)
            {
                BorderAntwort7.Visibility = Visibility.Visible;
                ButtonAntwort7.Visibility = Visibility.Visible;
            }

            if (helfer.BtnVisibleAntwort7 == false)
            {
                BorderAntwort7.Visibility = Visibility.Hidden;
                ButtonAntwort7.Visibility = Visibility.Hidden;
            }
        }

        private void ButtonsTextReset()
        {
            ButtonAntwort1.Visibility = Visibility.Visible;
            ButtonAntwort1.Content = "Antwort 1";
            ButtonAntwort2.Visibility = Visibility.Visible;
            ButtonAntwort2.Content = "Antwort 2";
            ButtonAntwort3.Visibility = Visibility.Visible;
            ButtonAntwort3.Content = "Antwort 3";
            ButtonAntwort4.Visibility = Visibility.Visible;
            ButtonAntwort4.Content = "Antwort 4";
            ButtonAntwort5.Visibility = Visibility.Visible;
            ButtonAntwort5.Content = "Antwort 5";
            ButtonAntwort6.Visibility = Visibility.Visible;
            ButtonAntwort6.Content = "Antwort 6";
            ButtonAntwort7.Visibility = Visibility.Visible;
            ButtonAntwort7.Content = "Antwort 7";
        }

        private async void GameStartup()
        {
            ListBoxGame.Items.Clear();
            ListBoxGame.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            ListBoxGame.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            ListBoxGame.Items.Add("BOOTING...");
            ListBoxGame.Items.Add("");
            await Task.Delay(500);
            ListBoxGame.Items.Add("HIMEM testet den erweiterten Speicher:");
            ListBoxGame.Items.Add("");
            await Task.Delay(1000);
            ListBoxGame.Items.Clear();
            ListBoxGame.Items.Add("BOOTING...");
            ListBoxGame.Items.Add("");
            ListBoxGame.Items.Add("HIMEM testet den erweiterten Speicher: Result OK...");
            ListBoxGame.Items.Add("");
            await Task.Delay(1500);
            ListBoxGame.Items.Add("Starting KMA-DOS...");
            await Task.Delay(1500);
            ListBoxGame.Items.Clear();
            ListBoxGame.Items.Add("<<   KMA-DOS V1.0 --- Retro Data Viewer (© Copyright HAA-Productions 2022)   >>");
            ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
            await Task.Delay(1500);
            ListBoxGame.Items.Add("Autostart...");
            ListBoxGame.Items.Add(@"C:\FrageAntwortSpiel.exe");
            ListBoxGame.Items.Add("");
            await Task.Delay(500);
            ListBoxGame.Items.Add("Loading");
            await Task.Delay(500);
            ListBoxGame.Items.Clear();
            ListBoxGame.Items.Add("<<   KMA-DOS V1.0 --- Retro Data Viewer (© Copyright HAA-Productions 2022)   >>");
            ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
            ListBoxGame.Items.Add("Autostart...");
            ListBoxGame.Items.Add(@"C:\FrageAntwortSpiel.exe");
            ListBoxGame.Items.Add("");
            ListBoxGame.Items.Add("Loading .");
            await Task.Delay(500);
            ListBoxGame.Items.Clear();
            ListBoxGame.Items.Add("<<   KMA-DOS V1.0 --- Retro Data Viewer (© Copyright HAA-Productions 2022)   >>");
            ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
            ListBoxGame.Items.Add("Autostart...");
            ListBoxGame.Items.Add(@"C:\FrageAntwortSpiel.exe");
            ListBoxGame.Items.Add("");
            ListBoxGame.Items.Add("Loading . .");
            await Task.Delay(500);
            ListBoxGame.Items.Clear();
            ListBoxGame.Items.Add("<<   KMA-DOS V1.0 --- Retro Data Viewer (© Copyright HAA-Productions 2022)   >>");
            ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
            ListBoxGame.Items.Add("Autostart...");
            ListBoxGame.Items.Add(@"C:\FrageAntwortSpiel.exe");
            ListBoxGame.Items.Add("");
            ListBoxGame.Items.Add("Loading . . .");
            await Task.Delay(1500);
            ListBoxGame.Items.Clear();
            LabelStartup.Visibility = Visibility.Visible;
            LabelStartup.Content = ">>     3     <<";
            await Task.Delay(1000);
            LabelStartup.Content = ">>     2     <<";
            await Task.Delay(1000);
            LabelStartup.Content = ">>     1     <<";
            await Task.Delay(1000);
            LabelStartup.Content = ">>  LOS!  <<";
            await Task.Delay(1000);
            LabelStartup.Visibility = Visibility.Hidden;
        }

        private void StandardValues()
        {
            ListBoxGame.Items.Clear();
            helfer.BlockClear();
            antwort = null;
            z = 1;
            x = 0;
        }

        private void ListBoxFill()
        {
            ListBoxGame.Items.Add("<<   KMA-DOS V1.0 --- Retro Data Viewer (© Copyright HAA-Productions 2022)   >>");
            ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------");
            foreach (string frage in helfer.GetBlockList())
            {
                ListBoxGame.Items.Add(frage);                // listBox wird mit der ganzen Liste(FragenListe) gefüllt (Eine Zeile in FragenListe entspricht ein Item in ListBox)
            }
        }

        private void Ergebnis()
        {
            if (helfer.AntwortRichtig == true)
            {
                ListBoxGame.Items.Clear();
                ListBoxGame.Items.Add("<<   KMA-DOS V1.0 --- Retro Data Viewer (© Copyright HAA-Productions 2022)   >>");
                ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
                ListBoxGame.Items.Add("Die Antwort is richtig, du Streber..\r\n");
                ListBoxGame.Items.Add("Bitte Weiter Button drücken...");
            }
            else if (helfer.AntwortRichtig == false)
            {
                ListBoxGame.Items.Clear();
                ListBoxGame.Items.Add("<<   KMA-DOS V1.0 --- Retro Data Viewer (© Copyright HAA-Productions 2022)   >>");
                ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
                ListBoxGame.Items.Add("Die Antwort is falsch.. Da hast du wohl bei Herrn Mertens nicht richtig aufgepasst..\r\n");
                ListBoxGame.Items.Add("Bitte Weiter Button drücken...");
            }
            else
            {
                ListBoxGame.Items.Clear();
                MessageBox.Show("Upps, da ist wohl was schief gelaufen...\r\nDas Programm wird beendet..!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
        }

        private void EndErgebnis()
        {
            TimeSpan gesamtzeit = endzeit - startzeit;
            ListBoxGame.Items.Clear();
            ListBoxGame.Items.Add("<<   KMA-DOS V1.0 --- Retro Data Viewer (© Copyright HAA-Productions 2022)   >>");
            ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
            ListBoxGame.Items.Add("Dein Endergebnis:\r\n");
            ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
            ListBoxGame.Items.Add($"Richtige Antworten:    \" {helfer.RichtigeAntworten} \"  von möglichen  \" {helfer.AntwortListe.Count} \"  Antworten!");
            ListBoxGame.Items.Add($"Benötigte Zeit:            \" {gesamtzeit.Seconds + (gesamtzeit.Minutes * 60)} \"  Sekunden!\r\n");
            ListBoxGame.Items.Add("----------------------------------------------------------------------------------------------------------------\r\n");
            ListBoxGame.Items.Add(">>    Start    <<     Mystery-Retro-Machine neu starten...\r\n");
            ListBoxGame.Items.Add(">> Beenden <<     Mystery-Retro-Machine beenden...");
        }

        private async void PressStartAnimation(bool pressStartGeklickt)
        {
            while (pressStartGeklickt == false)
            {
                LabelPressStart.Content = "Drücke Start";
                await Task.Delay(350);
                LabelPressStart.Content = "Drücke Start.";
                await Task.Delay(350);
                LabelPressStart.Content = "Drücke Start..";
                await Task.Delay(350);
                LabelPressStart.Content = "Drücke Start..!";
                await Task.Delay(350);
                LabelPressStart.Content = "Drücke Start..!!";
                await Task.Delay(350);
                LabelPressStart.Content = "Drücke Start..!!!";
                await Task.Delay(350);
                LabelPressStart.Content = "";
                await Task.Delay(350);
                LabelPressStart.Content = "Drücke Start..!!!";
                await Task.Delay(350);
                LabelPressStart.Content = "";
                await Task.Delay(350);
                LabelPressStart.Content = "Drücke Start..!!!";
                await Task.Delay(350);
                LabelPressStart.Content = "";
                await Task.Delay(350);
                LabelPressStart.Content = "Drücke Start..!!!";
                await Task.Delay(350);
                LabelPressStart.Content = "";
                await Task.Delay(350);
            }
            if (pressStartGeklickt == true)
            {
                LabelPressStart.Visibility = Visibility.Hidden;
                ListBoxGame.Visibility = Visibility.Visible;
            }            
        }

        private void ExitButtonGame_Click(object sender, RoutedEventArgs e)
        {
            StandardValues();
            helfer.BlockClear();
            Close();
        }
    }
}
