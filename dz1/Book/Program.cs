using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название книги: ");
            Title title = new Title();
            title.Cont = Console.ReadLine();

            Console.Write("Введите текст книги: ");
            Content content = new Content();
            content.Cont = Console.ReadLine();

            Console.Write("Введите автора книги: ");
            Author author = new Author();
            author.Cont = Console.ReadLine();

            Console.Clear();

            Book book = new Book(title, content, author); 
            book.Show();

            Console.ReadKey();
        }
    }
}
