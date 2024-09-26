using System;


static void Main(string[] args)
{




}
public class Massive
{
    const int r = 2, c = 3;
    int[,] massive = new int[r, c] { { 0, 1, 2 }, { 3, 4, 5, } };

    //метод вывода матриц

    public void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < r; i++)
        {
            for (var j = 0; j < c; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }

            Console.WriteLine();
        }
    }

    // метод для сложения двух матриц


    public int[,] MatrixSum(int[,] matrixA, int[,] matrixB)
    {


        var matrixC = new int[r, c];

        for (var i = 0; i < r; i++)
        {
            for (var j = 0; j < c; j++)
            {
                matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return matrixC;

    }
    //метод умножения на число
    public int[,] OnNumber(int[,] matrix, int number)
    {
        var matrixC = new int[r, c];

        for (var i = 0; i < r; i++)
        {
            for (var j = 0; j < c; j++)
            {
                matrixC[i, j] = matrix[i, j] * number;
            }

        }
        return matrixC;

    }
    //метод умножения матриц


    public int[,] Umnoj(int[,] matrixA, int[,] matrixB)
    {


        var matrixC = new int[r, c];

        for (var i = 0; i < r; i++)
        {
            for (var j = 0; j < c; j++)
            {
                matrixC[i, j] = matrixA[i, j] * matrixB[i, j];
            }
        }

        return matrixC;

    }


}
