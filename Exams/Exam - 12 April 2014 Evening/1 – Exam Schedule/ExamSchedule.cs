using System;

class ExamSchedule
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());
        if (timeOfDay == "PM")
        {
            hours += 12;
        }
        DateTime startTime = new DateTime(2000, 1, 1, hours, minutes, 0);
        DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationMinutes);
        Console.WriteLine("{0:hh:mm:tt}", endTime);
    }
}
