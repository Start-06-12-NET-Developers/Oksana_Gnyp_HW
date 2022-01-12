using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Content
    {
        string cont;

        public string Cont
        {
            private get
            {
                if (cont != null)
                    return cont;
                else
                    return "Текст книги отсутствует.";
            }
            set
            {
                cont = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Cont);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
