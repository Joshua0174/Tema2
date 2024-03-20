using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console.Models
{
    public class Order
    {  
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity {  get; set; }
        #region Room
        public string ReservationDate { get; set; }
        #endregion
        #region Product
        public string Name { get; set; }
        #endregion

        #region Breakfast
        public string ServingDate { get; set; }
        #endregion
    }
}
