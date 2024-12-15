using System;

namespace _3keer5Getallen
{
    internal class Program
    {
        private static int[] _array1 = new int[5];
        private static int[] _array2 = new int[5];
        private static int[] _array3 = new int[5];
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("=== Som maken van getallen uit 2 arrays ===");
            Console.WriteLine();
            Console.WriteLine();

           
            Console.Write("Array 1 ==> ");
            for (int i = 0; i < 5; i++)
            {
                _array1[i] = rnd.Next(0, 11); 
                Console.Write($"{_array1[i]}\t");
            }

            Console.Write("\nArray 2 ==> ");
            for (int i = 0; i < 5; i++)
            {
                _array2[i] = rnd.Next(0, 11); 
                Console.Write($"{_array2[i]}\t");
            }

            Console.Write("\nArray 3 ==> ");
            for (int i = 0; i < 5; i++)
            {
                _array3[i] = _array1[i] + _array2[i];
                Console.Write($"{_array3[i]}\t");
            }
            Console.ReadKey(true);
        }
    }
}
