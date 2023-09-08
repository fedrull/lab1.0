using System;


namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            List<string> strings = new List<string>();

            for (int startvalue = 0; startvalue < input.Length - 1; startvalue++)
            {
                for (int j = startvalue + 1; j < input.Length; j++)
                {
                    if (char.IsLetter(input[j]))
                    {
                        break;
                    }

                    if (input[startvalue] == input[j])
                    {
                        strings.Add(input[startvalue..(j + 1)]);
                        break;
                    }
                }
            }

            strings.ForEach(s =>
            {
                Console.Write(input[0..input.IndexOf(s, 0)]);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(s);
                Console.ResetColor();
                Console.WriteLine(input[(input.IndexOf(s, 0) + s.Length)..^0]);
                
                
                
            });

            long sum = strings.Select(s => long.Parse(s)).Sum();
            Console.WriteLine($"The total value is { sum }");

        }
    }
}
