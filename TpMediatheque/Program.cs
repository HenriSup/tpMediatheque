using System;
using TpMediatheque.Classes;

namespace TpMediatheque
{
    class Program
    {
        static void Main(string[] args)
        {
            MediaLibrary maMediaLibrairie = new MediaLibrary("Mediatheque G.Molard", "Mouvaux - 59420 3 rue du moulin");

            Book monLivre = new Book("George R. R. Martin", "Le trône de fer - Tome 1 : Le trône de fer", new DateTime(2018, 09, 10), "J'ai lu", 2);

            CD monCD1 = new CD("The 1975", "Love it if we made it", new DateTime(2018, 09, 21),"Universal",10);
            CD monCD2 = new CD("Billie Eilish", "WHERE DO WE GO WHEN WE ALL FALL ASLEEP", new DateTime(2018, 09, 10),"Universal",5);

            Comic maBd = new Comic("Bryan Lee O'Malley", "Bryan Lee O'Malley", "Scott Pilgrim - Tome 1 : Scott Pilgrim Precious Little Life", new DateTime(2010, 3,10 ),"Milady",1);

            DVD monDVD = new DVD("DC Comics", "Batman begins", new DateTime(2005, 01, 01), "Nolan", 1);

            maMediaLibrairie.AddMedia(monLivre);
            maMediaLibrairie.AddMedia(monCD1);
            maMediaLibrairie.AddMedia(monCD2);
            maMediaLibrairie.AddMedia(maBd);
            maMediaLibrairie.AddMedia(monDVD);

            //à tester
        }
    }
}