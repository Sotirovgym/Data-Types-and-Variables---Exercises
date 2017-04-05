using System;

class DistanceOfTheStars
{
    static void Main(string[] args)
    {
        decimal distanceProximaCentauri = 4.22m * 9450000000000m;
        decimal milkyWay = 26000m * 9450000000000m;
        decimal diameterOfmilkyWay = 100000m * 9450000000000m;
        decimal fromEarthToTheEdge = 46500000000m * 9450000000000m;

        Console.WriteLine(distanceProximaCentauri.ToString("e2"));
        Console.WriteLine(milkyWay.ToString("e2"));
        Console.WriteLine(diameterOfmilkyWay.ToString("e2"));
        Console.WriteLine(fromEarthToTheEdge.ToString("e2"));

    }
}

