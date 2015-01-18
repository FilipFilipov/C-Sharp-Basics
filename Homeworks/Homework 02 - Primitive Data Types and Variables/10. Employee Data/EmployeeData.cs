using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Enter emplyee data.");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Gender: ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Personal ID number: ");
        long personalIDNumber = long.Parse(Console.ReadLine());
        Console.Write("Employee number: ");
        int employeeeNumber = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Employee data:\nFirst name - {0}\nLast name - {1}\nAge - {2}\nGender - {3}\nPersonal ID number - {4}\nEmployee number - {5}",
            firstName, lastName, age, gender, personalIDNumber, employeeeNumber);
    }
}
