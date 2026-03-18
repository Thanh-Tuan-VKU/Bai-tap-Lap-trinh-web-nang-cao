using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> ds = new List<int>() { 2, 5, 7, 10, 3 };

        double tb = ds.Average();

        var ketQua = ds.Where(x => x > tb);

        Console.WriteLine("Cac so lon hon trung binh:");

        foreach (var x in ketQua)
        {
            Console.WriteLine(x);
        }
    }
}