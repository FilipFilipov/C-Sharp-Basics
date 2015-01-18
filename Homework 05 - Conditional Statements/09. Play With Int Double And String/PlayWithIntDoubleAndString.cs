using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an integer: ");
                    int n;
                    if (int.TryParse(Console.ReadLine(), out n))
                        Console.WriteLine("New int: " + ++n);
                    else
                        Console.WriteLine("Not an integer");
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double d;
                    if (double.TryParse(Console.ReadLine(), out d))
                        Console.WriteLine("New double: " + ++d);
                    else
                        Console.WriteLine("Not a double");
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                    string str = (Console.ReadLine());
                    Console.WriteLine("New string: " + str + "*");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        else
            Console.WriteLine("Invalid choice");
    }
}
