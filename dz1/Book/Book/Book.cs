using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        Title title;
        Content content;
        Author author;

        public Book (Title titles, Content contents, Author authors)
        {
            this.title = titles;
            this.content = contents;
            this.author = authors;
        }

        public void Show()
        {
            this.title.Show();
            this.content.Show();
            this.author.Show();
        }
    }
}
