using System;
namespace lb6_RPO.classesMatrix
{
    public class mathOperationMatrix : generationMatrix
    {
        public mathOperationMatrix()
        {

        }

        //сложение матриц
        public static void Plus(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }
            Console.WriteLine("\nmatrixC after plus: ");
            generationMatrix.outputMatrix(matrixC);

        }

        //вычитание матриц
        public static void Minus(int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }
            Console.WriteLine("\nmatrixC after minus: ");
            generationMatrix.outputMatrix(matrixC);
        }

        //транспортировка матрицы
        public static void traspMatrix(int[,] matrixA)
        {
            int[,] matrixC = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            matrixC = matrixA;
            int tmp = 0;
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 1; j < matrixC.GetLength(1); j++)
                {
                    tmp = matrixC[i, j];
                    matrixC[i, j] = matrixC[j, i];
                    matrixC[j, i] = tmp;
                }
            }
            Console.WriteLine($"\nmatrixC after transp: ");
            generationMatrix.outputMatrix(matrixC);
        }


        //умножение матрицы на число(генерируется рандомно)
        public static void multiPlusMonNum(int[,] matrix)
        {
            Random rndNumber = new Random();
            int mpNumber = rndNumber.Next(1, 10);
            int[,] matrixC = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrixC.GetLength(0); i++)
            {
                for (int j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i, j] = matrix[i, j] * mpNumber;
                }
            }
            Console.WriteLine($"\nmatrixC after multiplus on {mpNumber}: ");
            generationMatrix.outputMatrix(matrixC);

        }


        //умножение матрицы на матрицу 
        public static void multiPlusMonM(int[,] matrixA, int[,] matrixB)
        {
            int[,] C = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixB.GetLength(0); k++)
                    {
                        C[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }
            Console.WriteLine("\nmatrixC after multiplus: ");
            generationMatrix.outputMatrix(C);
        }



    }
}


