﻿// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using Tyuiu.ReshetovaAA.Sprint0.Task2.V0.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DataService.GetMessage("Арина"));
        Console.ReadKey();
    }
}
