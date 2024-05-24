using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int n = 3;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse( Console.ReadLine() );

            }
            foreach (var item in a)
            {
                Console.WriteLine(item);                
            }
            Console.ReadLine();
            */
            /*
            int n = 2;
            int[] a = new int[n];
            int i = 0;
            while (i < n)
            {
                Console.Write($"a[{i}]: ");
                a[i] = int.Parse( Console.ReadLine() );              
                if (a[i] >= 0 && a[i]<10) {
                    i++;
                }
            }
            foreach (var item in a)
            {
                Console.Write($"{item}\n");                
            }
            Console.ReadLine();
            */

            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] voti = new int[n];
            string[] cognomi = new string[n];
            bool errore = true;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Cognome[{i}]: ");
                cognomi[i] = Console.ReadLine();
                errore = true;
                do
                {
                    Console.WriteLine($"Voto[{cognomi[i]}]: ");
                    voti[i] = int.Parse(Console.ReadLine());
                    if (voti[i] > 0 && voti[i] <= 10)
                    { errore = false; }
                    else
                    { Console.WriteLine("Il voto non puo essere maggiore di 10"); }

                } while (errore);
            }
            for (int i = 0; i<n;i++)
            {
                Console.Write($"\nCognome {cognomi[i]}\nVoto: {voti[i]} ");
            }
            Console.ReadLine();
            
        }
    }
}
