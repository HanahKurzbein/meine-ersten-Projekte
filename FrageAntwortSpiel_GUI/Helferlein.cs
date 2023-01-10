using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace FrageAntwortSpiel_GUI
{
    public class Helferlein
    {
        private List<string> fragenListe = new List<string>();
        private List<string> fragenBlock = new List<string>();
        private List<string> antwortListe = new List<string>();
        private List<string> infoListe = new List<string>();
        private bool btnVisibleAntwort4;
        private bool btnVisibleAntwort5;
        private bool btnVisibleAntwort6;
        private bool btnVisibleAntwort7;
        private int richtigeAntworten;
        private bool antwortRichtig;
        private bool getDarkMode;
        private string selectedString;
        private int a = 0;
        private int b = 0;
        private int c = 0;
        private int d = 0;
        
        public List<string> FragenListe { get => fragenListe; set => fragenListe = value; }
        public List<string> FragenBlock { get => fragenBlock; set => fragenBlock = value; }
        public List<string> AntwortListe { get => antwortListe; set => antwortListe = value; }
        public List<string> InfoListe { get => infoListe; set => infoListe = value; }
        public int RichtigeAntworten { get => richtigeAntworten; set => richtigeAntworten = value; }
        public bool AntwortRichtig { get => antwortRichtig; set => antwortRichtig = value; }
        public bool BtnVisibleAntwort4 { get => btnVisibleAntwort4; set => btnVisibleAntwort4 = value; }
        public bool BtnVisibleAntwort5 { get => btnVisibleAntwort5; set => btnVisibleAntwort5 = value; }
        public bool BtnVisibleAntwort6 { get => btnVisibleAntwort6; set => btnVisibleAntwort6 = value; }
        public bool BtnVisibleAntwort7 { get => btnVisibleAntwort7; set => btnVisibleAntwort7 = value; }
        public bool GetDarkMode { get => getDarkMode; set => getDarkMode = value; }
        public string SelectedString { get => selectedString; set => selectedString = value; }
        
        public Helferlein()
        {
            // Dieser Konstruktor bleibt leer
        }
        public void Einlesen()
        {
            foreach (string line in System.IO.File.ReadLines("..\\..\\FRAGEN.TXT"))
            {

                string frage = line.ToString();                // Liest jede Zeile aus und macht einen String daraus und packt es in die Variable frage
                FragenListe.Add(frage);                        // Und packt es in die FragenListe, solange bis keine Zeile mehr da ist
                if (frage.Contains($"{a}{b}{c}{d}9"))                // falls Fragen.TXT die Zeile "frage" mit einer 9 beinhaltet 
                {
                    AntwortListe.Add(frage);                   // soll die Zeile in die AntwortListe gepackt werden  
                    d++;
                    //NineToZeroCounter(a, b, c, d);                    
                }
            }
        }

        public void InfoEinlesen()
        {
            foreach (string line in System.IO.File.ReadLines("..\\..\\INFO.TXT"))
            {
                string info = line.ToString();
                InfoListe.Add(info);
            }
        }

        public void BackUpEinlesen()
        {
            fragenListe.Clear();
            foreach (string line in System.IO.File.ReadLines("..\\..\\BACKUP.TXT"))
            {
                string frage = line.ToString();
                FragenListe.Add(frage);
                if (frage.Contains($"{a}{b}{c}{d}9")) 
                {
                    AntwortListe.Add(frage); 
                    d++;
                    //NineToZeroCounter(a, b, c, d);
                }
            }
        }

        public List<string> GetInfoList()
        {
            return InfoListe.ToList();
        }

        public List<string> GetFullList()
        {
            return FragenListe.ToList();
        }
        public List<string> GetBlockList()
        {
            return FragenBlock.ToList();                                    // GetList nimmt die FragenListe und gibt sie zurück/weiter
        }

        public void FragenBlöcke(int d, int e)                                            // Bildet die FragenBlöcke und übergibt in den Klammern Variable
        {
            BtnVisibleAntwort4 = false;
            btnVisibleAntwort5 = false;
            btnVisibleAntwort6 = false;
            btnVisibleAntwort7 = false;
            foreach (string line in FragenListe)                                           // Für jede Zeile in der FragenListe
            {
                if (line.Contains($"{a}{b}{c}{d}{e}") & !line.Contains($"{a}{b}{c}{d}9"))               // Wenn in FragenListe 000 enthalten ist & wenn(solange) in FragenListe keine 9 enthalten ist
                {
                    if (!line.Contains($"{a}{b}{c}{d}1"))
                    {
                        if (line.Contains($"{a}{b}{c}{d}5"))
                        {
                            FragenBlock.Add(line);
                            BtnVisibleAntwort4 = true;
                            e++;                            
                        }
                        else if (line.Contains($"{a}{b}{c}{d}6"))
                        {
                            FragenBlock.Add(line);
                            BtnVisibleAntwort5 = true;
                            e++;
                        }
                        else if (line.Contains($"{a}{b}{c}{d}7"))
                        {
                            FragenBlock.Add(line);
                            BtnVisibleAntwort6 = true;
                            e++;
                        }
                        else if (line.Contains($"{a}{b}{c}{d}8"))
                        {
                            FragenBlock.Add(line);
                            BtnVisibleAntwort7 = true;
                            e++;
                        }
                        else
                        {
                            FragenBlock.Add(line);
                            e++;
                        }                        
                    }
                    else if (line.Contains($"{a}{b}{c}{d}1"))
                    {
                        FragenBlock.Add(line);
                    }
                }
                else if (line.Contains($"{a}{b}{c}{d}2") & !line.Contains($"{a}{b}{c}{d}9"))
                {
                    FragenBlock.Add(line);
                    e = 3;
                }
                //else if (line.Contains($"{a}{b}{c}{d}9"))
                //{
                //    NineToZeroCounter(a, b, c, d);
                //}
            }
        }
        public void FBLöschen()
        {
            fragenBlock.Clear();                                           // Liste wird gereinigt, bleibt aber ohne Einträge bestehen.
        }

        public void AntwortenVergleich(string antwort)
        {
            AntwortRichtig = false;
            foreach (string zahlen in AntwortListe)
            {
                if (zahlen == antwort)
                {
                    AntwortRichtig = true;
                    RichtigeAntworten++;
                }
            }
        }

        //private (int a, int b, int c, int d) NineToZeroCounter(int a, int b, int c, int d)
        //{
        //    if (d > 9)
        //    {
        //        d = 0;
        //        c++;
        //        return (a, b, c, d);
        //    }
            
        //    if (c > 9)
        //    {
        //        c = 0;
        //        b++;
        //        return (a, b, c, d);
        //    }

        //    if (b > 9)
        //    {
        //        b = 0;
        //        a++;
        //        return (a, b, c, d);
        //    }
        //    return (a, b, c, d);
        //}

        public void AllClear()
        {
            fragenListe.Clear();
            fragenBlock.Clear();
            antwortListe.Clear();
            richtigeAntworten = 0;
        }

        public void BlockClear()
        {
            fragenBlock.Clear();
            richtigeAntworten = 0;
        }
    }
}
