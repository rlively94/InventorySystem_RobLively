using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_RobLively
{
    public abstract class Part
    {
        private int _inStock;
        private int _min;
        public int PartId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock
        {
            get => _inStock;

            set
            {
                if (value < Max && value > Min)
                {
                    _inStock = value;
                }
                else
                {
                    throw new Exception("Inventory must be between minimum and maximum values.");
                }
            }
        }

        public int Min
        {
            get => _min;

            set
            {
                if (value < Max)
                {
                    _min = value;
                }
                else
                {
                    throw new Exception("Minimum cannot exceed maximum value.");
                }
            }
        }

        public int Max { get; set;}
        
        public Part(int partId, string name, decimal price, int max, int min, int inStock)
        {
            PartId = partId;
            Name = name;
            Price = price;
            Max = max;
            Min = min;
            InStock = inStock;
        }
    }
}
