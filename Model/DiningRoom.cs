using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DiningRoom
    {
        public List<Table> Tables { get; set; } = new List<Table>();

        public void AssignTable(Client client, Table table)
        {
            if (table.isAvailable)
            {
                client.table = table;
                table.reserve();
            }
        }

        public void freeTable(Table table)
        {
            table.free();
        }
    }
}
