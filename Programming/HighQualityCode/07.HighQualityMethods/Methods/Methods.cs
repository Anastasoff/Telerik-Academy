namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive numbers.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        public static string DigitToEnglishWord(int digit)
        {
            string digitAsEnglishWord = string.Empty;
            switch (digit)
            {
                case 0: digitAsEnglishWord = "zero"; break;
                case 1: digitAsEnglishWord = "one"; break;
                case 2: digitAsEnglishWord = "two"; break;
                case 3: digitAsEnglishWord = "three"; break;
                case 4: digitAsEnglishWord = "four"; break;
                case 5: digitAsEnglishWord = "five"; break;
                case 6: digitAsEnglishWord = "six"; break;
                case 7: digitAsEnglishWord = "seven"; break;
                case 8: digitAsEnglishWord = "eight"; break;
                case 9: digitAsEnglishWord = "nine"; break;
                default:
                    string errorMessage = string.Format("The input '{0}' is not a digit.", digit);
                    throw new ArgumentOutOfRangeException(errorMessage);
            }

            return digitAsEnglishWord;
        }

        public static T FindMaxElement<T>(params T[] elements) where T : IComparable<T>
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The input is null or empty");
            }

            T max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (max.CompareTo(elements[i]) < 0)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        public static void PrintNumber(double value, int decimals)
        {
            string format = "{0:F" + decimals + "}";
            Console.WriteLine(format, value);
        }

        public static void PrintPercent(double value, int decimals)
        {
            string format = "{0:P" + decimals + "}";
            Console.WriteLine(format, value);
        }

        public static void PrintAligned(object value, int totalWidth)
        {
            string format = "{0," + totalWidth + "}";
            Console.WriteLine(format, value);
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));

            return distance;
        }

        public static bool IsLineHorizontal(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                throw new ArgumentException("The points shouldn't coincide. A single point cannot define a line.");
            }

            bool isHorizontal = y1 == y2;

            return isHorizontal;
        }

        public static bool IsLineVertical(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                throw new ArgumentException("The points shouldn't coincide. A single point cannot define a line.");
            }

            bool isVertical = x1 == x2;

            return isVertical;
        }

        private static void PrintSeparator(char separator, int separatorLength)
        {
            Console.WriteLine(new string(separator, separatorLength));
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            PrintSeparator('-', 10);

            Console.WriteLine(DigitToEnglishWord(5));
            PrintSeparator('-', 10);

            Console.WriteLine(FindMaxElement(5.5, -1, 3.14, 2, 14.9, 2, 3));
            Console.WriteLine(FindMaxElement('z', 't', 'a', 'a', 'b'));
            PrintSeparator('-', 10);

            PrintNumber(1.3, 2);
            PrintPercent(0.75, 0);
            PrintAligned(2.30, 8);
            PrintSeparator('-', 10);

            bool isHorizontal = IsLineHorizontal(3, -1, 3, 2.5);
            bool isVertical = IsLineVertical(3, -1, 3, 2.5);
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + isHorizontal);
            Console.WriteLine("Vertical? " + isVertical);
            PrintSeparator('-', 20);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.Age = 21;
            peter.Occupation = "Sofia";
            //peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.Age = 20;
            stella.Occupation = "Vidin";
            //stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("Is {0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}