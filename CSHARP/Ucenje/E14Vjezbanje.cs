using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ucenje
{
    internal class E14Vjezbanje
    {
        public static void Izvedi()
        {
            Console.WriteLine("Dobrodosli u vjezbanje petkom");
            Izbornik();
            Console.WriteLine("Hvala na koristenju dovidenja");

        }


        private static void Izbornik()
        {
            string[] programi = {
                "parnost broja",
                "tablica mnozenja",
                "jedinicna vrijednost",
                "broj znakova naziva mjesta"


            };

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");

            for (int i = 0; i < programi.Length; i++)
            {
                Console.WriteLine("{0}. {1}",i+1,programi[i]);
            }


            Console.WriteLine("0. Izlaz iz programa");
            OdabirOpcijeIzbronika(programi.Length);


        }

        private static void OdabirOpcijeIzbronika(int brojprograma )
        {
            switch (E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika", 0, brojprograma))
            {
                case 0:
                    break;
                case 1:
                    parnostbroja();
                    Izbornik();
                    break;
                case 2:
                    TablicaMnozenja();
                    Izbornik();
                    break;
				case 3:
					Jedinicnavrijednost();
					Izbornik();
					break;
                    case 4:
                    brojznakovanazivamjesta();
                    Izbornik();
                    break;




			}
        }

        private static void brojznakovanazivamjesta()
        {
            NaslovPrograma("za uneseni naziv mjesta ispisuje koliko ima znakova");

            string ime = E12Metode.UcitajString("unesi ime grada");
                Console.WriteLine(ime.Length);


		}

        private static void Jedinicnavrijednost()
        {
           
        }

        private static void TablicaMnozenja()
        {
            
            NaslovPrograma("Program koji za dane brojebe redaka i stupaca generira tablicu mnozenja");
            int redaka = E12Metode.UcitajCijeliBroj("Unesi broj redaka:", 2, 10);
			int stupaca = E12Metode.UcitajCijeliBroj("Unesi broj stupaca: ", 2, 10);
            for (int i = 1; i <= redaka; i++)
            {
                for (int j = 1; j <= stupaca; j++)
                {
                    Console.Write("{0,4}" ,i*j);
                }
                Console.WriteLine();
			}
            
		}
        
        private static void parnostbroja()
        {
            NaslovPrograma("program koji provjerava da li je unesen broj paran ili ne");
            int broj = E12Metode.UcitajCijeliBroj("Unesi cijeli boj: ");
            if (broj % 2 == 0)
            {
                Console.WriteLine("Uneseni broj {0} je PARAN", broj);

            }
            else
            {
                Console.WriteLine("Uneseni broj {0} je NEPARAN", broj);







            }
        }
        private static void NaslovPrograma(string naslov)
        {

            for (int i = 0; i < naslov.Length; i++)

                Console.WriteLine("*");


            Console.WriteLine();
            Console.WriteLine("naslov");
            Console.WriteLine("*******");
        }


		private static void Naglasinaslov(int komada)
		{
			for (int i = 0; i < komada; i++)
			{
				Console.WriteLine("--");
				
			}
			Console.WriteLine();

		}
















	}
}
