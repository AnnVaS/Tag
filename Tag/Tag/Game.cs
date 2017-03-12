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
        private int moveX;
        private int moveY;

        public Game(params int[] field)
        {
            this.field = field;
            CreateFieldOfGame();
            GenerationField(); 

        }

        public void Print()
        {
            for (int i = 0; i < Math.Sqrt(field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(field.Length); j++)
                {
                    if (j != Math.Sqrt(field.Length) - 1)
                    {
                        Console.Write(gameField[i,j] + "  ");
                    }
                    else Console.Write(gameField[i,j] + "\n\n");
                }
            }
            Console.WriteLine();
        }
        private void CreateFieldOfGame()
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
        private void GenerationField()
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
                       
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (value == gameField[i, j])
                    {
                        moveX = i;
                        moveY = j;
                    }
                }
            }                        
        }

        public void Shift(int value)
        {
            int[,] helpmas = new int[1, 1];
            int coordinateXZero = 0;
            int coordinateYZero = 0;

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (gameField[i, j]==0)
                    {
                        coordinateXZero = i;
                        coordinateYZero = j;
                    }
                }
            }
            if (Math.Abs(moveX - coordinateXZero) == 1 && moveY == coordinateYZero)
            {
                helpmas[0, 0] = gameField[moveX, moveY];
                gameField[moveX, moveY] = gameField[coordinateXZero, coordinateYZero];
                gameField[coordinateXZero, coordinateYZero] = helpmas[0, 0];
            }
            if (Math.Abs(moveY - coordinateYZero) == 1 && moveX == coordinateXZero)
            {
                helpmas[0, 0] = gameField[moveX, moveY];
                gameField[moveX, moveY] = gameField[coordinateXZero, coordinateYZero];
                gameField[coordinateXZero, coordinateYZero] = helpmas[0, 0];
            }

        }
        public bool VerificationOfWinner()
        {            
            int count = 1;
            int c = 0;
            
                for (int i = 0; i < gameField.GetLength(0); i++)
                {
                    for (int j = 0; j < gameField.GetLength(1); j++)
                    {
                        if (gameField[i, j] == count)
                        {
                            c++;
                        }
                        count++;
                    }
                }
                if (c == 3 && (gameField[gameField.GetLength(0) - 1, gameField.GetLength(1) - 1] == 0))
                {
                    Console.WriteLine("Вы выиграли!");
                    return true;
                }
                else return false;    
        }
    }
}
