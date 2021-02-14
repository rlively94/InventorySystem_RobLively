using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_RobLively
{
    class Inhouse : Part
    {
        public int MachineId { get; set; }

        public Inhouse(int partId, string name, decimal price, int max, int min, int inStock, int machineId) : base(partId, name, price, max, min, inStock)
        {
            MachineId = machineId;
        }
    }
}
