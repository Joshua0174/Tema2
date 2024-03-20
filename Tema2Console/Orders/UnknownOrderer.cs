using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Logger;
using Tema2Console.Models;

namespace Tema2Console.Orders
{
    public class UnknownOrderer : Orderer
    {
        public UnknownOrderer(ILogger logger) : base(logger){}
        public override decimal ProcessOrder(Order order)
        {
            return 0;
        }
    }
}
