using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Models;

namespace Tema2Console.OrderSerializer
{
    internal class OrderSerializer : IOrderSerializer
    {
        public Order GetOrderFromJsonString(string orderJson)
        {
            return JsonConvert.DeserializeObject<Order>(orderJson,
                new StringEnumConverter());
        } 
    }
}
