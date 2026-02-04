using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Student> dsSV = new List<Student>();

        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nSinh viên thứ {i + 1}:");

            Student sv = new Student();
            sv.Input();

            dsSV.Add(sv);
        }

        dsSV.Sort((a, b) => a.Name.CompareTo(b.Name));

        Console.WriteLine("\nDanh sách sau khi sắp xếp theo tên:");

        for (int i = 0; i < dsSV.Count; i++)
        {
            dsSV[i].Display();
        }

        Console.ReadLine();
    }
}
