/*
 * Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto. 
 * Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. 
 * Huomioi mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.

Esimerkkitulostus:


    Give a text line (enter ends) : Matti
    Give a text line (enter ends) : Teppo
    Give a text line (enter ends) : Seppo
    Give a text line (enter ends) : Jorma
    Give a text line (enter ends) :
    
    Contents of T1TextLines.txt:
    Matti
    Teppo
    Seppo
    Jorma
    *
    * Jere Liikka 30.1.2017
    */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.StreamWriter outputFile = null;
            try
            {
                string Input;
                outputFile = new System.IO.StreamWriter(@"test.txt");
                while (true)
                {
                    Console.Write("Give a text line ( enter ends), Press just enter to close this app : ");
                    Input = Console.ReadLine();
                    if (Input == "")
                    { break; }
                    outputFile.WriteLine(Input);
                }
                outputFile.Close();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Opened stream is null (ArgumentNullException)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Opened stream is not writable (ArgumentException)");
            }
            catch (IOException)
            {
                Console.WriteLine("An IO error happend (IOException)");
            }
            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
            ////////
            try
            {
                int counter = 0;
                string line;
                //avataan tiedosto ja luetaan sitä rivi riviltä.
                System.IO.StreamReader file =
                   new System.IO.StreamReader("test.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }
                file.Close();
                Console.ReadLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }

           

           
        }
    }
}
