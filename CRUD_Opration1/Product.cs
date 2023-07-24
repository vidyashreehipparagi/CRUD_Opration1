using System;


using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Opration1
{
    public class Product
    {
     public int Id { set;get; }
     public string Name { set;get; }
        
     public double Price { set;get; }
    }

    public class ProductCRUD
    {
        private List<Product> products;
        public ProductCRUD()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product prod)
        {
            //products from list declaration
            products.Add(prod);
        }
        public List<Product> GetProduct()
        {//to print details
            return products;
        }
        public void UpdateProduct(Product prod)
        {
            //to update we are comparing 
            foreach(Product p in products)
            {
                if(p.Id == prod.Id)
                {
                    p.Name = prod.Name;
                    p.Price = prod.Price;
                    break;
                }
            }
        }
        public void DeleteProduct(int id)
        {
            foreach (Product p in products)
            {
                if(p.Id == id)
                {
                    products.Remove(p);
                    break;  
                }
            }

        }

    }
}
