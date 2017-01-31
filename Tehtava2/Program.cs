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
using System.Collections;
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
            int Rivimaara = 0;
            int NimienMaara = 0;
            var LaskeNimet = new Dictionary<string, int>();

            foreach (String s in File.ReadAllLines(@"C:\Users\K1539\Source\Repos\TTOS0200-LABRA-7\TTOS0200-LABRA-7\test.txt"))
            {
                if (LaskeNimet.ContainsKey(s))
                {
                    LaskeNimet[s] = LaskeNimet[s] + 1;
                }
                else
                {
                    LaskeNimet.Add(s, 1);
                    NimienMaara++;
                }
                Rivimaara++;
            }

            Console.WriteLine("Rivejä löytyi {0} kappaletta ja {1} nimeä", Rivimaara, NimienMaara);
            // and printing
            foreach (var pair in LaskeNimet)
            {
                Console.WriteLine("Nimi {0} esiintyy {1} kertaa", pair.Key, pair.Value);
            }
            var AakkostettuLista = LaskeNimet.Keys.ToList();
            AakkostettuLista.Sort();
            Console.WriteLine();
            Console.WriteLine("Rivejä löytyi {0} kappaletta ja {1} sortattua nimeä", Rivimaara, NimienMaara);
            foreach (var key in AakkostettuLista)
            {
                Console.WriteLine("Nimi {0} esiintyy {1} kertaa", key, LaskeNimet[key]);
            }




        }
    }

}
