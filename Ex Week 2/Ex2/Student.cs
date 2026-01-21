using System;

class Student : Person
{
    private double gpa;

    public Student() { }

    public Student(string name, int age, double gpa)
        : base(name, age)
    {
        this.gpa = gpa;
    }

    // Nhập thông tin sinh viên
    public override void Input()
    {
        base.Input();

        while (true)
        {
            Console.Write("Nhập GPA (0 - 4): ");
            if (double.TryParse(Console.ReadLine(), out gpa) && gpa >= 0 && gpa <= 4)
                break;

            Console.WriteLine("GPA không hợp lệ, nhập lại.");
        }
    }

    // Hiển thị thông tin sinh viên
    public void DisplayStudent()
    {
        Console.WriteLine("----- THÔNG TIN SINH VIÊN -----");
        DisplayPerson();

        string hocLuc;
        if (gpa >= 3.6)
            hocLuc = "Xuất sắc";
        else if (gpa >= 3.2)
            hocLuc = "Giỏi";
        else if (gpa >= 2.5)
            hocLuc = "Khá";
        else
            hocLuc = "Trung bình";

        Console.WriteLine($"GPA: {gpa}");
        Console.WriteLine($"Học lực: {hocLuc}");
    }
}
