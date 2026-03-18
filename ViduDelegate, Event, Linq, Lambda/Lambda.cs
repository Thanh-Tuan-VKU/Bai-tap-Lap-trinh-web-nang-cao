using System;

class Program
{
    static void Main()
    {
        Func<int, bool> laSoChan = x => x % 2 == 0;

        Console.WriteLine(laSoChan(4)); // true
        Console.WriteLine(laSoChan(5)); // false
    }
}