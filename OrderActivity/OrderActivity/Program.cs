using System;
using System.Globalization;
using OrderActivity.Entities;
using OrderActivity.Entities.Enums;

namespace OrderActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date: (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
        }
    }
}
