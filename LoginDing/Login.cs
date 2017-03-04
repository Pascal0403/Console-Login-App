using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDing
{
    class Login
    {
        public static void Log(string Benutzername, string Passwort)
        {
            bool JaNein = DatenBank.Verify(Benutzername, Passwort);
            if (JaNein)
            {
                Console.WriteLine("Login erfolgreich");
                DatenAbfrage.RegLog();
            }
            else
            {
                Console.WriteLine("Login fehlgeschlagen");
                DatenAbfrage.RegLog();
            }
        }
    }
}
