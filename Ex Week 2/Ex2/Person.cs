using System;

class Person
{
    protected string name;
    protected int age;

    public Person() { }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Nhập thông tin cá nhân
    public virtual void Input()
    {
        Console.Write("Nhập họ tên: ");
        name = Console.ReadLine();

        while (true)
        {
            Console.Write("Nhập tuổi (>0): ");
            if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                break;

            Console.WriteLine("Tuổi không hợp lệ, nhập lại.");
        }
    }

    // Hiển thị thông tin cá nhân
    public virtual void DisplayPerson()
    {
        Console.WriteLine($"Họ tên: {name}");
        Console.WriteLine($"Tuổi: {age}");
    }

    public override string ToString()
    {
        return $"Họ tên: {name}, Tuổi: {age}";
    }
}
