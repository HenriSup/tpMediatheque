using System;
using System.Collections.Generic;
using System.Text;

namespace TpMediatheque.Classes
{
    public class CD : Media
    {
        private String artist;

        public string Artist { get => artist; set => artist = value; }

        public CD(String artist, String titre, DateTime releaseDate, String editor, int stock) : base(titre, releaseDate, editor, stock)
        {
            Artist = artist;
        }

    }
}
