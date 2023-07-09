using System;
namespace cw4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 34, 12, 64, 13, 94 };
            Sortowanie(array);
            Wyswietlanie(array);
        }
        static void Sortowanie(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = current;
            }
        }
        static void Wyswietlanie(int[] array)
        {
            Console.WriteLine("Posortowana tablica ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}