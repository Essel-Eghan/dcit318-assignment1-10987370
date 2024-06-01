using System;

class TicketCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to My Movie Theater Ticket Calculator ");
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine($"Hello, {userName}!");

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        double ticketPrice = CalculateTicketPrice(age);

        Console.WriteLine($"The ticket price for you is GHC {ticketPrice:F2}");
    }

    public static double CalculateTicketPrice(int age)
    {
        const double standardPrice = 10;
        const double discountedPrice = 7;

        if (age >= 65 || age <= 12)
        {
            return discountedPrice;
        }
        else
        {
            return standardPrice;
        }
    }
}