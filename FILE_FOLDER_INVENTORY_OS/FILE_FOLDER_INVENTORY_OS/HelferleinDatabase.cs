using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FILE_FOLDER_INVENTORY
{
    public class HelferleinDatabase
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        private Helferlein helfer = new Helferlein();

        public Helferlein Helfer { get => helfer; set => helfer = value; }

        public void Connect()
        {
            string constring = $"Provider=MSOLEDBSQL; Data Source=cidcsqltest01; Initial Catalog=FILE_FOLDER_INVENTORY; Trusted_Connection=yes;";
            con.ConnectionString = constring;
            con.Open();
            cmd.Connection = con;
        }

        public void Disconnect()
        {
            con.Close();
        }

        public List<Ordner> ReadAllordner()
        {
            List<Ordner> allordner = new List<Ordner>();
            cmd.CommandText = $"SELECT Ordner_Nr, Raum, Regal, Ebene, Abteilung, Abteilungsleiter, Beschriftung, Erfasst_am, Erfasst_durch, Status_, Jahr, Auftrags_Nr FROM FILE_FOLDER;";
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Ordner ordner = new Ordner();
                ordner.Ordner_Nr = reader[0].ToString();
                ordner.Raum = reader[1].ToString();
                ordner.Regal = reader[2].ToString();
                ordner.Ebene = reader[3].ToString();
                ordner.Abteilung = reader[4].ToString();
                ordner.Abteilungsleiter = reader[5].ToString();
                ordner.Beschriftung = reader[6].ToString();
                ordner.Erfasst_am = reader[7].ToString();
                ordner.Erfasst_durch = reader[8].ToString();
                ordner.Status_ = reader[9].ToString();  
                ordner.Jahr = reader[10].ToString();
                ordner.Auftrags_Nr = reader[11].ToString();
                allordner.Add(ordner);
            }
            return allordner;
        }

        public void BackupDB()
        {
            cmd.CommandText = $"IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'FILE_FOLDER_Backup')) BEGIN DROP TABLE FILE_FOLDER_Backup END;";
            reader = cmd.ExecuteReader();
            Disconnect();
            Connect();
            cmd.CommandText = $"SELECT * INTO FILE_FOLDER_Backup FROM FILE_FOLDER;";
            reader = cmd.ExecuteReader();
            MessageBox.Show("Es wurde ein Backup der Datenbank angelegt", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SendAllordner(Helferlein Helfer)
        {
            cmd.CommandText = $"DELETE FROM FILE_FOLDER;";
            reader = cmd.ExecuteReader();
            Disconnect();
            Connect();
            foreach (Ordner ordner in Helfer.GetAllordner())
            {
                cmd.CommandText = $"INSERT INTO FILE_FOLDER (Ordner_Nr, Raum, Regal, Ebene, Abteilung, Abteilungsleiter, Beschriftung, Erfasst_am, Erfasst_durch, Status_, Jahr, Auftrags_Nr) VALUES ('{ordner.Ordner_Nr}', '{ordner.Raum}', '{ordner.Regal}', '{ordner.Ebene}', '{ordner.Abteilung}', '{ordner.Abteilungsleiter}', '{ordner.Beschriftung}', '{ordner.Erfasst_am}', '{ordner.Erfasst_durch}','{ordner.Status_}','{ordner.Jahr}','{ordner.Auftrags_Nr}');";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
