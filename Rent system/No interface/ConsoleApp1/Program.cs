using System;
using System.Globalization;
using ConsoleApp1.entities;

Console.WriteLine("Welcome to you account. Lets talk bussiness");
Console.WriteLine("Enter account data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Holder: ");
String holder = Console.ReadLine();
Console.Write("Initial balance: ");
double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Withdraw limit: ");
double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Account acc = new Account(number, holder, balance, withdrawLimit);