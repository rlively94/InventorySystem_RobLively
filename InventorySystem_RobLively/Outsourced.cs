using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_RobLively
{
    class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int partId, string name, decimal price, int max, int min, int inStock, string companyName) : base(partId, name, price, max, min, inStock)
        {
            CompanyName = companyName;
        }
    }
}
