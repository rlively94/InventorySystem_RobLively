using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem_RobLively
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> Parts = new BindingList<Part>();

        //used to reference objects selected in main screen grids
        public static int CurrentProdIndex { get; set; }
        public static int CurrentProdId { get; set; }
        public static Product CurrentProduct { get; set; }
        public static int CurrentPartIndex { get; set; }
        public static int CurrentPartId { get; set; }
        public static Part CurrentPart { get; set; }

        //used to generate new IDs, increments +1 on each addition
        public static int PartId { get; set; }
        public static int ProductId { get; set; }

        public static void PopulateFormTables()
        {
            //create products and parts
            ProductId = 1;
            PartId = 1;
            Product prod1 = new Product(ProductId, "Prod 1", 10.10M, 100, 1, 10);
            ProductId++;
            Product prod2 = new Product(ProductId, "Prod 2", 20.20M, 200, 2, 20);
            ProductId++;
            Product prod3 = new Product(ProductId, "Prod 3", 30.30M, 300, 3, 30);
            ProductId++;
            Product prod4 = new Product(ProductId, "Prod 4", 40.40M, 400, 4, 40);
            ProductId++;
            Part part1 = new Inhouse(PartId, "Part 1", 10.10M, 100, 1, 10, 10);
            PartId++;
            Part part2 = new Inhouse(PartId, "Part 2", 20.20M, 200, 2, 20, 20);
            PartId++;
            Part part3 = new Outsourced(PartId, "Part 3", 30.30M, 300, 3, 30, "Company 1");
            PartId++;
            Part part4 = new Outsourced(PartId, "Part 4", 40.40M, 400, 4, 40, "Company 2");
            PartId++;

            //add new objects to binding lists
            AddProduct(prod1);
            AddProduct(prod2);
            AddProduct(prod3);
            AddProduct(prod4);
            AddPart(part1);
            AddPart(part2);
            AddPart(part3);
            AddPart(part4);

            //associate parts and products
            prod1.AssociatedParts.Add(part1);
            prod1.AssociatedParts.Add(part2);
            prod2.AssociatedParts.Add(part3);
            prod2.AssociatedParts.Add(part4);
            prod3.AssociatedParts.Add(part1);
            prod3.AssociatedParts.Add(part2);
            prod4.AssociatedParts.Add(part3);
            prod4.AssociatedParts.Add(part4);
        }

        public static void AddProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public static bool RemoveProduct(int productId)
        {
            try
            {
                Products.Remove(LookupProduct(productId));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Product LookupProduct(int productId)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductId.Equals(productId))
                {
                    CurrentProdIndex = i;
                    return Products[i];
                }
            }

            CurrentProdIndex = -1;
            return null;
        }

        public static void UpdateProduct(int productId, Product updateProduct)
        {
            Products.Insert(CurrentProdIndex, updateProduct);
            Products.RemoveAt(CurrentProdIndex + 1);
        }


        public static void AddPart(Part newPart)
        {
            Parts.Add(newPart);
        }

        public static bool RemovePart(int partId)
        {
            try
            {
                Parts.Remove(LookupPart(partId));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Part LookupPart(int partId)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].PartId.Equals(partId))
                {
                    CurrentPartIndex = i;
                    return Parts[i];
                }
            }

            CurrentProdIndex = -1;
            return null;
        }

        public static void UpdatePart(Part updatePart)
        {
            Parts.Insert(CurrentPartIndex, updatePart);
            Parts.RemoveAt(CurrentPartIndex + 1);
        }
    }
}
