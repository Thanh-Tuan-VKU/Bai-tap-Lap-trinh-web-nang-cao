using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhập số lượng bài hát: ");
        int n = int.Parse(Console.ReadLine());

        List<Song> songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhập bài hát {i + 1}: ");
            string input = Console.ReadLine();

            string[] parts = input.Split('_');

            songs.Add(new Song(parts[0], parts[1], parts[2]));
        }

        Console.Write("Nhập type list (hoặc all): ");
        string filter = Console.ReadLine();

        Console.WriteLine("\nKết quả:");
        foreach (Song song in songs)
        {
            if (filter == "all" || song.TypeList == filter)
            {
                Console.WriteLine(song.Name);
            }
        }

        Console.ReadLine();
    }
}
