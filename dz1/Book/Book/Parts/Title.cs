using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Title
    {
        string cont;

        public string Cont
        {
            get
            {
                if (cont != null)
                {
                    return cont;
                }

                else
                {
                    return "Название отсутствует.";
                }

            }
            set
            {
                cont = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Cont);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
