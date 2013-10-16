namespace Matrix
{
    using System;
    using System.Text;

    // 8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals)
    public class Matrix<T> where T : struct, IComparable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T[,] matrix;

        public Matrix(int row, int col)
        {            
            if (row < 0 || col < 0)
            {
                throw new ApplicationException("Incorrect matrix size.");
            }
            else
            {
                this.matrix = new T[row, col];
            }
        }        

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        public T this[int row, int col]
        {
            get
            {
                if (this.IsInRange(row, col))
                {
                    return this.matrix[row, col];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }

            set
            {
                if (this.IsInRange(row, col))
                {
                    this.matrix[row, col] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range!");
                }
            }
        }

        // 10. Implement the operators + and - (addition and subtraction of matrices of the same size)

        // Addition
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows > secondMatrix.Rows || (firstMatrix.Cols > secondMatrix.Cols))
            {
                throw new ArgumentException("Matrices are of different size");
            }

            int rows = firstMatrix.Rows;
            int cols = firstMatrix.Cols;

            Matrix<T> resultMatrix = new Matrix<T>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return resultMatrix;
        }

        // Subtraction 
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows > secondMatrix.Rows || (firstMatrix.Cols > secondMatrix.Cols))
            {
                throw new ArgumentException("Matrices are of different size");
            }

            int rows = firstMatrix.Rows;
            int cols = firstMatrix.Cols;

            Matrix<T> resultMatrix = new Matrix<T>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)firstMatrix[i, j] - secondMatrix[i, j];
                }
            }

            return resultMatrix;
        }

        // Multiplication
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows > secondMatrix.Rows || (firstMatrix.Cols > secondMatrix.Cols))
            {
                throw new ArgumentException("Matrices are of different size");
            }

            int rows = firstMatrix.Rows;
            int cols = firstMatrix.Cols;

            Matrix<T> resultMatrix = new Matrix<T>(rows, cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        resultMatrix[i, j] += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                    }
                }
            }

            return resultMatrix;
        }

        // Implement the true operator (check for non-zero elements)
        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    result.AppendFormat("{0,6}", this[i, j]);                    
                }

                result.AppendLine("\n");
            }

            return result.ToString();
        }

        private bool IsInRange(int row, int col)
        {
            if ((row < 0) || (row >= this.matrix.GetLength(0)) || (col < 0) || (col >= this.matrix.GetLength(1)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
