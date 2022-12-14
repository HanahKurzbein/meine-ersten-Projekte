using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURZBEIN_DATENERFASSUNG
{
    public class Buch
    {                                                                                                           // Klasse Buch mit allen variablen (der Bauplan für 1 Buch)
        private string titel;
        private string autor;
        private string erscheinungsjahr;
        private string originaltitel;
        private string genre;
        private Buch selectedBuch;                                                                              // Variable für ausgewähltes Buch in der ListBox in dieser Klasse

        public string Titel { get => titel; set => titel = value; }                                             // Alles öffentlich sichtbar
        public string Autor { get => autor; set => autor = value; }
        public string Erscheinungsjahr { get => erscheinungsjahr; set => erscheinungsjahr = value; }
        public string Originaltitel { get => originaltitel; set => originaltitel = value; }
        public string Genre { get => genre; set => genre = value; }
        public Buch SelectedBuch { get => selectedBuch; set => selectedBuch = value; }

        public Buch()                                                                                           // Zur Erstellung eines öffentlich sichtbaren Objektes
        {

        }

        public Buch(string Titel, string Autor, string Erscheinungsjahr, string Originaltitel, string Genre)    // Zur Erstellung eines öffentlich sichtbaren Objektes mit vorgegebenen Inhalt
        {
            this.Titel = Titel;
            this.Autor = Autor;
            this.Erscheinungsjahr = Erscheinungsjahr;
            this.Originaltitel = Originaltitel;
            this.Genre = Genre;
        }
    }
}
