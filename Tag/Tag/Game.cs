using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag
{
    class Game
    {
        private int[] field;
        private int[,] gameField;

        public Game(params int[] fieldOld)
        {
            this.field = fieldOld;
            CreateFieldOfGame();            
        }

        public void Print()
        {
            for (int i = 0; i < Math.Sqrt(field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(field.Length); j++)
                {
                    if (j != Math.Sqrt(field.Length) - 1)
                    {
                        Console.Write(gameField[i,j] + " ");
                    }
                    else Console.Write(gameField[i,j] + "\n");
                }
            }
            Console.WriteLine();
        }
        public void CreateFieldOfGame()
        {                       
            int sizeOfField = Convert.ToInt32(Math.Sqrt(field.Length));
            {
                gameField = new int[sizeOfField, sizeOfField];
                int helpCount = 0;
                for (int i = 0; i < sizeOfField; i++)
                {
                    for (int j = 0; j < sizeOfField; j++)
                    {
                        if (helpCount <= field.Length - 1)
                        {
                            gameField[i, j] = field[helpCount];
                            if (gameField[i, j] >= 0)
                            {
                                gameField[i, j] = field[helpCount];
                                helpCount++;
                            }
                            else throw new Exception("Есть отрицательные элементы в массиве");
                        }
                    }
                }
            }
        }
        public void GenerationField()
        {
            int help = 0;            
            Random gen = new Random();
            
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    help = gen.Next(0, field.Length);
                    for (int k = 0; k < field.Length; k++)
                    {
                        while ((field[help] == field[k]) && (field[help] == -1))
                        {
                            help = gen.Next(0, field.Length);
                        }
                    }
                    gameField[i, j] = field[help];
                    field[help] = -1;
                }
            }
            Print();

        }
        public void GetLocation(int value)
        {
           
            int coordinateX=0;
            int coordinateY=0;
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (value == gameField[i, j])
                    {
                        coordinateX = i;
                        coordinateY = j;
                    }
                }
            }                        
        }
        public bool Verification()
         
    }
}
