using System;
using System.Collections.Generic;
using System.Text;

namespace TpMediatheque.Classes
{
    public class Media
    {
        public static int counter = 0;

        private int id;
        private string title;
        private DateTime releaseDate;
        private string editor;
        private int stock;

        public int Id { get => id;}
        public string Title { get => title; set => title = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Editor { get => editor; set => editor = value; }
        public int Stock { get => stock; set => stock = value; }

        public Media (String titre, DateTime releaseDate, String editor, int stock)
        {
            this.id = counter;
            Title = titre;
            ReleaseDate = releaseDate;
            Editor = editor;
            Stock = stock;

            Media.counter++;
        }

    }
}
