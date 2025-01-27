using System;

namespace HistorianHysteria
{
    public class Program
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("F:\\Projects\\AdventOfCode\\HistorianHysteria\\input.txt");
            int[] firstColumn = new int[input.Length];
            int[] secondColumn = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                string[] line = input[i].Split("  ");
                firstColumn[i] = int.Parse(line[0]);
                secondColumn[i] = int.Parse(line[1]);
            }

            Array.Sort(firstColumn);
            Array.Sort(secondColumn);

            int total = 0;

            for (int i = 0; i < input.Length; i++)
            {
                total += Math.Abs(firstColumn[i] - secondColumn[i]);
            }

            Console.WriteLine(total);
        }
    }
}