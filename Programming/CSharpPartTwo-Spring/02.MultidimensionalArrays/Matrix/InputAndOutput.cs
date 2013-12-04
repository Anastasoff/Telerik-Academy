// 6. * Write a class Matrix, to holds a matrix of integers. 
//      Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;

class InputAndOutput
{
    static void Main()
    {
        Console.Write("Enter first matrix rows = ");
        int firstDimRows = int.Parse(Console.ReadLine());
        Console.Write("Enter first matrix cols = ");
        int firstDimCols = int.Parse(Console.ReadLine());
        Matrix firstMatrix = new Matrix(firstDimRows, firstDimCols);
        for (int row = 0; row < firstDimRows; row++)
        {
            for (int col = 0; col < firstDimCols; col++)
            {
                Console.Write("matrix1[{0}, {1}] = ", row, col);
                firstMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();

        Console.Write("Enter second matrix rows = ");
        int secondDimRows = int.Parse(Console.ReadLine());
        Console.Write("Enter second matrix cols = ");
        int secondDimCols = int.Parse(Console.ReadLine());
        Matrix secondMatrix = new Matrix(secondDimRows, secondDimCols);
        for (int row = 0; row < secondDimRows; row++)
        {
            for (int col = 0; col < secondDimCols; col++)
            {
                Console.Write("matrix2[{0}, {1}] = ", row, col);
                secondMatrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();

        Matrix add = firstMatrix + secondMatrix;
        Console.WriteLine(add.ToString());

        Matrix substract = firstMatrix - secondMatrix;
        Console.WriteLine(substract.ToString());

        Matrix multiply = firstMatrix * secondMatrix;
        Console.WriteLine(multiply.ToString());
    }
}