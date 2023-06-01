using System;
using System.Collections.Generic;
using System.Globalization;
using RentACar.entities;

Console.WriteLine("Enter a rental data:");
Console.WriteLine("Car Model: ");
string model= Console.ReadLine();
Console.WriteLine("Pickup (dd/mm/yyyy hh:mm): ");
DateTime start= DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Return (dd/mm/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


CarRental carRental= new CarRental(start, finish, new Vehicle(model));

