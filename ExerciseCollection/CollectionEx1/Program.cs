using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập dãy số: ");
        List<double> numbers = Console.ReadLine()
                                      .Split(' ')
                                      .Select(double.Parse)
                                      .ToList();

        bool merged = true;

        while (merged)
        {
            merged = false;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);

                    merged = true;
                    break; 
                }
            }
        }

        Console.WriteLine("\nKết quả:");
        Console.WriteLine(string.Join(" ", numbers));
    }
}
