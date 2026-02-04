using System;

class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public void Input()
    {
        Console.Write("Nhập ID: ");
        Id = Console.ReadLine();

        Console.Write("Nhập tên: ");
        Name = Console.ReadLine();

        Console.Write("Nhập tuổi: ");
        Age = int.Parse(Console.ReadLine());
    }

    public void Display()
    {
        Console.WriteLine($"{Id} - {Name} - {Age}");
    }
}
