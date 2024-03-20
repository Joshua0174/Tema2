using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Logger;
using Tema2Console.Models;

namespace Tema2Console.Orders
{
    public class RoomOrderer:Orderer
    {
        public RoomOrderer(ILogger logger):base(logger){ }
        public override decimal ProcessOrder(Order order)
        {
            logger.Log("Processing Room order...");

            logger.Log("Validating order parameters...");

            if (order.Quantity == 0)
            {
                logger.Log("-Room order must specify Quantity");
                return 0;
            }

            if (order.Price == 0)
            {
                logger.Log("-Room order must specify Price");
                return 0;
            }

            if (string.IsNullOrEmpty(order.ReservationDate))
            {
                logger.Log("-Room order must specify Reservation Date");
                return 0;
            }

            if (!DateTime.TryParseExact(order.ReservationDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var pasedReservationDate))
            {    
                logger.Log("Data rezervarii "+order.ReservationDate.ToString());
                logger.Log("-Reservation Date must be a valid date");
                return 0;
            }

            if (pasedReservationDate < DateTime.Now.AddMonths(1))
            {
                 return (order.Quantity * order.Price) * 0.9m;
            }
            else if (pasedReservationDate < DateTime.Now.AddMonths(2))
            {
                return (order.Quantity * order.Price) * 0.8m;
            }
            else
            {
                return order.Quantity * order.Price;
            }
        }
    }
}
