using System;

class HalfByteSwapper
{
    static void Main()
    {
        uint[] numbers = new uint[4];
        for (int i = 0; i < 4; i++)
        {
            numbers[i] = uint.Parse(Console.ReadLine());
        }
        while (true)
        {
            string[] command1 = Console.ReadLine().Split(' ');
            if (command1[0] == "End")
            {
                break;
            }
            string[] command2 = Console.ReadLine().Split(' ');
            int num1 = int.Parse(command1[0]);
            int num2 = int.Parse(command2[0]);
            int group1 = int.Parse(command1[1]);
            int group2 = int.Parse(command2[1]);
            uint mask = 15;
            uint tempBits1 = (numbers[num1] >> (4 * group1) & mask);
            uint tempBits2 = (numbers[num2] >> (4 * group2) & mask);
            numbers[num1] &= ~(mask << (4 * group1));
            numbers[num2] &= ~(mask << (4 * group2));
            numbers[num1] |= (tempBits2 << (4 * group1));
            numbers[num2] |= (tempBits1 << (4 * group2));
        }
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
