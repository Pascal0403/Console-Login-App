using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDing
{
    class Reg
    {
        public static void Register(string Benutzername, string Passwort)
        {
            DatenBank.Filesave(Benutzername, Passwort);
        }
    }
}
// TODO: Methode nicht nötig