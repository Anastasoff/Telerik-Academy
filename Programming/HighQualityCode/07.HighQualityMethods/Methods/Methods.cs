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

        public static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2,
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
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

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");
            PrintSeparator('-', 10);

            bool horizontal = false;
            bool vertical = false; ;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
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