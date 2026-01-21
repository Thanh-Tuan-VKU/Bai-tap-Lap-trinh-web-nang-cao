using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập phân số thứ nhất (tử mẫu): ");
        string[] f1 = Console.ReadLine().Split(' ');
        Fraction a = new Fraction(int.Parse(f1[0]), int.Parse(f1[1]));

        Console.Write("Nhập phân số thứ hai (tử mẫu): ");
        string[] f2 = Console.ReadLine().Split(' ');
        Fraction b = new Fraction(int.Parse(f2[0]), int.Parse(f2[1]));

        Console.WriteLine("\nPhân số thứ nhất:");
        a.Display();

        Console.WriteLine("Phân số thứ hai:");
        b.Display();

        Console.WriteLine("\nTổng:");
        a.Add(b).Display();

        Console.WriteLine("Hiệu:");
        a.Subtract(b).Display();

        Console.WriteLine("Tích:");
        a.Multiply(b).Display();

        Console.WriteLine("Thương:");
        a.Divide(b).Display();

        Console.WriteLine("\nDạng thập phân của tổng:");
        a.Add(b).DisplayDecimal();

        Console.ReadLine();
    }
}
