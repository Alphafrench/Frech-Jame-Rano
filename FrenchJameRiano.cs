using System;

namespace StarDavid
{
    internal class Program
    {
        static void StarDavid(int row)
        {
            int r = row * 4;
            r++;

            int maxWidth = row * 6 + 1;
            string row_star = new string('*', maxWidth);

            int col = row_star.Length / 2 + 1;
            int temp = col;
            int prog = -1;

            Console.WriteLine();
            for (int x = 0; x < r; x++, col++)
            {
                
                Console.Write(new string(' ', 38));

                if (r / 4 <= x)
                {
                    prog++;
                }

                for (int y = 0; y < row_star.Length; y++)
                {
                    if (r / 4 == x || r * 3 / 4 == x || col - 1 == y || temp - 1 - x == y || (y == prog || y == row_star.Length - 1 - prog))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            
            StarDavid(5); 
            
            Console.ReadLine();
        }
    }
}