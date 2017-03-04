using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDing
{
    class DatenAbfrage
    {
        public static void RegLog()
        {
            Console.WriteLine("Wollen sie sich einloggen oder regestrieren? (Reg/Log)");
            string JaNein = Console.ReadLine();
            string UpperString = JaNein.ToUpper();
            if (UpperString == "LOG")
            {
                Console.WriteLine("Geben sie nun ihr Benutzernamen ein");
                string Benutzername = LoginName();
                bool JaNein2 = EingabeValidPasswort(Benutzername);
                Console.WriteLine("Geben sie nun ihr Passwort ein");
                string Passwort = LoginPasswort();
                bool JaNein3 = EingabeValidPasswort(Passwort);
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
            else if (UpperString == "REG")
            {
                Console.WriteLine("Geben sie nun ihren gewünschten Benutzernamen ein");
                string Benutzername = RegName();
                bool JaNein2 = EingabeValidPasswort(Benutzername);
                Console.WriteLine("Geben sie nun ihr gewünschtes Passwort ein");
                string Passwort = RegPasswort();
                bool JaNein3 = EingabeValidPasswort(Passwort);
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

        private static bool EingabeValidPasswort(string Passwort)
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

        private static bool EingabeValidName(string Benutzername)
        {
            bool JaNein = false;
            if (Benutzername == "")
            {
                JaNein = false;
            }
            else
            {
                JaNein = true;
            }

            return JaNein;
        }

        private static string LoginName()
        {
            string BenutzerEingabe;            
            BenutzerEingabe = Console.ReadLine();
            return BenutzerEingabe;
        }

        private static string LoginPasswort()
        {
            string BenutzerEingabe;
            BenutzerEingabe = Console.ReadLine();
            return BenutzerEingabe;
        }

        private static string RegName()
        {
            string RegDaten;
            RegDaten = Console.ReadLine();
            return RegDaten;
        }

        private static string RegPasswort()
        {
            string RegDaten;
            RegDaten = Console.ReadLine();
            return RegDaten;
        }

    }
}
