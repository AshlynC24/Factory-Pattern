using System;
namespace FactoryPattern
{
	public class Samsung: IPhone
	{
		public Samsung()
		{
		}

		public int price { get; set; } = 300;

		public void PhoneDetails()
		{
			Console.WriteLine("This is the latest Samsung!");
		}
    }
}

