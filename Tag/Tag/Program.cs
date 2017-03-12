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

            game.Print();
            

            Console.Write("Играть будем? (да/нет) ");
            string text = Convert.ToString(Console.ReadLine());
            if (text == "Да" || text == "да")
            {             
                Console.Clear();
                game.GenerationField();

                Console.Write("Введите число, которое хотите поменять ");
                int value = Convert.ToInt32(Console.ReadLine());

                game.GetLocation(value);

            }
            else Console.WriteLine("Вы упустили шанс выиграть миллион");
            Console.ReadLine();
        }
    }
}
