
using System;

class TrigonometryCalculator
{
    static void Main()
    {
        double angle = 55; // Angle in degrees

        // Convert angle to radians
        double radians = angle * Math.PI / 180;

        // Calculate sine
        double sine = Math.Sin(radians);
        Console.WriteLine("Sine: " + sine);
        // Calculate cosine
        double cosine = Math.Cos(radians);
        Console.WriteLine("Cosine: " + cosine);
        // Calculate tangent
        double tangent = Math.Tan(radians);
        Console.WriteLine("Tangent: " + tangent);
    }
}