using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_RobLively
{
    public class Product
    {
        private int _inStock;
        private int _min;

        public  BindingList<Part> AssociatedParts = new BindingList<Part>();
        public static int CurrentAssocPartIndex { get; set; }

        public int ProductId { get; set; }

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

        public int Max { get; set; }

        public Product(int productId, string name, decimal price, int max, int min, int inStock, BindingList<Part> assocParts)
        {
            AssociatedParts = assocParts;
            ProductId = productId;
            Name = name;
            Price = price;
            Max = max;
            Min = min;
            InStock = inStock;
        }

        public Product(int productId, string name, decimal price, int max, int min, int inStock)
        {
            AssociatedParts = new BindingList<Part>();
            ProductId = productId;
            Name = name;
            Price = price;
            Max = max;
            Min = min;
            InStock = inStock;
        }

        public  void AddAssociatedPart(Part newAssocPart)
        {
            AssociatedParts.Add(newAssocPart);
        }

        public  bool RemoveAssociatedPart(int partId)
        {
            bool success = false;
            foreach (Part assocPart in AssociatedParts)
            {
                if (partId == assocPart.PartId)
                {
                    AssociatedParts.Remove(assocPart);
                    success = true;
                }
            }

            return success;
        }

        public  Part LookupAssociatedPart(int partId)
        {
            for (int i = 0; i < AssociatedParts.Count; i++)
            {
                if (AssociatedParts[i].PartId.Equals(partId))
                {
                    CurrentAssocPartIndex = i;
                    return AssociatedParts[i];
                }
            }

            return null;
        }
    }
}
