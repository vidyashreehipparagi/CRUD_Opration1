using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Opration1
{
    public class Book
    {
      public int id {  get; set; }
      public string name { get; set; }
      public string aname { get; set; }
    public double price { get; set; }
    }
    public class BookCRUD
    {
        List<Book> books;
        public BookCRUD()
        {
            books = new List<Book>();
        }
        public void AddBook(Book b) { 
        books.Add(b);
        }
        public List<Book> GetBooks()
        {
            return books;
        }
        public void UpdateBook(Book b)
        {
            foreach (Book book in books)
            {
                if(book.id == b.id)
                book.name = b.name;
                book.price = b.price;
                break;

            }
        }
        public void DeleteBook(int id)
        {
            foreach(Book book in books)
            {
                if (book.id == id)
                {
                 books.Remove(book);
                }
                break;
            }
        }
        static void Main(string[] args)
        {
            BookCRUD crud = new BookCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1. Add Book Details");
                Console.WriteLine("2. Update Book");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4.Display Book");
                int option1 = Convert.ToInt32(Console.ReadLine());
                switch (option1)
                {
                    case 1:
                        Book b1 = new Book();
                        Console.WriteLine("Enter id");
                        b1.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        b1.name = Console.ReadLine();
                        Console.WriteLine("Enter author name");
                        b1.aname = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        b1.price = Convert.ToDouble(Console.ReadLine());
                        crud.books.Add(b1);

                        break;
                    case 2:
                        Book b2 = new Book();
                        Console.WriteLine("Enter id");
                        b2.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        b2.name = Console.ReadLine();
                        Console.WriteLine("Enter author name");
                        b2.aname = Console.ReadLine();
                        Console.WriteLine("Enter Price");
                        b2.price = Convert.ToDouble(Console.ReadLine());
                        crud.books.Add(b2);
                        break;
                    case 3:
                        Book b3 = new Book();
                        Console.WriteLine("Enter id to remove");
                        int id = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        List<Book> list = new List<Book>();
                        foreach (Book item in list)
                        {
                            Console.WriteLine($"{item.id} {item.name} {item.aname} {item.price}");
                         
                        }
                        Console.WriteLine("Press 1 for continue ");
                        option = Convert.ToInt32(Console.ReadLine());
                        break;
                } 
                

            
            } while (option == 1);                  
        }
       
    }
    
}
