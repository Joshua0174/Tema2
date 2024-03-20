using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Models;
using Tema2Console.Orders;

namespace Tema2Console.Factory
{
    public interface IOrderFactory
    {
        Orderer Create(Order order);
    }
}
