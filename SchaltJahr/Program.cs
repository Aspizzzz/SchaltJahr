using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchaltJahr
{
    class Program
    {
        // static void Main(string[] args)
        //{
        // int Jahr;
        //Console.WriteLine("Schaltjahre sollen bestimt werden.");
        //Console.WriteLine("Ein Jahr eingeben.");
        //Jahr = Convert.ToInt32(Console.ReadLine());

        //Vergleiche : gleich ==; ungleich !=; größer  >;
        //kleiner <; 

        //Bedingugen verknüpfen:
        //and &&; or ||;
        //(a==1 && b==2)
        //(a==1 || b==2)

        //if (Jahr % 4 == 0 && (Jahr % 100 != 0 || Jahr % 400 == 0) )
        //  {
        //Console.WriteLine("Das Jahr " + Jahr + " ist ein Schaltjahr.");
        //Console.WriteLine ("Das Jahr " { 0 } " ist ein Schaltjahr.");
        // }
        //else
        //{
        //Console.WriteLine("Das Jahr ist kein Schalrtjaht.");
        //}


        static void Main(string[] args)
        {
            double AnzahlReiskörner, Feld, Masse, MasseReiskorn, WahreMasse;
            Console.WriteLine("Masse der Reiskörner auf dem Feld erraten.");
            Console.WriteLine("Feld angeben:");
            Feld = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masse schätzen:");
            Masse = Convert.ToDouble(Console.ReadLine());
            MasseReiskorn = 0.00005;
            AnzahlReiskörner = Math.Pow(2.0, Feld - 1);
            WahreMasse = MasseReiskorn * AnzahlReiskörner;
            if (Masse == WahreMasse)
            {
                Console.WriteLine("Richtig geschätzt...");
                Console.WriteLine("Die wahre Masse ist " + WahreMasse);
            }
            else if (Masse < WahreMasse)
            {
                Console.WriteLine("Zuwenig geschätzt...");

            }
            else
            {
                Console.WriteLine("Zuviel geschätzt...");
            }
        }

    }
}

        








