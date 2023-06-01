using System;
using System.Collections.Generic;
using System.Globalization;
using RentACar.entities;
using RentACar.services;


Console.WriteLine("Enter a rental data:");
Console.WriteLine("Car Model: ");
string model = Console.ReadLine();
Console.WriteLine("Pickup (dd/mm/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Return (dd/mm/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.WriteLine("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("invoice: ");
Console.WriteLine(carRental.Invoice);
