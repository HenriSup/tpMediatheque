using System;
using System.Collections.Generic;
using System.Text;

namespace TpMediatheque.Classes
{
    class Comic : Media
    {
        private String writer;
        private String illustrator;

        public string Writer { get => writer; set => writer = value; }
        public string Illustrator { get => illustrator; set => illustrator = value; }

        public Comic(string writer, string illustrator,string titre, DateTime releaseDate, string editor, int stock) : base(titre, releaseDate, editor, stock)
        {
            Writer = writer;
        }
    }
}
