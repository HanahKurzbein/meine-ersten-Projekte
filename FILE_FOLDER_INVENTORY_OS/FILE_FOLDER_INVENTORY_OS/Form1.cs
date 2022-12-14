using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILE_FOLDER_INVENTORY
{
    public partial class Form1 : Form
    {
        private HelferleinDatabase helferDb = new HelferleinDatabase();
        private Helferlein helfer = new Helferlein();
        private Ordner selectedOrdner;
        public HelferleinDatabase HelferDb { get => helferDb; set => helferDb = value; }
        public Helferlein Helfer { get => helfer; set => helfer = value; }
        public Ordner SelectedOrdner { get => selectedOrdner; set => selectedOrdner = value; }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(@"..\..\..\..\Ordner.txt", true);
            CultureInfo region = new CultureInfo("de-DE");
            DateTime lokalesDatum = DateTime.Now;
            string ausgabe = string.Format($"{lokalesDatum.ToString(region)} - Ausgewählter Ordner zum abspeichern und drucken");
            streamWriter.WriteLine(ausgabe);
            if (listBox1.SelectedItem != null)
            {
                string ordnerAusgabe = listBox1.SelectedItem.ToString();
                streamWriter.WriteLine(ordnerAusgabe);
            }
            else
            {
                string ordnerAusgabe = string.Format("Es wurde kein Ordner ausgewählt..!");
                streamWriter.WriteLine(ordnerAusgabe);
            }
            streamWriter.Close();
            MessageBox.Show("Der ausgewählte Ordner wurde gespeichert", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEinfügen_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Helfer, false);
            form2.ShowDialog();
            AllordnerListBoxReload();
        }

        private void btnÄndern_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(Helfer, true);
            form2.ShowDialog();
            AllordnerListBoxReload();
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            helfer.DeleteOrdner(helfer.SelectedOrdner);
            AllordnerListBoxReload();
        }
        private void AllordnerListBoxReload()
        {
            listBox1.Items.Clear();
            foreach (Ordner ordner in helfer.GetAllordner())
            {
                listBox1.Items.Add($"{ordner.Ordner_Nr},{ordner.Raum},{ordner.Regal},{ordner.Ebene},{ordner.Abteilung},{ordner.Abteilungsleiter},{ordner.Beschriftung},{ordner.Erfasst_am}, {ordner.Erfasst_durch},{ordner.Status_},{ordner.Jahr},{ordner.Auftrags_Nr}");
            }
            listBox1.ClearSelected();
            helfer.SelectedOrdner = null;

        }
        private Ordner CheckOrdner(Ordner selectedOrdner)
        {
            foreach (Ordner ordner in helfer.GetAllordner())
            {
                if (listBox1.SelectedItem != null)
                {
                    helfer.SelectedOrdner = helfer.OrdnerListe.Allordner.ElementAt(listBox1.SelectedIndex);
                    return ordner;
                }
            }
            return null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                SelectedOrdner = helfer.OrdnerListe.Allordner.ElementAt(listBox1.SelectedIndex);
                CheckOrdner(selectedOrdner);
            }
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programm wurde beendet!\r\nAuf Wiedersehen..", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void buttonDBget_Click(object sender, EventArgs e)
        {

            HelferDb.Connect();
            List<Ordner> allordner = new List<Ordner>();
            foreach (Ordner ordner in HelferDb.ReadAllordner())
            {
                allordner.Add(ordner);
            }
            helfer.OrdnerListe.Allordner = allordner;
            HelferDb.Disconnect();
            MessageBox.Show("Daten wurden aus der Datenbank geladen", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AllordnerListBoxReload();
            btnDBsend.Visible = true;
            btnEinfügen.Visible = true;
            btnPrintSelected.Visible = true;
            btnPrintList.Visible = true;
        }

        private void btnDBsend_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Daten zur Datenbank senden...\r\nSind Sie sich sicher..?", "Hinweis", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                helferDb.Connect();
                helferDb.BackupDB();
                helferDb.Disconnect();
                helferDb.Connect();
                helferDb.SendAllordner(Helfer);
                helferDb.Disconnect();
                MessageBox.Show("Daten wurden zur Datenbank gesendet", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Vorgang abgebrochen", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter(@"..\..\..\..\Ordnerliste.txt", true);
            CultureInfo region = new CultureInfo("de-DE");
            DateTime lokalesDatum = DateTime.Now;
            string ausgabe = string.Format($"{lokalesDatum.ToString(region)} - Ordnerliste zum abspeichern und drucken");
            streamWriter.WriteLine(ausgabe);
            foreach (object item in listBox1.Items)
            {
                string listeAusgabe = item.ToString();
                streamWriter.WriteLine(listeAusgabe);
            }
            streamWriter.Close();
            MessageBox.Show("Die Ordnerliste wurde gespeichert", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormPasswort formPasswort = new FormPasswort();
            formPasswort.ShowDialog();
            if (formPasswort.Pass == true )
            {
                formPasswort.setPassBol(false);
                formPasswort.Close();
                btnLöschen.Visible = true;
                btnÄndern.Visible = true;
            }
        }
    }
}
