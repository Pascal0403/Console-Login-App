using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoginDing
{
    class DatenBank
    {  
         public static void Filesave(string Benutzername, string Passwort) // Speicherung der Daten in der File
        {
            string SystemBenutzer = Environment.UserName;
            string SaveDaten = Benutzername + Passwort + Environment.NewLine;
            string path = @"C:\Users\" + SystemBenutzer + @"\Documents\PascalProgramm\Daten.txt"; // Daten
            bool JaNein = BenutzernameVerify(Benutzername);
            if (JaNein)
            {
                Console.WriteLine("BenutzerName schon vergeben");
            }
            else
            {
                File.AppendAllText(path, SaveDaten);
                Console.WriteLine("Daten erfolgreich gespeichert.");
            }
            DatenAbfrage.RegLog();
        }
        
        private static bool BenutzernameVerify(string Benutzername) // Verifizierung ob Benutzername schon vergeben ist
        {
            string SystemBenutzer = Environment.UserName;
            bool JaNein = false;
            string SaveBenutzername = Benutzername + Environment.NewLine;
            string path = @"C:\Users\" + SystemBenutzer + @"\Documents\PascalProgramm\NamenDaten.txt"; // Namen
            foreach (string line in File.ReadLines(path))
            {
                if (line.Contains(Benutzername))
                {
                    JaNein = true;
                    return JaNein;                   
                }                
            }
            File.AppendAllText(path, SaveBenutzername);
            JaNein = false;               
            return JaNein;
        }
        
        public static bool Verify(string Benutzername, string Passwort) // Login Daten Überprüfen ob richtig
        {
            string SystemBenutzer = Environment.UserName;
            string path = @"C:\Users\" + SystemBenutzer + @"\Documents\PascalProgramm\Daten.txt"; // daten.Txt
            string Benutzerdaten = Benutzername + Passwort;
            bool JaNein = false;
            foreach (string line in File.ReadLines(path))
            {
                if (line.Contains(Benutzerdaten))
                {
                    JaNein = true;
                    break;
                }
            }
            return JaNein;
        }                    
    }

}
