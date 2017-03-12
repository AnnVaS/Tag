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
                     
            Game game = new Game(1,2,3,4,5,6,7,8,0);
                                 
            Console.Clear();
            while (!(game.CheckWin() == true))
            {
                Console.WriteLine("Игра началась!\n");
                game.Print();
                Console.Write("Введите число, стоящее рядом с нулем,чтобы поменять их местами: ");
                int value = Convert.ToInt32(Console.ReadLine());                
            }
            Console.ReadLine();
        }
    }
}
