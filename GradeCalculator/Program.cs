using System;

class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Grade Calculator Application");
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.WriteLine($"Hello, {userName}!");

        Console.WriteLine("Enter your numerical grade (between 0 and 100):");
        int grade = Convert.ToInt32(Console.ReadLine());

        GradeConverter converter = new GradeConverter();
        string letterGrade = converter.ConvertToLetterGrade(grade);

        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }
}

class GradeConverter
{
    public string ConvertToLetterGrade(int grade)
    {
        if (grade >= 90 && grade <= 100)
        {
            return "A";
        }
        else if (grade >= 80 && grade <= 89)
        {
            return "B";
        }
        else if (grade >= 70 && grade <= 79)
        {
            return "C";
        }
        else if (grade >= 60 && grade <= 69)
        {
            return "D";
        }
        else if (grade >= 0 && grade < 60)
        {
            return "F";
        }
        else
        {
            return "Invalid grade entered.";
        }
    }
}