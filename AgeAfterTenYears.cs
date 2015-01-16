using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("What is your birthday (yyyy, mm, dd)? ");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        int age = DateTime.Now.Year - birthday.Year;
        if (DateTime.Now < birthday.AddYears(age))
        {
            age--;
        }
        Console.WriteLine("You are now {0} years old.", (age));
        Console.WriteLine("You will be {0} in ten years.", (age + 10));
    }
}