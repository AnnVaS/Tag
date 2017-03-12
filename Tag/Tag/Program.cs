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
                     
            Game game = new Game(1,2,3,0);            

            while (game.CheckWin() == false)
            {
                //Console.Clear();
                Console.WriteLine("Игра началась!\n");
                game.Print();
                Console.Write("Введите число, стоящее рядом с нулем,чтобы поменять их местами: ");
                int value = Convert.ToInt32(Console.ReadLine());
                game.GetLocation(value);
                game.Shift();
                Console.Clear();
            } 
            Console.ReadLine();
        }
    }
}
