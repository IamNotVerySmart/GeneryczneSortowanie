using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneryczneSortowanie
{
    internal class Sortowanie
    {
        public static void Sort<T>(ref T[] tab) where T : IComparable<T>
        {
            for (int i = 0; i < tab.Length; i++)
            {
                T x = tab[i];
                int j = i - 1;
                while (j >= 0 && tab[j].CompareTo(x) > 0)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j + 1] = x;
            }
        }

        private static int P<T>(ref T a, ref T b)
        {
            if (a is IComparable<T> comperable)
            {
                return comperable.CompareTo(b);
            }
            else if (a is IComparable comparable)
            {
                return comparable.CompareTo(b);
            }
            else
            {
                throw new ArgumentException("Typ nie implementuje IComparable.");
            }
        }

        public static void Wypisz<T>(T[] tab)
        {
            foreach (var x in tab)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();
        }
    }
}
