using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDing
{
    class DatenAbfrage
    {
        public static void RegLog() // Abfrage ob man sich einloggen oder regestrieren möchte
        {
            Console.WriteLine("Wollen sie sich einloggen oder regestrieren? (Reg/Log)");
            string JaNein = Console.ReadLine();
            string UpperString = JaNein.ToUpper();
            if (UpperString == "LOG") // Login
            {
                Console.WriteLine("Geben sie nun ihr Benutzernamen ein");
                string Benutzername = LoginName(); // TODO: Methode LoginName() eigentlich unnötig, alternative: "" = Console.Readline()
                bool JaNein2 = EingabeValid(Benutzername);
                Console.WriteLine("Geben sie nun ihr Passwort ein");
                string Passwort = LoginPasswort(); // TODO: Methode LoginPasswort() eigentlich unnötig, alternative: "" = Console.Readline()
                bool JaNein3 = EingabeValid(Passwort); 
                if (JaNein2 && JaNein3)
                {
                    Login.Log(Benutzername, Passwort);
                }
                else
                {
                    Console.WriteLine("Sie müssen Mindestens ein Zeichen eingeben.");
                    RegLog();
                }

            }
            else if (UpperString == "REG") // Regestrieren
            {
                Console.WriteLine("Geben sie nun ihren gewünschten Benutzernamen ein");
                string Benutzername = RegName();
                bool JaNein2 = EingabeValid(Benutzername);
                Console.WriteLine("Geben sie nun ihr gewünschtes Passwort ein");
                string Passwort = RegPasswort();
                bool JaNein3 = EingabeValid(Passwort);
                if (JaNein2 && JaNein3)
                {
                    Reg.Register(Benutzername, Passwort);                    
                }
                else
                {
                    Console.WriteLine("Sie müssen Mindestens ein Zeichen eingeben.");
                    RegLog();
                }
            }
            else
            {
                Console.WriteLine("Falsche eingabe");
                RegLog();
            }
        }

        private static bool EingabeValid(string Passwort) // Check ob Eingabe ist korrekt (Mindestens 1 Zeiche)
        {
            bool JaNein = false;
            if (Passwort == "")
            {
                JaNein = false;
            }
            else
            {
                JaNein = true;
            }

            return JaNein;
        }


        private static string LoginName() // Abfrage Name
        {
            string BenutzerEingabe;            
            BenutzerEingabe = Console.ReadLine();
            return BenutzerEingabe;
        }
         
        private static string LoginPasswort() // Abfrage Passwort
        {
            string BenutzerEingabe;
            BenutzerEingabe = Console.ReadLine();
            return BenutzerEingabe;
        }

        private static string RegName() // Abfrage Name
        {
            string RegDaten;
            RegDaten = Console.ReadLine();
            return RegDaten;
        }

        private static string RegPasswort() // Abfrage Passwort
        {
            string RegDaten;
            RegDaten = Console.ReadLine();
            return RegDaten;
        }
        // TODO: letzten 4 Methoden überflüssig.

    }
}
