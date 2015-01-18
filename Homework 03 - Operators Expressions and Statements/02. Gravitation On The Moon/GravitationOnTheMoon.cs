using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the Moon would be {0}.", weight * 0.17);
    }
}
