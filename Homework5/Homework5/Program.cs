﻿using Homework5;
using static System.Collections.Specialized.BitVector32;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Username:");
        string Username = Console.ReadLine();
        Console.WriteLine("Password:");
        string Password = Console.ReadLine();
        Admin admin = new(true, "Slider section");
        Console.WriteLine("IsSuperAdmin:" + admin.IsSuperAdmin);

        Console.WriteLine("Section :" + admin.Section);

        Console.WriteLine("Admin:" + admin.Return());
    }
}
