﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    delegate void Message();

    delegate void Drive();

    delegate double Fuel(double fuel, double price);

    public class Speed
    {
        public static void PrintSpeed()
        {
            Console.WriteLine("Ваша машина едет");
        }

        public static void PrintStop()
        {
            Console.WriteLine("Ваша машина стоит");
        }
    }

    public class SumFuel
    {
        public static double Fill(double  fuel, double price) => fuel * price;
    }

    delegate int Operation(int x, int y);

    public class Primer
    {
        public static void Print() => Console.WriteLine("Привет мир!");

        public static void PrintHow() => Console.WriteLine("Как дела?");
    }

    public class Primer1
    {
        public static int Add(int x, int y) => x + y;

        public static int Multiply(int x, int y) => x * y;
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Message message = Primer.Print;

            message += Primer.PrintHow; // добавление метода в делегат, -= удаление метода из делегата

            message.Invoke();

            Console.WriteLine("\nРабота со значимыми типами\n");


            Operation operation = Primer1.Add;

            int returnAdd = operation.Invoke(5,5);

            

            Operation operation2 = Primer1.Multiply;

            int returnMultiplier = operation2.Invoke(5, 5);

            Console.WriteLine($"Сложение: {returnAdd}, Умножение: {returnMultiplier}");

            Drive drive = Speed.PrintSpeed;

            drive += Speed.PrintStop;
            drive.Invoke();

            Fuel fuel = SumFuel.Fill;

            double fill = fuel.Invoke(5, 44);

            Console.WriteLine($"Ваш расход топлива: {fill}р.");

        }

    }
}
