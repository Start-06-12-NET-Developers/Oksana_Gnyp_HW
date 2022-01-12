using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Author
    {
        string cont;

        public string Cont
        {
            private get
            {
                if (cont != null)
                    return cont;
                else
                    return "Автор отсутствует.";
            }
            set
            {
                cont = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Cont);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
