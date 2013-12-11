//******************************************************************************************************************************
//Name: Shihuan Shao
//ASUID: 1203060451
//Assignment 1, Section 3, Question 2
//Description: A Console  Application for the service developed in the Question 1. It allows you to do conversion between Fahrenheit and 
//Celsius temperatures by consuming that the service. 
//How to use: First choose the converstion type by entering capital A or B, then enter an integer (not floating number) to get converted temperature.
//******************************************************************************************************************************
using System;
using _1_2.TempConvertRef;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TempConvertRef.ServiceClient tempConvert = new TempConvertRef.ServiceClient();
            Console.WriteLine("Select A or B:");
            Console.WriteLine("A. Celsius to Fahrenheit");
            Console.WriteLine("B. Fahrenheit to Celsius");
            string choice = Console.ReadLine();
            if (choice == "A")//Convert Celsius to Fahrenheit
            {
                Console.WriteLine("Please enter an integer: ");
                try
                {
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Celsius = {0} <==> Fahrenheit = {1}", c, tempConvert.c2f(c));
                }
                catch
                {
                    Console.WriteLine("Please enter an integer!");
                    tempConvert.Close();
                    Console.ReadKey();
                }
            }
            else if (choice == "B")//Convert Fahrenheit to Celsius
            {
                Console.WriteLine("Please enter an integer: ");
                try
                {
                    int f = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Fahrenheit = {0} <==> Celsius = {1}", f, tempConvert.f2c(f));
                }
                catch
                {
                    Console.WriteLine("Please enter an integer!");
                    tempConvert.Close();
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
            tempConvert.Close();
            Console.ReadKey();
            return;
        }
    }
}
