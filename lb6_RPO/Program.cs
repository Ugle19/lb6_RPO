using lb6_RPO.classesMatrix;

namespace lb6_RPO;
class Program
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 3;
        int[,] matrixA = generationMatrix.newMatrix(b, a);
        Console.WriteLine("Matrix A: ");
        generationMatrix.outputMatrix(matrixA);

        int[,] matrixB = generationMatrix.newMatrix(a, b);
        Console.WriteLine("\nMatrix B: ");
        generationMatrix.outputMatrix(matrixB);

        int[,] matrixA_2_4 = generationMatrix.newMatrix(4, 2);
        Console.WriteLine("\nMatrix A 2 4 : ");
        generationMatrix.outputMatrix(matrixA_2_4);

        int[,] matrixA_4_2 = generationMatrix.newMatrix(2, 4);
        Console.WriteLine("\nMatrix A 2 4 : ");
        generationMatrix.outputMatrix(matrixA_4_2);

        mathOperationMatrix.traspMatrix(matrixA);

        mathOperationMatrix.traspMatrix(matrixB);

        mathOperationMatrix.Plus(matrixA, matrixB);

        mathOperationMatrix.Minus(matrixA, matrixB);

        mathOperationMatrix.multiPlusMonNum(matrixA);

        mathOperationMatrix.multiPlusMonNum(matrixB);

        mathOperationMatrix.multiPlusMonM(matrixA, matrixB);

        readAndWriteMatrix.writeMatrix(matrixA_2_4);

        readAndWriteMatrix.readMatrix();

        Console.ReadKey();
    }
}
