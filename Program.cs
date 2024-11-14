namespace GeneryczneSortowanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 2, 1, 3, 7, 4, 2 ,0, 6, 9};
            double[] doubleArray = { 5.7, 14.0, 6.9, 1.2, 42.0 };

            Console.WriteLine("(intArray) = ");
            Sortowanie.Wypisz(intArray);
            Sortowanie.Sort(ref intArray);
            Console.WriteLine("Posortowane: ");
            Sortowanie.Wypisz(intArray);

            Console.WriteLine("(doubleArray) = ");
            Sortowanie.Wypisz(doubleArray);
            Sortowanie.Sort(ref doubleArray);
            Console.WriteLine("Posortowane: ");
            Sortowanie.Wypisz(doubleArray);
        }
    }
}
