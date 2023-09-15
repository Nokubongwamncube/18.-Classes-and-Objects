using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //creation of book1 object, its get all it attribute from the cass book

            //creating my first book
            book1.title = "Harry Potter";
            book1.author = "JK Rolwing";
            book1.pages = 400;

            
            

            Book book2 = new Book(); //creation of book2 object
            //creating my second book
            book2.title = "lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Book book3 = new Book();
            //creating my 3rd book
            book3.title = "Who Moved My Cheese";
            book3.author = "Spencer Johnson";
            book3.pages = 94;

            Book book4 = new Book();
            //creating my 4th book
            book4.title = "Rich Dad, Poor Dad";
            book4.author = "Robert Kiyosaki";
            book4.pages = 336;

            Console.WriteLine(book3.title);
            Console.WriteLine(book3.author);
            Console.WriteLine(book3.pages);

            Console.WriteLine(book4.title);
            Console.WriteLine(book4.author);
            Console.WriteLine(book4.pages);

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);

            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.pages);

            Console.Read();















        }
    }
}
