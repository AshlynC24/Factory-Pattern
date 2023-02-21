using System;
namespace FactoryPattern
{
	public class Apple : IPhone
	{
		public Apple()
		{
		}

		public int price { get; set; } = 1000;

		public void PhoneDetails()
		{
			Console.WriteLine("Nice Choice this is the Iphone 15");
		}

    }
}

