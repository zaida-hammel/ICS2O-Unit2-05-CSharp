// Created by: Zaida Hammel
// Created on: March 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the pay.
        int Hours;
        int Rate;

        Console.WriteLine("This function calculates the pay.");
        Console.WriteLine("");
        Console.Write("Number of hours worked: ");
        Hours = Convert.ToInt32(Console.ReadLine());
        Console.Write("Hourly rate: ");
        Rate = Convert.ToInt32(Console.ReadLine());

        Double Pay = (Hours * Rate) * (0.82);
        Double Taxes = (Hours * Rate) * (0.18);

        Console.WriteLine("");
        Console.Write("Your pay will be: " + Pay.ToString("0.00"));
        Console.WriteLine("");
        Console.Write("The government will take: " + Taxes.ToString("0.00"));
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}