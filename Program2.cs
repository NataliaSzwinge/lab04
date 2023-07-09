using System;
namespace cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayRandom = new int[10];
            Random rnd = new Random();
            int liczbaMinRnd = arrayRandom[0];
            int liczbaMaxRnd = arrayRandom[0];
            for (int i = 0; i < 10; i++)
            {
                arrayRandom[i] = rnd.Next(10);
            }
            foreach (int item in arrayRandom)   //kontrolne wypisanie zawortosci tabeli
            {
                Console.WriteLine(item);
            }
            for(int i =1; i < arrayRandom.Length; i++)
            {
                if (arrayRandom[i] < liczbaMinRnd)
                {
                    liczbaMinRnd = arrayRandom[i];
                }
                if (arrayRandom[i] > liczbaMaxRnd)
                {
                    liczbaMaxRnd = arrayRandom[i];
                }
            }
            Console.WriteLine("Najmniejsza liczba to " + liczbaMinRnd + " a najwieksza to " + liczbaMaxRnd);

            //wersja na sztywnych wartosciach tabeli
            
            //int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int liczbaMax = array[0];
            //int liczbaMin = array[0];
            //for(int i = 1;  i < array.Length; i++)
            //{
            //    if (array[i] < liczbaMin)
            //    {
            //        liczbaMin = array[i];
            //    }
            //    if (array[i] > liczbaMax)
            //    {
            //        liczbaMax = array[i];
            //    }
            //}
            //Console.WriteLine("Najmniejsza liczba to " + liczbaMin + " a najwieksza to " + liczbaMax);
        }
    }
}