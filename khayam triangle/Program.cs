using System;

namespace khayam_triangle
{
    class Program
    {
        public static void Pascal(int n)
        {
            for (int row = 0; row < n; row++)
            {
                int column = 1;
                for (int i = 0; i < n - row; i++)
                {
                    Console.Write("   ");
                }

                for (int j = 0; j <= row; j++)
                {
                    Console.Write("   {0:D} ", column);
                    column = column * (row - j) / (j + 1);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter  number of row you want to see: ");
            int num = int.Parse(Console.ReadLine());

            Pascal(num);

            Console.ReadKey();
        }
    }
}
