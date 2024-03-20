using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tema2Console.Factory;
using Tema2Console.FileSource;
using Tema2Console.Logger;
using Tema2Console.Models;
using Tema2Console.OrderSerializer;

namespace Tema2Console
{
    public class HotelReception
    {
        private ILogger _logger;    
        private IFileSource _fileSource;
        private IOrderSerializer _orderSerializer;
        private IOrderFactory _factory;
        public decimal FinalPrice { get; set; }

        public HotelReception(ILogger logger, IFileSource fileSource, IOrderSerializer orderSerializer, IOrderFactory orderFactory) { 
            _factory = orderFactory;
            _logger = logger;
            _fileSource = fileSource;
            _orderSerializer = orderSerializer;
        }
        public void ProcessOrder()
        {
            _logger.Log("Start processing...");

            _logger.Log("Loading order from file...");
            var dataJson = _fileSource.GetOrderSource();

            _logger.Log("Deserializing Order object from json data...");
            var order =_orderSerializer.GetOrderFromJsonString(dataJson);

            if (order == null)
            {
                _logger.Log("Order type not parsed successfully.");
                return;
            }

            var orderer=_factory.Create(order);
            FinalPrice = orderer.ProcessOrder(order);

            _logger.Log("Rating completed.");
        }
    }
}
