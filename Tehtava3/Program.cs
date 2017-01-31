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
            System.IO.StreamWriter outputFile = null;
            int i;
            float f;
            Console.Write("Give a number : ");
            value = Console.ReadLine();

            if (int.TryParse(value, out i))
            {
                Console.WriteLine("intti");
                Console.WriteLine(i);
                outputFile = new System.IO.StreamWriter(@"intti.txt");
                outputFile.WriteLine(i);
            }

            else if (float.TryParse(value, out f))
            {
                Console.WriteLine("floatti");
                outputFile = new System.IO.StreamWriter(@"float.txt");
                outputFile.WriteLine(f);
            }
            else
            {
                Console.WriteLine("ei kumpakaan");
            }
            outputFile.Close();
        }
    }
}
