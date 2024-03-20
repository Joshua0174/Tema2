using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Logger;
using Tema2Console.Models;

namespace Tema2Console.Orders
{
    public class ProductOrderer : Orderer
    {
        public ProductOrderer(ILogger logger) : base(logger){}
        public override decimal ProcessOrder(Order order)
        {
            logger.Log("Processing Product order...");

            logger.Log("Validating order parameters...");

            if (string.IsNullOrEmpty(order.Name))
            {
                logger.Log("-Product order must specify Name");
                return 0;
            }

            if (order.Quantity == 0)
            {
                logger.Log("-Product order must specify Quantity");
                return 0;
            }

            if (order.Price == 0)
            {
                logger.Log("-Product order must specify Price");
                return 0;
            }

            var price = order.Quantity * order.Price;
            if (order.Name == "Fanta")
            {
                price *= 0.75m;
            }

            return price;
        }
    } 
}
