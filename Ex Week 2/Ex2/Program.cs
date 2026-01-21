using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("===== CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN =====\n");

        Student st = new Student();
        st.Input();

        Console.WriteLine();
        st.DisplayStudent();

        Console.ReadLine();
    }
}
