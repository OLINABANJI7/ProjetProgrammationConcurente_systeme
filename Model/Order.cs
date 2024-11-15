using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int id { get; set; }
        public Client client { get; set; }
        public string status { get; private set; }

        public void updateStatus(string _status)
        {
            status = _status;
        }
    }
}
