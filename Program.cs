// namespace declaration
using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your name");

        string userName = Console.ReadLine();

        Console.WriteLine("Hello {0}", userName);

        //Console.WriteLine("Welcome back " + userName + "!");
    }
}