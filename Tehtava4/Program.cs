/*
 * Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia. 
 * TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, kanava (jolta ohjelma tulee), alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta. 
 * Luo pääohjelmassa muutamia TV-ohjelmaolioita (tiedot voit alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä) ja tallenna ne levylle. 
 * Mieti käytätkö jotain tietorakennetta apunasi. Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville.
 * 
 * Jere Liikka 31.1.2017
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;
using System.IO;

namespace JAMK.IT
{
    class Program
    {
        static void Main()
        {
           
            System.IO.StreamWriter outputFile = null;
            try
            { 
                outputFile = new System.IO.StreamWriter("Ohjelmatiedot.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löydy (FileNotFoundException)");
            }
            //
            Ohjelma ohjelma1 = new Ohjelma();
            ohjelma1.Nimi = "Pikku kakkonen";
            ohjelma1.Kanava = "YleTV2";
            ohjelma1.AlkuJaLoppuAika = "17:00 - 18:00";
            ohjelma1.Info = "Tänään vuorossa pipsa possu, late lammas ja kaapo.";
            //
            Ohjelma ohjelma2 = new Ohjelma();
            ohjelma2.Nimi = "Kaunarit";
            ohjelma2.Kanava = "MTV3";
            ohjelma2.AlkuJaLoppuAika = "17:25 - 18:00";
            ohjelma2.Info = "Ridge löytää uuden puolen itsestään.";
            
            //
            Ohjelma ohjelma3 = new Ohjelma();
            ohjelma3.Nimi = "Hauskat kotivideot";
            ohjelma3.Kanava = "Nelonen";
            ohjelma3.AlkuJaLoppuAika = "20:00 - 21:00";
            ohjelma3.Info = "Sampo Marjomaa keksi uuden vitsin.";
            //
            try
            {
                outputFile.WriteLine("Ohjelman nimi: {0}, Kanava: {1}, Aika: {2}, info: {3}", ohjelma1.Nimi, ohjelma1.Kanava, ohjelma1.AlkuJaLoppuAika, ohjelma1.Info);
                outputFile.WriteLine("Ohjelman nimi: {0}, Kanava: {1}, Aika: {2}, info: {3}", ohjelma2.Nimi, ohjelma2.Kanava, ohjelma2.AlkuJaLoppuAika, ohjelma2.Info);
                outputFile.WriteLine("Ohjelman nimi: {0}, Kanava: {1}, Aika: {2}, info: {3}", ohjelma3.Nimi, ohjelma3.Kanava, ohjelma3.AlkuJaLoppuAika, ohjelma3.Info);
                outputFile.Close();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Tiedostoon ei ole kirjoitusoikeuksia!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löydy!");
            }
            catch (Exception)
            {
                Console.WriteLine("VIRHE");
            }
            //Tiedoston lukeminen
            try
            {
                string TulostaSisalto = File.ReadAllText("Ohjelmatiedot.txt");
                Console.WriteLine(TulostaSisalto);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Tiedostoon ei ole kirjoitusoikeuksia!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löydy!");
            }
            catch (Exception)
            {
                Console.WriteLine("VIRHE");
            }



        }
    }
}
