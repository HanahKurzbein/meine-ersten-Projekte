using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURZBEIN_DATENERFASSUNG
{
    public class Helferlein
    {
        private BuecherListe buecherListe = new BuecherListe();                                                                                 // Neues BuecherListen-Objekt Namens buecherListe
        private Buch selectedBuch;                                                                                                              // Deklarieren von einer Buch-Variablen Namens selectedBuch in dieser Klasse

        public BuecherListe BuecherListe { get => buecherListe; set => buecherListe = value; }                                                  // BuecherListen-Objekt öffentlich sichtbar
        public Buch SelectedBuch { get => selectedBuch; set => selectedBuch = value; }                                                          // Buch-Variable öffentlich sichtbar

                                                                                                                                                // Helferlein -1-
        public List<Buch> GetBuecher()                                                                                                          // Job = Liste mit Büchern auslesen...
        {
            return buecherListe.Buecher.ToList();                                                                                               // ...und weitergeben
        }

                                                                                                                                                // Helferlein -2-
        public void AddBuch(string Titel, string Autor, string Erscheinungsjahr, string Originaltitel, string Genre)                            // Job = Buch erstellen mit vorgegebenen Angaben...
        {
            Buch buch = new Buch(Titel, Autor, Erscheinungsjahr, Originaltitel, Genre);                                                         // ...neues Buch erstellen...
            buecherListe.Buecher.Add(buch);                                                                                                     // ...und in die BuecherListe speichern
        }

                                                                                                                                                // Helferlein -3-
        public void DeleteBuch(Buch selectedBuch)                                                                                               // Job = Lösche das ausgewählte Buch...
        {
            buecherListe.Buecher.Remove(selectedBuch);                                                                                          // ...aus der BuecherListe
        }

                                                                                                                                                // Helferlein -4-
        public void EditBuch(Buch selectedBuch, string Titel, string Autor, string Erscheinungsjahr, string Originaltitel, string Genre)        // Job = Bearbeite das ausgewählte Buch...
        {
            buecherListe.Buecher.Remove(selectedBuch);                                                                                          // ...dazu lösche das ausgewählte Buch in der BuecherListe...
            Buch buch = new Buch( Titel, Autor, Erscheinungsjahr, Originaltitel, Genre);                                                        // ...neues Buch mit geänderten Daten erstellen...
            buecherListe.Buecher.Add(buch);                                                                                                     // ...und in die BuecherListe speichern
        }
    }
}