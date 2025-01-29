using System;
using System.Text.RegularExpressions;

namespace MullItOver
{
    public class Program
    {
        public static void Main()
        {
            int sum = 0;
            string input = File.ReadAllText("F:\\Projects\\AdventOfCode\\MullItOver\\input.txt");
            const string pattern = @"mul\((\d{1,3}),(\d{1,3})\)";
            foreach (Match match in Regex.Matches(input, pattern))
            {
                sum += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[^1].Value);
            }

            Console.WriteLine(sum);
        }
    }
}