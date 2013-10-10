namespace Matrix
{
    using System;
    using System.Text;

    // 8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals)
    public class Matrix<T>
    {
        private readonly T[,] matrix;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
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

        // 9. Implement an indexer this[row, col] to access the inner matrix cells
        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
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
                    resultMatrix[i, j] = (dynamic)firstMatrix[i, j] * secondMatrix[i, j];
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
    }
}
