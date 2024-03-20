using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Logger;
using Tema2Console.Models;
using Tema2Console.Orders;

namespace Tema2Console.Factory
{
    public class OrderFactory : IOrderFactory
    {
        public ILogger _logger;
        public OrderFactory( ILogger logger) { 
            _logger = logger;
        }
        public Orderer Create(Order order)
        { 
            switch(order.Type) {
                case OrderType.Product:
                    return new BreakfastOrderer(_logger);
               
                case OrderType.Breakfast:

                    return new BreakfastOrderer(_logger);
                
                case OrderType.Room:
                    return new RoomOrderer(_logger);
                
                default:
                    return new UnknownOrderer(_logger);
            }
        }
    }
}
