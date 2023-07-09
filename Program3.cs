using System;
namespace cw3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 22, 64, 93, 11, 4 };
            Sortowanie(array);
            Console.WriteLine("Posortowana tablica");
            Wyswietl(array);
        }
        static void Sortowanie(int[] array)
        {
            int dlugosc = array.Length;
            for(int i = 0;  i < dlugosc; i++)
            {
                for(int j = 0; j < dlugosc-i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
        static void Wyswietl(int[] array)
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