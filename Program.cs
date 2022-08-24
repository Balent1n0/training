using System;
public class Calc
{
    public static void Main()
    {
        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Choose the operatin: #1 - 'addition', #2 - 'subtraction', #3 - 'multiplication': ");
        int c = Convert.ToInt32(Console.ReadLine());
        int d;
        switch (c)
        {
            case 1:
                Console.WriteLine($"Decision: {a} + {b} = {d = a + b}");
                break;
            case 2:
                Console.WriteLine($"Decision: {a} - {b} = {d = a - b}");
                break;
            case 3:
                Console.WriteLine($"Decision: {a} * {b} = {d = a * b}");
                break;
            default:
                Console.WriteLine("Undefind number of operation.");
                break;
        }
    }
}
