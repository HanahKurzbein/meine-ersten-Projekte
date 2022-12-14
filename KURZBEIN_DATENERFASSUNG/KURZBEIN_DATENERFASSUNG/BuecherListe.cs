using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURZBEIN_DATENERFASSUNG
{
    public class BuecherListe
    {
        private List<Buch> buecher = new List<Buch>();                              // Klasse BuecherListe, wo die Bücher in einer Liste gespeichert sind (temporär, nur solange das Programm ausgeführt wird)
        public List<Buch> Buecher { get => buecher; set => buecher = value; }       // Liste mit Buechern öffentlich sichtbar
        public BuecherListe()                                                       // Zur Erstellung eines öffentlich sichtbaren Objektes
        {

        }
    }
}