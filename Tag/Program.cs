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

            Printer.PrintBoard(game);

            try
            {
                game.Shift(15);
                Printer.PrintBoard(game);
                game.Shift(11);
                Printer.PrintBoard(game);
                game.Shift(6);
                Printer.PrintBoard(game);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
        }       
    }
}
