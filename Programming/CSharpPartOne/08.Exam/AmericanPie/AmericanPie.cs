namespace AmericanPie
{
    using System;
    using System.Numerics;

    public class AmericanPie
    {
        public static void Main()
        {
            checked
            {
                BigInteger firstInputA = BigInteger.Parse(Console.ReadLine());
                BigInteger secondInputB = BigInteger.Parse(Console.ReadLine());
                BigInteger thirdInputC = BigInteger.Parse(Console.ReadLine());
                BigInteger fourthInputD = BigInteger.Parse(Console.ReadLine());

                decimal pieOne = (decimal)firstInputA / (decimal)secondInputB;
                decimal pieTwo = (decimal)thirdInputC / (decimal)fourthInputD;

                decimal result = pieOne + pieTwo;

                BigInteger finalFraction = secondInputB * fourthInputD;

                if (result >= 1)
                {
                    Console.WriteLine("{0}", (BigInteger)result);
                    Console.WriteLine("{0}/{1}", (firstInputA * fourthInputD) + (thirdInputC * secondInputB), finalFraction);
                }
                else
                {
                    Console.WriteLine("{0:F20}", result);
                    Console.WriteLine("{0}/{1}", (firstInputA * fourthInputD) + (thirdInputC * secondInputB), finalFraction);
                }
            }
        }
    }
}