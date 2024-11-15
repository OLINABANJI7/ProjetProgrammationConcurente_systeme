using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderFactory
    {
        public Order createOrder(Client client)
        {
            return new Order { client = client };
        }
    }
}
