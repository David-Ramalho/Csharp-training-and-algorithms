using System;
using System.Collections.Generic;
using System.Globalization;


namespace RentACar.entities
{
	class Invoice
	{
		public double BasicPayment { get; set; }
		public double Tax { get; set; }

		public Invoice(double basicPayment, double tax)
		{
			BasicPayment = basicPayment;
			Tax = tax;
		}
		public double TotalPayment
		{
			get { return BasicPayment + Tax; }
		}

		public override string ToString()
		{
			return "Basic Payment: "
				+ BasicPayment.ToString("f2", CultureInfo.InvariantCulture)
				+ "\nTax: "
				+ TotalPayment.ToString("f2", CultureInfo.InvariantCulture);

		}
	}

}
