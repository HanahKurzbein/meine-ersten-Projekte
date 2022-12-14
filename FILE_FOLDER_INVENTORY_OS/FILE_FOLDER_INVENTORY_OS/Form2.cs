using System;
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
    public partial class Form2 : Form
    {
        private Helferlein helfer = new Helferlein();
        private bool ordnerAendern = false;

        public Helferlein Helfer { get => helfer; set => helfer = value; }
        public bool OrdnerAendern { get => ordnerAendern; set => ordnerAendern = value; }

        public Form2(Helferlein helfer, bool ordnerAendern)
        {
            InitializeComponent();
            Helfer = helfer;
            if (ordnerAendern == true)
            {
                if (helfer.SelectedOrdner != null)
                {
                    OrdnerAendern = true;
                    textBoxOrdner_Nr.Text = helfer.SelectedOrdner.Ordner_Nr;
                    textBoxRaum.Text = helfer.SelectedOrdner.Raum;
                    textBoxRegal.Text = helfer.SelectedOrdner.Regal;
                    textBoxEbene.Text = helfer.SelectedOrdner.Ebene;
                    textBoxAbteilung.Text = helfer.SelectedOrdner.Abteilung;
                    textBoxAbteilungsleiter.Text = helfer.SelectedOrdner.Abteilungsleiter;
                    textBoxBeschriftung.Text = helfer.SelectedOrdner.Beschriftung;
                    textBoxErfasst_am.Text = helfer.SelectedOrdner.Erfasst_am;
                    textBoxErfasst_durch.Text = helfer.SelectedOrdner.Erfasst_durch;
                    textBoxStatus_.Text = helfer.SelectedOrdner.Status_;
                    textBoxJahr.Text = helfer.SelectedOrdner.Jahr;
                    textBoxAuftrags_Nr.Text = helfer.SelectedOrdner.Auftrags_Nr;
                }
                else
                {
                    MessageBox.Show("Es wurde kein Ornder ausgewählt!", "Leere Eingabemaske", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {

            if (OrdnerAendern == true)
            {
                Helfer.EditOrdner(helfer.SelectedOrdner, textBoxOrdner_Nr.Text, textBoxRaum.Text, textBoxRegal.Text, textBoxEbene.Text, textBoxAbteilung.Text, textBoxAbteilungsleiter.Text, textBoxBeschriftung.Text, textBoxErfasst_am.Text, textBoxErfasst_durch.Text, textBoxStatus_.Text, textBoxJahr.Text, textBoxAuftrags_Nr.Text);
                MessageBox.Show("Daten wurden gespeichert", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxenClear();
                Close();

            }
            else
            {
                Helfer.AddOrdner(textBoxOrdner_Nr.Text, textBoxRaum.Text, textBoxRegal.Text, textBoxEbene.Text, textBoxAbteilung.Text, textBoxAbteilungsleiter.Text, textBoxBeschriftung.Text, textBoxErfasst_am.Text, textBoxErfasst_durch.Text, textBoxStatus_.Text, textBoxJahr.Text, textBoxAuftrags_Nr.Text);
                MessageBox.Show("Daten wurden gespeichert", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxenClear();

            }
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TextBoxenClear()
        {
            textBoxOrdner_Nr.Clear();
            textBoxRaum.Clear();
            textBoxRegal.Clear();
            textBoxEbene.Clear();
            textBoxAbteilung.Clear();
            textBoxAbteilungsleiter.Clear();
            textBoxBeschriftung.Clear();
            textBoxErfasst_am.Clear();
            textBoxErfasst_durch.Clear();
            textBoxStatus_.Clear();
            textBoxJahr.Clear();
            textBoxAuftrags_Nr.Clear();
        }

        private void textBoxAbteilungsleiter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

    
   

