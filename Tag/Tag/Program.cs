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
            Console.Write("Введите длину, которая будет равна ширине поля: ");
            int sizeField = Convert.ToInt32(Console.ReadLine());
            int[,] field = new int[sizeField,sizeField];

            RandomField(field, sizeField);

            for (int i = 0; i < sizeField; i++)
            {                
                for (int j = 0; j < sizeField; j++)
                {
                    if (j < sizeField - 1)
                    {
                        Console.Write(field[i, j] + "/ ");
                    }
                    else
                    {
                        Console.Write(field[i, j] + "\n");
                    }     
                }
            }
            Console.ReadLine();
            
        }
        static int[,] RandomField(int[,] field,int sizeField)
        {
            /*int time = Convert.ToInt32(Math.Pow(sizeField,2) - 1);
            for (int i = 0; i < sizeField; i++)
            {
                for (int j = 0; j < sizeField; j++)
                {
                    field[i, j] = time;
                    time--;
                }
            }*/
            Random gen = new Random();
            for (int i = 0; i < sizeField; i++)
            {
                for (int j = 0; j < sizeField; j++)
                {

                }
            }

            return field;
        }

    }
}
