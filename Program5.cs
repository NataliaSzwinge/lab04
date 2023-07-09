using System;
namespace cw5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 52, 67, 33, 4, 22 };
            Sortowanie(array);
            Console.WriteLine("Posortowana tablica ");
            Wyswietlanie(array);
        }
        static void Sortowanie(int[] array)
        {
            int dlugosc = array.Length;
            for(int i = 0; i < dlugosc-1; i++)
            {
                int liczbaMin = i;
                for(int j = i+1; j < dlugosc; j++)
                {
                    if (array[j] < array[liczbaMin])
                    {
                        liczbaMin = j;
                    }
                }
                int temp = array[liczbaMin];
                array[liczbaMin] = array[i];
                array[i] = temp;
            }
        }
        static void Wyswietlanie(int[] array)
        {
            int dlugosc = array.Length;
            for(int i = 0; i < dlugosc; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}