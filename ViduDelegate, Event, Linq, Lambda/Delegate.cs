using System;

class Program
{
    delegate double TinhTien(double gia);

    static double Giam10(double gia)
    {
        return gia * 0.9;
    }

    static double Giam20(double gia)
    {
        return gia * 0.8;
    }

    static void Main()
    {
        double giaGoc = 1000;

        TinhTien tinh;

        tinh = Giam10;
        Console.WriteLine("Gia sau giam 10%: " + tinh(giaGoc));

        tinh = Giam20;
        Console.WriteLine("Gia sau giam 20%: " + tinh(giaGoc));
    }
}