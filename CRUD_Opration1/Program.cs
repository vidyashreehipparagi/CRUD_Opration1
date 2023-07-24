using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Opration1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //call productCRUD class
            
            ProductCRUD crud=new ProductCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Update Product");
                Console.WriteLine("3.Delete Product");
                Console.WriteLine("4.Display all products");

               int op=Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        //To add products
                        Product p1= new Product();
                        Console.WriteLine("Enter Product Id");
                        p1.Id= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p1.Name= Console.ReadLine();
                        Console.WriteLine("Enter product price");
                        p1.Price= Convert.ToDouble(Console.ReadLine());
                        crud.AddProduct(p1);
                        break;

                    case 2:
                        Product p2= new Product();
                        Console.WriteLine("Enter id to modify");
                        p2.Id= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name to update");
                        p2.Name= Console.ReadLine();
                        Console.WriteLine("Enter product price to update");
                        p2.Price= Convert.ToDouble(Console.ReadLine());
                        crud.UpdateProduct(p2);
                        break;
                    case 3:
                        //DELETE
                        Product p3= new Product();
                        Console.WriteLine("Enter id to delete");
                        int id= Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(id);
                        break;
                    case 4:
                        //To display all products
                        List<Product> list= crud.GetProduct();
                        
                        foreach (Product p in list)
                        {
                            Console.WriteLine($"{p.Id} {p.Name} {p.Price}");
                        }
                        break;
                }
                Console.WriteLine("Press 1 for continue");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);

        }

    }
}
