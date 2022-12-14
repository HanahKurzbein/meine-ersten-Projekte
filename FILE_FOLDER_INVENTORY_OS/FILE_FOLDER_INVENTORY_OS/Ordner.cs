using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILE_FOLDER_INVENTORY
{
    public class Ordner
    {
        private string ordner_Nr;
        private string raum;
        private string regal;
        private string ebene;
        private string abteilung;
        private string abteilungsleiter;
        private string beschriftung;
        private string erfasst_am;
        private string erfasst_durch;
        private string status_;
        private string jahr;
        private string auftrags_Nr;

        public string Ordner_Nr { get => ordner_Nr; set => ordner_Nr = value; }
        public string Raum { get => raum; set => raum = value; }
        public string Regal { get => regal; set => regal = value; }
        public string Ebene { get => ebene; set => ebene = value; }
        public string Abteilung { get => abteilung; set => abteilung = value; }
        public string Abteilungsleiter { get => abteilungsleiter; set => abteilungsleiter = value; }
        public string Beschriftung { get => beschriftung; set => beschriftung = value; }
        public string Erfasst_am { get => erfasst_am; set => erfasst_am = value; }
        public string Erfasst_durch { get => erfasst_durch; set => erfasst_durch = value; }
        public string Status_ { get => status_; set => status_ = value; }
        public string Jahr { get => jahr; set => jahr = value; }
        public string Auftrags_Nr { get => auftrags_Nr; set => auftrags_Nr = value; }



        public Ordner()
        {

        }

        public Ordner(string Ordner_Nr, string Raum, string Regal, string Ebene, string Abteilung, string Abteilungsleiter, string Beschriftung, string Erfasst_am, string Erfasst_durch, string Status_, string Jahr, string Auftrags_Nr)
        {
            this.Ordner_Nr = Ordner_Nr;
            this.Raum = Raum;
            this.Regal = Regal;
            this.Ebene = Ebene;
            this.Abteilung = Abteilung;
            this.Abteilungsleiter = Abteilungsleiter;
            this.Beschriftung = Beschriftung;
            this.Erfasst_am = Erfasst_am;
            this.Erfasst_durch = Erfasst_durch;
            this.Status_ = Status_;
            this.Jahr = Jahr;
            this.Auftrags_Nr = Auftrags_Nr;
        }

       
    }
}
