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
            string RegorLog = Console.ReadLine();
            string UpperString = RegorLog.ToUpper();

            if (UpperString == "LOG") // Login
            {
                Console.WriteLine("Geben sie nun ihr Benutzernamen ein");
                string Benutzername = Console.ReadLine();
                bool JaNein2 = EingabeValid(Benutzername);

                Console.WriteLine("Geben sie nun ihr Passwort ein");
                string Passwort = Console.ReadLine(); ;

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
                string Benutzername = Console.ReadLine();
                bool JaNein2 = EingabeValid(Benutzername);
                Console.WriteLine("Geben sie nun ihr gewünschtes Passwort ein");
                string Passwort = Console.ReadLine();
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

    }
}
