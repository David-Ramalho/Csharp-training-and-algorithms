﻿using System;
using System.Collections.Generic;
using System.Globalization;
using RentACar.entities;


namespace RentACar.services
{
	class RentalService
	{
		public double PricePerHour { get; private set; }
		public double PricePerDay { get; private set; }

		public RentalService(double pricePerHour, double pricePerDay)
		{
			PricePerHour = pricePerHour;
			PricePerDay = pricePerDay;
		}

		private BrazilTaxService _brazilTaxService = new BrazilTaxService();
		public void ProcessInvoice(CarRental carRental)
		{
			TimeSpan duration= carRental.Finish.Subtract(carRental.Start);

			double basicPayment = 0.0;
			if (duration.TotalHours <= 12.0)
			{
				basicPayment = PricePerHour*Math.Ceiling(duration.TotalHours);
			}
			else
			{
				basicPayment= PricePerDay*Math.Ceiling(duration.TotalDays);
			}

			double tax=_brazilTaxService.Tax(basicPayment);

			carRental.Invoice= new Invoice(basicPayment, tax);
		}
	}
}