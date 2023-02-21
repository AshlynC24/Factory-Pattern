using System;
namespace FactoryPattern
{
	internal static class FactoryPhone
	{
		public static IPhone PhoneOrder(string Choice)
		{
			switch (Choice.ToLower())
			{
				case "Iphone":
					return new Apple();
				case "Samsung":
					return new Samsung();
				default:
					return new Apple();
			}
		}
	}
}

