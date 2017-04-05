using System;

class DataOverflow
{
    static void Main()
    {
        ulong inputNumber1 = ulong.Parse(Console.ReadLine());
        ulong inputNumber2 = ulong.Parse(Console.ReadLine());

        var lowestNum = Math.Min(inputNumber1, inputNumber2);
        var greaterNum = Math.Max(inputNumber1, inputNumber2);

        string bigType = string.Empty;
        string smallType = string.Empty;
        ulong smallNumType = 0;

        if (greaterNum > lowestNum)
        {
            if (greaterNum >= byte.MinValue && greaterNum <= byte.MaxValue)
            {
                bigType = "byte";
            }
            else if (greaterNum >= ushort.MinValue && greaterNum <= ushort.MaxValue)
            {
                bigType = "ushort";
            }
            else if (greaterNum >= uint.MinValue && greaterNum <= uint.MaxValue)
            {
                bigType = "uint";

            }
            else if (greaterNum >= ulong.MinValue && greaterNum <= ulong.MaxValue)
            {
                bigType = "ulong";
            }

            if (lowestNum >= byte.MinValue && lowestNum <= byte.MaxValue)
            {
                smallType = "byte";
                smallNumType = byte.MaxValue;
            }
            else if (lowestNum >= ushort.MinValue && lowestNum <= ushort.MaxValue)
            {
                smallType = "ushort";
                smallNumType = ushort.MaxValue;
            }
            else if (lowestNum >= uint.MinValue && lowestNum <= uint.MaxValue)
            {
                smallType = "uint";
                smallNumType = uint.MaxValue;
            }
            else if (lowestNum >= ulong.MinValue && lowestNum <= ulong.MaxValue)
            {
                smallType = "ulong";
                smallNumType = ulong.MaxValue;

            }

            Console.WriteLine($"bigger type: {bigType}");
            Console.WriteLine($"smaller type: {smallType}");
            Console.WriteLine($"{greaterNum} can overflow {smallType} {Math.Round((double)greaterNum / smallNumType)} times");
        }
    }
}

