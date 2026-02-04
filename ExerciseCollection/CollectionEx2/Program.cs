using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập dãy số: ");
        string input = Console.ReadLine();

        string[] data = input.Split(' ');
        List<double> dsSo = new List<double>();

        for (int i = 0; i < data.Length; i++)
        {
            dsSo.Add(double.Parse(data[i]));
        }

        List<double> ketQua = new List<double>();

        int dau = 0;
        int cuoi = dsSo.Count - 1;

        while (dau <= cuoi)
        {
            if (dau == cuoi)
            {
                ketQua.Add(dsSo[dau]);
            }
            else
            {
                double tong = dsSo[dau] + dsSo[cuoi];
                ketQua.Add(tong);
            }

            dau++;
            cuoi--;
        }

        Console.WriteLine("\nKết quả:");

        for (int i = 0; i < ketQua.Count; i++)
        {
            Console.Write(ketQua[i] + " ");
        }

        Console.ReadLine();
    }
}
