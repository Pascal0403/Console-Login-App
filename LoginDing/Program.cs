using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoginDing
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialisieren();
            DatenAbfrage.RegLog();         
        }

        private static void Initialisieren() // Erstellen eines Orderns und 2 .txt Datein zum speichern der Daten
        {
            string Benutzername = Environment.UserName;
            if (!Directory.Exists(@"C:\Users\" + Benutzername + @"\Documents\PascalProgramm"))
            {
                Directory.CreateDirectory(@"C:\Users\"+ Benutzername + @"\Documents\PascalProgramm");
                using (var myFile1 = File.Create(@"C:\Users\" + Benutzername + @"\Documents\PascalProgramm\Daten.txt")) { }
                using (var myFile2 = File.Create(@"C:\Users\" + Benutzername + @"\Documents\PascalProgramm\NamenDaten.txt")) { }                      
            }            
        }
    }
}
