using System;
using System.Collections.Generic;
using System.Text;

namespace TpMediatheque.Classes
{
    class Book : Media
    {
        private String writer;

        public string Writer { get => writer; set => writer = value; }

        public Book(string writer, string titre, DateTime releaseDate, string editor, int stock) : base(titre, releaseDate, editor, stock)
        {
            Writer = writer;
        }

    }

}
