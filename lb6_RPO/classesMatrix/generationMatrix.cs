using System;
namespace lb6_RPO.classesMatrix
{
    public class generationMatrix
    {
        public generationMatrix()
        {
        }


        //рандомная генерация матрицы
        public static int[,] newMatrix(int a, int b)
        {
            Random rnd = new Random();
            int[,] matrix = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }

            return matrix;
        }

        //вывод матрицы
        public static void outputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"matrix[{i} {j}] = " + matrix[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
