using System;

class Task4
{
    public static void Main()
    {
        Console.Write("Введите часы (0–23): ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Введите минуты (0–59): ");
        int minutes = int.Parse(Console.ReadLine());

        double hourAngle = (hours % 12) * 30 + minutes * 0.5; 
        double minuteAngle = minutes * 6; 

        double angle = Math.Abs(hourAngle - minuteAngle);
        angle = Math.Min(angle, 360 - angle);

        Console.WriteLine($"Угол между стрелками: {angle:F2} градусов");
    }
}
