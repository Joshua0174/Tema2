using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Logger;
using Tema2Console.Models;

namespace Tema2Console.Orders
{
    public abstract class Orderer
    {
        protected ILogger logger;
        public Orderer(ILogger logger)
        {
             this.logger = logger;
        }
        public abstract decimal ProcessOrder(Order order);
    }
}
