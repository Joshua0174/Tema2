using Tema2Console.Factory;
using Tema2Console.Logger;

namespace Tema2Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client...");
            var loggerInstance = new Logger2();
            var hotelReception = new HotelReception(loggerInstance,
                                                    new FileSource.FileSource(),
                                                    new OrderSerializer.OrderSerializer(),
                                                    new OrderFactory(loggerInstance));
            hotelReception.ProcessOrder();

            if (hotelReception.FinalPrice == 0)
            {
                Console.WriteLine("No order was processed.");
            }
            else
            {
                Console.WriteLine($"Final price for you order: {hotelReception.FinalPrice} RON");
            }
        }
    }
}
