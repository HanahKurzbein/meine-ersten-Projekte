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
    public partial class Form2 : Form
    {
        private Helferlein helfer = new Helferlein();                                                                                                                       // Neues Helferlein-Objekt Namens helfer
        private bool buchAendern = false;                                                                                                                                   // Eine bool-Variable Namens buchAendern deklarieren mit Standard false gesetzt

        public Helferlein Helfer { get => helfer; set => helfer = value; }                                                                                                  // Helferlein-Objekt öffentlich sichtbar
        public bool BuchAendern { get => buchAendern; set => buchAendern = value; }                                                                                         // bool-Variable öffentlich sichtbar

        public Form2(Helferlein helfer, bool buchAendern)                                                                                                                   // Bei Aufruf von Form2 werden die Helfer und der bool-Wert (true oder false) übergeben
        {
            InitializeComponent();
            Helfer = helfer;                                                                                                                                                // Das Helferlein-Objekt Namens Helfer ist gleich dem Objekt helfer hier in Form2 
            if (buchAendern == true)                                                                                                                                        // Abfrage nach bool-Wert von buchAendern...
            {                                                                                                                                                               // ...wenn Ja dann...
                if (helfer.SelectedBuch != null)                                                                                                                            // ...wenn Ja (Ausgewähltes-Buch ungleich NULL -es ist also eins ausgewählt in der ListBox-)
                {
                    BuchAendern = true;                                                                                                                                     // bool-Wert von BuchAendern auf true gesetzt
                    textBoxTitel.Text = helfer.SelectedBuch.Titel;                                                                                                          // Die TextFelder...
                    textBoxAutor.Text = helfer.SelectedBuch.Autor;                                                                                                          // ...bekommen ihren...
                    textBoxErscheinungsjahr.Text = helfer.SelectedBuch.Erscheinungsjahr;                                                                                    // ...jeweiligen Text...
                    textBoxOriginaltitel.Text = helfer.SelectedBuch.Originaltitel;                                                                                          // ...von dem...
                    textBoxGenre.Text = helfer.SelectedBuch.Genre;                                                                                                          // ...ausgewählten Buch
                }
                else                                                                                                                                                        // Wenn Nein und in jedem anderen Fall...
                {
                    MessageBox.Show("Es wurde kein Buch ausgewählt!", "Leere Eingabemaske", MessageBoxButtons.OK, MessageBoxIcon.Warning);                                  // gib einen Hinweis in einem PopUp aus
                }
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (BuchAendern == true)                                                                                                                                        // Abfrage nach bool-Wert von BuchAendern...
            {                                                                                                                                                               // ...wenn Ja dann...
                Helfer.EditBuch(helfer.SelectedBuch, textBoxTitel.Text, textBoxAutor.Text, textBoxErscheinungsjahr.Text, textBoxOriginaltitel.Text, textBoxGenre.Text);     // Helferlein -4- bekommt einen Job (Bearbeite das ausgewählte Buch in den TextFeldern)
                MessageBox.Show("Daten wurden gespeichert", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);                                                   // Hinweis PopUp
                textBoxTitel.Clear();                                                                                                                                       // Die TextFelder...
                textBoxAutor.Clear();                                                                                                                                       // ...werden alle...
                textBoxErscheinungsjahr.Clear();                                                                                                                            // ...einzeln...
                textBoxOriginaltitel.Clear();                                                                                                                               // ...nacheinander...
                textBoxGenre.Clear();                                                                                                                                       // ...geleert
                Close();                                                                                                                                                    // Form2 wird geschlossen
            }
            else
            {                                                                                                                                                               // Wenn Nein und in jedem anderen Fall...
                Helfer.AddBuch(textBoxTitel.Text, textBoxAutor.Text, textBoxErscheinungsjahr.Text, textBoxOriginaltitel.Text, textBoxGenre.Text);                           // Helfer -2- bekommt einen Job (Erstelle ein Buch mit den TextFeld-Eingaben)
                MessageBox.Show("Daten wurden gespeichert", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);                                                   // Hinweis PopUp
                textBoxTitel.Clear();                                                                                                                                       // Die TextFelder...
                textBoxAutor.Clear();                                                                                                                                       // ...werden alle...
                textBoxErscheinungsjahr.Clear();                                                                                                                            // ...einzeln...
                textBoxOriginaltitel.Clear();                                                                                                                               // ...nacheinander...
                textBoxGenre.Clear();                                                                                                                                       // ...geleert, damit die Form2 offen bleibt und sofort das nächste Buch eingegeben werden kann
            }
            
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();                                                                                                                                                        // Form2 wird geschlossen
        }
    }
}
