using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game(4);

            PrintBoard(game);

            try
            {
                game.Shift(15);
                PrintBoard(game);
                game.Shift(11);
                PrintBoard(game);
                game.Shift(6);
                PrintBoard(game);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
        }

        private static void PrintBoard(Game game)
        {
            int a = 0;
            int b = 0;
            for (a = 0; a < 4; a++)
            {
                for (b = 0; b < 4; b++)
                    Console.Write(game[a, b] + "\t");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
