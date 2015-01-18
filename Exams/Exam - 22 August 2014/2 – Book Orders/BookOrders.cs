using System;

class BookOrders
{
    static void Main()
    {
        int orders = int.Parse(Console.ReadLine());
        long allBooks = 0;
        double costs = 0;
        for (int i = 0; i < orders; i++)
        {            
            int packets = int.Parse(Console.ReadLine());
            int books = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            switch (packets / 10)
            {
                case 0: break;
                case 1:
                    price *= 0.95; break;
                case 2:
                    price *= 0.94; break;
                case 3:
                    price *= 0.93; break;
                case 4:
                    price *= 0.92; break;
                case 5:
                    price *= 0.91; break;
                case 6:
                    price *= 0.90; break;
                case 7:
                    price *= 0.89; break;
                case 8:
                    price *= 0.88; break;
                case 9:
                    price *= 0.87; break;
                case 10:
                    price *= 0.86; break;
                default:
                    price *= 0.85; break;
            }
            allBooks += packets * books;
            costs += price * packets * books;
        }        
        Console.WriteLine(allBooks);
        Console.WriteLine("{0:F2}", costs);
    }
}
