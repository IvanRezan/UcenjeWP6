using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ucenje
{
    internal class Vjezbanje
    {
        public static void Izvedi()
        {
            //Console.WriteLine("Vjezbanje");
            //Console.WriteLine("Pozdrav Svijetu ćščđ");
            //Console.WriteLine("Hello Osijek");
            //Console.WriteLine("HELLO");
            string Ime = Console.ReadLine();
            //Console.WriteLine(Ime);
            Console.WriteLine("Unesi svoje ime : ");
            Console.WriteLine("Unijeli ste " + Ime);
            Console.WriteLine("Unijeli ste {0}. Bravo! ", Ime);//Formatirani nacin unosa 
        }
    }
}
