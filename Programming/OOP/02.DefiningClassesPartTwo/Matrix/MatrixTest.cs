namespace Matrix
{
    using System;

    public class MatrixTest
    {
        public static void Main()
        {
            Matrix<int> intMatrixOne = new Matrix<int>(3, 2);
            Matrix<int> intMatrixTwo = new Matrix<int>(3, 2);
            Console.WriteLine("Cols: " + intMatrixOne.Cols);
            Console.WriteLine("Rows: " + intMatrixTwo.Rows);

            intMatrixOne[0, 0] = 2;
            intMatrixTwo[0, 0] = 3;
            Console.WriteLine("Addition: \n" + (intMatrixOne + intMatrixTwo));

            intMatrixOne[0, 1] = 4;
            intMatrixTwo[0, 1] = -2;
            Console.WriteLine("Subtraction: \n" + (intMatrixOne - intMatrixTwo));

            Matrix<double> doubleMatrixOne = new Matrix<double>(2, 2);
            Matrix<double> doubleMatrixTwo = new Matrix<double>(2, 2);

            doubleMatrixOne[0, 0] = 8;
            doubleMatrixOne[0, 1] = 7;
            doubleMatrixOne[1, 0] = 6;
            doubleMatrixOne[1, 1] = 0;

            doubleMatrixTwo[0, 0] = 4;
            doubleMatrixTwo[0, 1] = 3;
            doubleMatrixTwo[1, 0] = 2;
            doubleMatrixTwo[1, 1] = 1;
            Console.WriteLine("Multiplication: \n" + (doubleMatrixOne * doubleMatrixTwo));

            Matrix<bool> boolMatrixOne = new Matrix<bool>(2, 3);
            Matrix<bool> boolMatrixTwo = new Matrix<bool>(2, 3);

            boolMatrixOne[1, 1] = true;
            boolMatrixTwo[0, 0] = true;
            Console.WriteLine("True operator:");
            Console.WriteLine(boolMatrixOne);
            Console.WriteLine(boolMatrixTwo);
        }
    }
}
