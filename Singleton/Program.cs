using System;

class Singleton
{
    private static Singleton instance;

    private Singleton()
    {
        Console.WriteLine("Tao instance");
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Hello!");
    }
}

class Program
{
    static void Main()
    {
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        s1.ShowMessage();
        s2.ShowMessage();

        if (s1 == s2)
        {
            Console.WriteLine("Cung instance!");
        }
    }
}