using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURZBEIN_DATENERFASSUNG
{
    public partial class Form1 : Form
    {
        private Helferlein helfer = new Helferlein();                                                                                       // Neues Helferlein-Objekt Namens helfer
        private Buch selectedBuch;                                                                                                          // Deklarieren von einer Buch-Variablen Namens selectedBuch in dieser Klasse
        public Helferlein Helfer { get => helfer; set => helfer = value; }                                                                  // Helferlein-Objekt öffentlich sichtbar
        public Buch SelectedBuch { get => selectedBuch; set => selectedBuch = value; }                                                      // Buch-Variable öffentlich sichtbar
        public Form1()                                                                                                                      // Aufruf von der MainForm Namens Form1
        {
            InitializeComponent();
        }
        private void btnEinfügen_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Helfer, false);                                                                                         // Aufruf von Form2 Namens form2 mit Übergabe Helfer und (BuchAendern) false
            form2.ShowDialog();                                                                                                             // Form2 als Dialog(!) öffnen
            BuecherListBoxReload();                                                                                                         // ListBox-Daten werden neu geladen zum anzeigen in der ListBox
        }
        private void btnÄndern_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Helfer, true);                                                                                          // Aufruf von Form2 Namens form2 mit Übergabe Helfer und (BuchAendern) true
            form2.ShowDialog();                                                                                                             // Form2 als Dialog(!) öffnen
            BuecherListBoxReload();                                                                                                         // ListBox-Daten werden neu geladen zum ausgeben in der ListBox
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            helfer.DeleteBuch(helfer.SelectedBuch);                                                                                         // Helferlein -3- bekommt einen Job (lösche das ausgewählte Buch in der BuecherListe)
            BuecherListBoxReload();                                                                                                         // ListBox-Daten werden neu geladen zum ausgeben in der ListBox
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programm wurde beendet!\r\nAuf Wiedersehen..", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);   // Hinweis PopUp
            Application.Exit();                                                                                                             // Das Programm wird beendet
        }

        public void BuecherListBoxReload()                 
        {
            listBox1.Items.Clear();                                                                                                         // ListBox wird geleert / keine Daten mehr angezeigt
            foreach (Buch buch in helfer.GetBuecher())                                                                                      // Helferlein -1- bekommt einen Job (alle Bücher in der BuecherListe auslesen)
            {
                listBox1.Items.Add($"{buch.Titel} | {buch.Autor} | {buch.Erscheinungsjahr} | {buch.Originaltitel} | {buch.Genre}");         // Für jedes gefundene Buch eine Zeile mit den Daten in der ListBox ausgeben
            }
            listBox1.ClearSelected();                                                                                                       // Die Auswahl in der ListBox wird zurückgesetzt
            helfer.SelectedBuch = null;                                                                                                     // Die Auswahl die Übergeben wurde wird zurückgesetzt

        }

        public Buch CheckBuch(Buch selectedBuch)                                                                                            // Wird die Funktion CheckBuch aufgerufen wird das ausgewählte Buch-Objekt mit übergeben
        {
            foreach (Buch buch in helfer.GetBuecher())                                                                                      // Helferlein -1- bekommt einen Job (alle Bücher in der BuecherListe auslesen)
            {
                if (listBox1.SelectedItem != null)                                                                                          // ...wenn ein Buch ausgewählt ist...
                {
                    helfer.SelectedBuch = helfer.BuecherListe.Buecher.ElementAt(listBox1.SelectedIndex);                                    // ...merke dir welches das ist...
                    return buch;                                                                                                            // ...und gib es jedem bekannt
                }
            }
            return null;                                                                                                                    // Sollte kein Buch ausgewählt sein geb bescheid mit NULL
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)                                                                                              // Ist ein Buch in der ListBox ausgewählt...
            {
                selectedBuch = helfer.BuecherListe.Buecher.ElementAt(listBox1.SelectedIndex);                                               // ...merke dir welches...
                CheckBuch(selectedBuch);                                                                                                    // ...und führe damit die Funktion CheckBuch aus
            }
        }
    }
}
