using System;

class TravelingAtLightSpeed
{
    static void Main()
    {
        decimal lightYears = decimal.Parse(Console.ReadLine());

        var lightYearInKm = (lightYears * 9450000000000);
        var timeInSeconds = lightYearInKm / 300000;
        var timeInMinutes = timeInSeconds / 60;
        var timeInHours = timeInMinutes / 60;
        var timeInDays = timeInHours / 24;
        var timeInWeeks = timeInDays / 7;

        decimal days = timeInDays % 7;
        decimal hours = timeInHours % 24;
        decimal minutes = timeInMinutes % 60;
        decimal seconds = timeInSeconds % 60;


        Console.WriteLine(Math.Truncate(timeInWeeks) + " weeks");
        Console.WriteLine(Math.Truncate(days) + " days");
        Console.WriteLine(Math.Truncate(hours) + " hours");
        Console.WriteLine(Math.Truncate(minutes) + " minutes");
        Console.WriteLine(Math.Truncate(seconds) + " seconds");


    }
}

