namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What type of phone are you interested in today?");
            Console.WriteLine("Please Choose Iphone or Samsung.");

            string userInput = Console.ReadLine();

            IPhone choice1 = FactoryPhone.PhoneOrder(userInput);

            choice1.PhoneDetails();

            Console.WriteLine($"The Price of that phone is {choice1.price}");

        }
    }
}
