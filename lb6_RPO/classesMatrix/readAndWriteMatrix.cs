using System;
using System.IO;

namespace lb6_RPO.classesMatrix
{
    public class readAndWriteMatrix
    {
        //путь к файлу 
        const string filePath = "/Users/MacOS/Desktop/lab_RPO/files_for_prog/matrix2_0.txt";

        //запись в файл 
        public static void writeMatrix(int[,] matrix)
        {
            Console.WriteLine("WRITE NATRIX:");
            using (StreamWriter stream = new StreamWriter(filePath))
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int k = 0; k < matrix.GetLength(1); k++)
                        if (k == 0)
                        {
                            stream.Write("{0}", matrix[i, k]);
                        }
                        else
                        {
                            stream.Write(" {0}", matrix[i, k]);
                        }
                    if (i != matrix.GetLength(0) - 1)
                    {
                        stream.WriteLine();
                    }
                }
            }
        }

        //чтение файла 
        public static void readMatrix()
        {
            Console.WriteLine(" READ MATRIX: ");
            StreamReader file = new StreamReader(filePath);
            string s = file.ReadToEnd();
            file.Close();
            string[] str = s.Split('\n');
            string[] col = str[0].Split(' ');
            int[,] a = new int[str.Length, col.Length];
            int t = 0;
            for (int i = 0; i < str.Length; i++)
            {
                col = str[i].Split(' ');
                for (int j = 0; j < col.Length; j++)
                {
                    t = Convert.ToInt32(col[j]);
                    a[i, j] = t;
                }
            }

            generationMatrix.outputMatrix(a);
        }
    }
}
