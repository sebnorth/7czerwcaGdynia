using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int wynik = TylkoDodaj.Dodaj(x,y); // przekazuję x i y jako kopie
            Console.WriteLine($"Wynik: {wynik}");
            Console.ReadKey();
        }
    }
}
