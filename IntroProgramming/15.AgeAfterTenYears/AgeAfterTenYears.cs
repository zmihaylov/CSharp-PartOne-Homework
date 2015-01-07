//Write a program to read your birthday from the console and print how old
//you are now and how old you will be after 10 years.

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birth in format dd/MM/yyyy: ");
        string birth = Console.ReadLine();
        string[] splittedBirth = birth.Split(new char[] { ' ', ',', '.', '/' }, StringSplitOptions.RemoveEmptyEntries);

        DateTime yourBirth = new DateTime(int.Parse(splittedBirth[2]), int.Parse(splittedBirth[1]), int.Parse(splittedBirth[0]));

        int age = DateTime.Now.Year - yourBirth.Year;

        if (DateTime.Now.AddYears(-age) < yourBirth)
        {
            age--;
        }

        Console.WriteLine("After ten years you will be {0}.",age + 10);
    }
}