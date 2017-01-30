/*Tehtävä 2 - Tiedoston lukeminen ja tietojen lajittelu home Kotitehtävä
 * 
Tee ohjelma, joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä ja kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy. 
Kopioi (tai luo itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi tarkistamaan onko em.hakemistossa tiedostoa.Käytä File.Exist-metodia. 
Huomioi myös muut mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.

Esimerkkitulostus:


	Löytyi 20 riviä, ja 9 nimeä.
	Nimi Aappo esiintyy 4 kertaa
	Nimi Benkku esiintyy 2 kertaa
	Nimi Jaakko esiintyy 3 kertaa
	Nimi Wille esiintyy 4 kertaa
	Nimi Sebastian esiintyy 1 kertaa
	Nimi Cecilia esiintyy 2 kertaa
	Nimi Netta esiintyy 2 kertaa
	Nimi Matias esiintyy 1 kertaa
	Nimi Otto esiintyy 1 kertaa
	Press any key to continue . . .
    
Bonustehtävä: Lajittele nimet aakkosjärjestykseen ennen tulostusta.


	Löytyi 20 riviä, ja 9 nimeä sortattuna:
	Nimi Aappo esiintyy 4 kertaa
	Nimi Benkku esiintyy 2 kertaa
	Nimi Cecilia esiintyy 2 kertaa
	Nimi Jaakko esiintyy 3 kertaa
	Nimi Matias esiintyy 1 kertaa
	Nimi Netta esiintyy 2 kertaa
	Nimi Otto esiintyy 1 kertaa
	Nimi Sebastian esiintyy 1 kertaa
	Nimi Wille esiintyy 4 kertaa
	Press any key to continue . . .
    *
    * Jere Liikka 30.1.2017
    */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int counter = 0;
                string line;
                //avataan tiedosto ja luetaan sitä rivi riviltä.
                System.IO.StreamReader file =
                   new System.IO.StreamReader(@" D:\Temp\test.txt");
                while ((line = file.ReadLine()) != null)
                {
                    counter++;
                    Dictionary<string, int> dictionary =
                new Dictionary<string, int>();

                    dictionary.Add(line, 1);

                    // See whether Dictionary contains this string.
                    if (dictionary.ContainsKey(line))
                    {
                        Console.WriteLine(line);
                    }

                }
                file.Close();
                Console.WriteLine("Rivejä löytyi yhteensä {0} kappaletta.", counter);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
         
         
            
        }
    }

}
