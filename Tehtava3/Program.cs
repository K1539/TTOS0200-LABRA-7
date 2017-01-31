/*
 * Tehtävä 3 - luvut tiedostoihinhome Kotitehtävä
Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut. 
Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais- tai reaalilukua. Tarkista tiedostojen sisältö jollain tekstieditorilla.

Esimerkkitulostus:


    Give a number (enter or not a number ends) : 1,0
    Give a number (enter or not a number ends) : 2,0
    Give a number (enter or not a number ends) : 3,0
    Give a number (enter or not a number ends) : 4
    Give a number (enter or not a number ends) : 5
    Give a number (enter or not a number ends) : 6
    Give a number (enter or not a number ends) :
    
    Contents of T2Integers.txt:
    4
    5
    6

    Contents of T2Doubles.txt:
    1,0
    2,0
    3,0
    *
    * Jere Liikka 31.1.2017
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            System.IO.StreamWriter intfilu = null;
            System.IO.StreamWriter floatfilu = null;
            int i;
            float f;
            intfilu = new System.IO.StreamWriter(@"intti.txt");
            floatfilu = new System.IO.StreamWriter(@"float.txt");

            while (true)
            {
                Console.Write("Give a number : ");
                value = Console.ReadLine();

                if (int.TryParse(value, out i))
                {
                    Console.WriteLine("intti");
                    Console.WriteLine(i);
                    intfilu.WriteLine(i);
                }

                else if (float.TryParse(value, out f))
                {
                    Console.WriteLine("floatti");
                    floatfilu.WriteLine(f);
                }
                else
                {
                    break;
                }
                
            }
            floatfilu.Close();
            intfilu.Close();

            //Tulosta tiedostojen tiedot
            try
            {
                int counter = 0;
                string line;
                //avataan tiedosto ja luetaan sitä rivi riviltä.
                Console.WriteLine("Contents of intti.txt");
                System.IO.StreamReader intfile =
                   new System.IO.StreamReader("intti.txt");
                while ((line = intfile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
                intfile.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            try
            {
                int counter = 0;
                string line;
                //avataan tiedosto ja luetaan sitä rivi riviltä.
                Console.WriteLine("Contents of float.txt");
                System.IO.StreamReader floatfile =
                   new System.IO.StreamReader("float.txt");
                while ((line = floatfile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
                floatfile.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
