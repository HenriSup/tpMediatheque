using System;
using System.Collections.Generic;
using System.Text;

namespace TpMediatheque.Classes
{
    class Member
    {
        public static int counter = 0;

        private int id;
        private String firstName;
        private String lastName;
        private List<Media> medias;

        public int Id { get => id; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public List<Media> Medias { get => medias; set => medias = value; }

        public Member(String firstName, String lastName)
        {
            this.id = counter;
            FirstName = firstName;
            LastName = lastName;
            Medias = new List<Media>();

            Member.counter++;
        }

        public void AddMedia(Media media)
        {
            Medias.Add(media);
        }

    }
}
