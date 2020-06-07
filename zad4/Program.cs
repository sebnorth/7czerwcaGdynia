using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static int PodwojPierwszyElement(int[] tab) {
            return 2 * tab[0];
        }

        static int Podwojelement(int[] tab, int indeks) {
            return 2 * tab[indeks];
        }

        static void Main(string[] args)
        {
            int[] array = { -1, -10, -100 };
            //Console.WriteLine(PodwojPierwszyElement(array));
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(Podwojelement(array, i));
            }

            int j = 0;
            foreach (int item in array)
            {
                Console.WriteLine(Podwojelement(array, j));
                j++;
            }

            Console.ReadKey();
        }
    }
}
