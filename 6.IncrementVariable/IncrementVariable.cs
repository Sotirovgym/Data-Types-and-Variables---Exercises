using System;

class IncrementVariable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var overFlow = 0;
        byte count = 0;

        for (int i = 0; i < n; i++)
        {
            count++;

            if (count == 0)
            {                
                overFlow++;
            }
            
        }
        if (overFlow > 0)
        {
            Console.WriteLine(count);
            Console.WriteLine($"Overflowed {overFlow} times");
        }
        else
        {
            Console.WriteLine(count);
        }
    }
}

