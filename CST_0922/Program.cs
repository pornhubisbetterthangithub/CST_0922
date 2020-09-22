using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CST_0922
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
        /*    Console.WriteLine("////////////////////////////2.///////////////////////////////");
            //2.
            int[] tomb = new int[20];
             List<int> szam0 = new List<int>();
             int osszeg = 0;

             for (int i = 0; i < tomb.Length; i++)
             {
                 tomb[i] = rnd.Next(50,151);
                 Console.Write(tomb[i]+" ");
                 osszeg = osszeg + tomb[i];
                 if (tomb[i] % 10 == 0)
                 {
                     szam0.Add(tomb[i]);
                 }
             }

             int atlag = osszeg / 20;
             Console.WriteLine("\n\nÖsszeg: " +osszeg);
             Console.WriteLine("Átlag: " + atlag);
             Console.Write("0-ra végződő számok: " );
             for (int i = 0; i < szam0.Count; i++)
             {

                 Console.Write(szam0[i]+" ");
             }

        */
            //6.
        /*
            Console.WriteLine("\n////////////////////////////6.///////////////////////////////");
            Console.WriteLine("50db random 2 jegyű számok: ");
            int[] t = new int[50];
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = rnd.Next(10, 100);
                Console.Write(t[i] + " ");
            }
        */
            //5.
        /*    Console.WriteLine("\n////////////////////////////5.///////////////////////////////");
            
            int ker = 13;
            bool van = false;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] % 2 == 0)
                {

                }
                else
                {
                    Console.Write(t[i] + " ");
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == ker)
                {
                    van = true;
                }
                
            }
            Console.WriteLine($"\nIgaz-e, hogy van 13-as a tömbben?: {van}");
        */
            Console.WriteLine("\n////////////////////////////1.///////////////////////////////");
            string[] nevTomb = { "Peti", "Panni", "Fanni", "Kati", "Béla" };
            int[] magTomb = new int [5];
            int magassag = 0;
            Console.Write("Neveik:");
            for (int i = 0; i < nevTomb.Length; i++)
            {
                
                Console.Write(nevTomb[i] +" ");
            }
            Console.WriteLine("kérem a magasságukat CM-ben: ");
            for (int i = 0; i < magTomb.Length; i++)
            {
                magassag = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(magassag);
            Console.ReadKey();
        }
    }
}
