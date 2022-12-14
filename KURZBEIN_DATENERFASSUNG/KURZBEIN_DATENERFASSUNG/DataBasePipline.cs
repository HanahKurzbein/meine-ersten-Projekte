using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace KURZBEIN_DATENERFASSUNG
{
    internal class DataBasePipline
    {

        OleDbConnection con = new OleDbConnection();																																									// Neue Verbindung zur DB mit OleDb für SQL
        OleDbCommand cmd = new OleDbCommand();																																											// OleDb soll SQL-Befehle ausführen um mit der DB zu arbeiten
        OleDbDataReader reader;																																															// OleDb soll die Daten in der DB lesen und dafür den reader einsetzen
        internal void Connect()																																															// Zum öffnen der DB auf dem Server
        {
            // IP oder ServerAdresse,Port					Datenbank		 DB-User	   DB-Passwort
            string constring = $"Provider=sqloledb;Data Source=XXX.XXX.XXX.XXX,xxxx;Initial Catalog=XXXxxxXXX;User Id=XXXxxx; Password=XXXxxx;";																		// Serverangaben (am Ende 2x ";" = einmal zum abschließen des SQL-Befehls und einmal zum abschließen des Befehls in C#)
            con.ConnectionString = constring;																																											// Verbindungsdaten angegeben
            con.Open();																																																	// Verbindung öffnen
            cmd.Connection = con;																																														// (Befehle für SQL werden angenommen und weiterverarbeitet)
        }
        internal void Disconnect()																																														// Zum Schließen der DB auf dem Server
        {
            con.Close();																																																// Verbindung schließen
        }

        // 1. Datenbank-Tabelle Buecher
        public List<Buch> GetBuch()																																														// HelferSQL -1-
        {																																																				// Job = "lies alle Buecher in der Liste aus und gib sie weiter"
            List<Buch> buecher = new List<Buch>();																																										// Neue Liste für die Buecher erstellen
            cmd.CommandText = "SELECT Titel, Autor, Erscheinungsjahr, Originaltitel, Genre FROM Buecher;";																												// SQL-Command zum auslesen der Daten in der DB (am Ende 2x ";" = einmal zum abschließen des SQL-Befehls und einmal zum abschließen des Befehls in C#)
            reader = cmd.ExecuteReader();																																												// lies die Daten aus
            while (reader.Read())																																														// Während gelesen wird...
            {
                Buch buch = new Buch();																																													// ...erstelle je ein neues Buch...
                buch.Titel = reader[0].ToString();																																										// ...schreibe den Titel in einen string an 1. Stelle des strings
                buch.Autor = reader[1].ToString();																																										// ...schreibe den Autor in den selben string an 2. Stelle des strings
                buch.Erscheinungsjahr = reader[2].ToString();																																							// ...schreibe das Erscheinungsjahr in den selben string an 3. Stelle des strings
                buch.Originaltitel = reader[3].ToString();                                                                                                                                                              // ...schreibe den Originaltitel in den selben string an 4. Stelle des strings
                buch.Genre = reader[4].ToString();																																										// ...schreibe das Genre in den selben string an 5. Stelle des strings
                buecher.Add(buch);																																														// ...speichere das Buch in der Buecher-Liste
            }
            return buecher;																																																// ...gib die Buecher-Liste weiter damit sie im Programm woanders verwendet werden kann (z.B. zum anzeigen in der ListBox oder ListView etc.)
        }
        public void AddBuch(Buch buch)																																													// HelferSQL -2-
        {																																																				// Job = "speichere das Buch in der Datenbank"
            cmd.CommandText = $"INSERT INTO Buecher (Titel, Autor, Erscheinungsjahr, Originaltitel, Genre) VALUES ('{buch.Titel}','{buch.Autor}','{buch.Erscheinungsjahr}','{buch.Originaltitel}','{buch.Genre}');";	// SQL-Command zum speichern der Daten in der DB (am Ende 2x ";" = einmal zum abschließen des SQL-Befehls und einmal zum abschließen des Befehls in C#)
            cmd.ExecuteNonQuery();																																														// Führe den SQL-Befehl aus
        }
        public void DeleteBuch(Buch buch)																																												// HelferSQL -3-
        {																																																				// Job = "lösche das Buch mit diesen 3 angegebenen Eckdaten"
            cmd.CommandText = $"DELETE FROM Buecher WHERE Titel='{buch.Titel}' AND Autor='{buch.Autor}' AND Erscheinungsjahr='{buch.Erscheinungsjahr}';";																// SQL-Befehl zum löschen von Daten in der DB (am Ende 2x ";" = einmal zum abschließen des SQL-Befehls und einmal zum abschließen des Befehls in C#)
            cmd.ExecuteNonQuery();																																														// Führe den SQL-Befehl aus
        }

        public void UpdateBuch(Buch buch)																																												// HelferSQL -4-
        {																																																				// Job = "führe ein Update der Daten aus bei einem Buch"
            cmd.CommandText = $"UPDATE Buecher SET Erscheinungsjahr = '{buch.Erscheinungsjahr}' WHERE Titel='{buch.Titel}';";																							// SQL-Befehl zum updaten von Daten in der DB (am Ende 2x ";" = einmal zum abschließen des SQL-Befehls und einmal zum abschließen des Befehls in C#)
            cmd.ExecuteNonQuery();																																														// Führe den SQL-Befehl aus
        }
    }
}
