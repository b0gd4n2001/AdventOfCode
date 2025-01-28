using System;

namespace RedNosedReports
{
    enum Order
    {
        Undefined,
        Ascending,
        Descending,
        Invalid
    }

    public class Program
    {
        const int MaxModulus = 3;

        public static void Main()
        {
            int validLinesCount = 0;
            foreach (string line in File.ReadLines("F:\\Projects\\AdventOfCode\\RedNosedReports\\input.txt"))
            {
                Order order = new Order();
                string[] splitLine = line.Split(' ');
                for (int i = 1; i < splitLine.Length; i++)
                {
                    int current = int.Parse(splitLine[i]);
                    int previous = int.Parse(splitLine[i - 1]);
                    int difference = current - previous;
                    int modulus = Math.Abs(difference);
                    int sign = Math.Sign(difference);

                    if (IsOutOfRange(modulus, sign) || !IsValidLine(ref order, sign))
                    {
                        order = Order.Invalid;
                        break;
                    }
                }

                if (order != Order.Invalid)
                {
                    validLinesCount++;
                }
            }

            Console.WriteLine(validLinesCount);
        }

        private static bool IsOutOfRange(int modulus, int sign)
        {
            return modulus > MaxModulus || sign == 0;
        }

        private static bool IsValidLine(ref Order order, int sign)
        {
            if (order == Order.Undefined)
            {
                order = sign == 1 ? Order.Ascending : Order.Descending;
            }
            else if ((order == Order.Ascending && sign == -1) || (order == Order.Descending && sign == 1))
            {
                return false;
            }

            return true;
        }
    }
}