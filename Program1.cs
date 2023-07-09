using System;
namespace cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                array[i] = rnd.Next(11);
            }
            for(int i = 5-1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}