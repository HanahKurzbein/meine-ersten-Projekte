using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILE_FOLDER_INVENTORY
{
    public class Helferlein
    {
        private OrdnerListe ordnerListe = new OrdnerListe();
        private Ordner selectedOrdner;

        public OrdnerListe OrdnerListe { get => ordnerListe; set => ordnerListe = value; }
        public Ordner SelectedOrdner { get => selectedOrdner; set => selectedOrdner = value; }

        // Helferlein -1-
        public List<Ordner> GetAllordner()
        {
            return ordnerListe.Allordner.ToList();
        }

        // Helferlein -2-
        public void AddOrdner(string Ordner_Nr, string Raum, string Regal, string Ebene, string Abteilung, string Abteilungsleiter, string Beschriftung, string Erfasst_am, string Erfasst_durch, string Status_, string Jahr, string Auftrags_Nr)
        {
            Ordner ordner = new Ordner(Ordner_Nr, Raum, Regal, Ebene, Abteilung, Abteilungsleiter, Beschriftung, Erfasst_am, Erfasst_durch, Status_, Jahr, Auftrags_Nr);
            ordnerListe.Allordner.Add(ordner);
        }

        // Helferlein -3-
        public void DeleteOrdner(Ordner selectedOrdner)
        {
            ordnerListe.Allordner.Remove(selectedOrdner);
        }

        // Helferlein -4-
        public void EditOrdner(Ordner selectedOrdner, string Ordner_Nr, string Raum, string Regal, string Ebene, string Abteilung, string Abteilungsleiter, string Beschriftung, string Erfasst_am, string Erfasst_durch, string Status_, string Jahr, string Auftrags_Nr)
        {
            ordnerListe.Allordner.Remove(selectedOrdner);
            Ordner ordner = new Ordner(Ordner_Nr, Raum, Regal, Ebene, Abteilung, Abteilungsleiter, Beschriftung, Erfasst_am, Erfasst_durch, Status_, Jahr, Auftrags_Nr);
            ordnerListe.Allordner.Add(ordner);
        }
    }
}
