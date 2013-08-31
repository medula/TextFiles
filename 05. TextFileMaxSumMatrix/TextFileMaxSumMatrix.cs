//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix 
//an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains 
//the size of matrix N. Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;


class TextFileMaxSumMatrix
{
    static void Main()
    {
        int[,] matrix=ConvertTextFileToMatrix("../../TextFileMatrix.txt");
        int sum = MaximalSumInMatrix(matrix);
        Console.WriteLine("{0}", sum);
    }
    static int[,] ConvertTextFileToMatrix(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            int n = int.Parse(reader.ReadLine());
            int[,] matrix = new int[n, n];
            string line = reader.ReadLine();
            int i = 0;
            while (line != null)
            {
                string[] members = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(members[j]);
                }
                line = reader.ReadLine();
                i++;
            }
            return matrix;
        }
    }
    static int MaximalSumInMatrix(int[,] matrix)
    {
        int MaxSum = int.MinValue;
        int sum = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0)-1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (sum > MaxSum)
                {
                    MaxSum = sum;
                }
            }
        }
        return MaxSum;
    }
}

