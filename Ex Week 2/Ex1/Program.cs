using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("===== CHƯƠNG TRÌNH MÔ PHỎNG XÚC XẮC =====\n");

        int sides;
        while (true)
        {
            Console.Write("Nhập số mặt của xúc xắc (>=2): ");
            if (int.TryParse(Console.ReadLine(), out sides) && sides >= 2)
                break;

            Console.WriteLine("Số mặt không hợp lệ, vui lòng nhập lại.");
        }

        Dice dice = new Dice(sides);

        int times;
        while (true)
        {
            Console.Write("Nhập số lần tung xúc xắc: ");
            if (int.TryParse(Console.ReadLine(), out times) && times > 0)
                break;

            Console.WriteLine("Số lần tung không hợp lệ.");
        }

        int total = 0;
        for (int i = 1; i <= times; i++)
        {
            int result = dice.Roll();
            total += result;
            Console.WriteLine($"Lần {i}: Ra {result}");
        }

        Console.WriteLine($"\nTổng điểm: {total}");
        Console.ReadLine();
    }
}
