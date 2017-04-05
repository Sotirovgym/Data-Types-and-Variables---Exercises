using System;

class FromTerabyteTtoBits
{
    static void Main()
    {
        decimal terabytes = decimal.Parse(Console.ReadLine());

        var bitToTerabytes = terabytes * 1024 * 1024 * 1024 * 1024 * 8;

        Console.WriteLine(Math.Round(bitToTerabytes));
    }
}

