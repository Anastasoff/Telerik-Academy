namespace RotatingWalkInMatrixTests
{
    using System;
    using System.Reflection;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RotatingWalkInMatrix;

    [TestClass]
    public class RotatingWalkInMatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InputtingAValue_AboveTheUpperBoundarie_ThrowException()
        {
            Console.SetIn(new System.IO.StringReader("101"));
            Matrix.InitializeMatrix(Console.ReadLine());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InputtingAValue_BelowTheLowerBoundarie_ThrowException()
        {
            Console.SetIn(new System.IO.StringReader("-1"));
            Matrix.InitializeMatrix(Console.ReadLine());
        }

        [TestInitialize]
        public void RefreshIncrementer()
        {
            FieldInfo refresh = typeof(Matrix).GetField(
                "valueIncrementer", BindingFlags.NonPublic | BindingFlags.Static);
            refresh.SetValue(null, 1);
        }

        [TestMethod]
        public void CheckMatrixWithSize1()
        {
            var matrixGenerator = typeof(Matrix).GetMethod(
                "GenerateMatrix", BindingFlags.Static | BindingFlags.NonPublic);

            int[,] gen = (int[,])matrixGenerator.Invoke(obj: null, parameters: new object[] { 1 });

            Assert.AreEqual<string>("1", this.MatrixToString(gen));
        }

        [TestMethod]
        public void CheckMatrixWithSize2()
        {
            var matrixGenerator = typeof(Matrix).GetMethod(
                "GenerateMatrix", BindingFlags.Static | BindingFlags.NonPublic);

            int[,] gen = (int[,])matrixGenerator.Invoke(obj: null, parameters: new object[] { 2 });

            Assert.AreEqual<string>(
                string.Format("1 4{0}3 2", Environment.NewLine), this.MatrixToString(gen));
        }

        [TestMethod]
        public void CheckMatrixWithSize5()
        {
            var matrixGenerator = typeof(Matrix).GetMethod(
                "GenerateMatrix", BindingFlags.Static | BindingFlags.NonPublic);

            int[,] gen = (int[,])matrixGenerator.Invoke(obj: null, parameters: new object[] { 5 });

            Assert.AreEqual<string>(
                string.Format(
                "1 13 14 15 16{0}" +
                "12 2 21 22 17{0}" +
                "11 23 3 20 18{0}" +
                "10 25 24 4 19{0}" +
                "9 8 7 6 5",
                Environment.NewLine), this.MatrixToString(gen));
        }

        private string MatrixToString(int[,] gen)
        {
            StringBuilder matrixToString = new StringBuilder();

            for (int row = 0; row < gen.GetLength(0); row++)
            {
                for (int col = 0; col < gen.GetLength(0); col++)
                {
                    matrixToString.Append(gen[row, col]);
                    if (col != gen.GetLength(0) - 1)
                    {
                        matrixToString.Append(" ");
                    }
                }

                if (row != gen.GetLength(1) - 1)
                {
                    matrixToString.AppendLine();
                }
            }

            return matrixToString.ToString();
        }
    }
}