using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console.Logger
{
    public class Logger2 : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(">>Logger2: "+message);
        }
    }
}
