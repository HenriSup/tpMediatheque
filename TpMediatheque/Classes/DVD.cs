using System;
using System.Collections.Generic;
using System.Text;

namespace TpMediatheque.Classes
{
    class DVD : Media
    {
        private String studio;

        public string Studio { get => studio; set => studio = value; }

        public DVD(String studio,String titre, DateTime releaseDate, String editor, int stock) : base(titre,releaseDate,editor,stock)
        {
            Studio = studio;
        }

    }
}
