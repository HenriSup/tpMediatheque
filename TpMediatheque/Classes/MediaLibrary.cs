using System;
using System.Collections.Generic;
using System.Text;

namespace TpMediatheque.Classes
{
    class MediaLibrary
    {
        private String name;
        private String address;
        private List<Media> medias;
        private List<Member> members;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public List<Media> Medias { get => medias; set => medias = value; }
        public List<Member> Members { get => members; set => members = value; }

        public MediaLibrary(String name, String address)
        {
            Name = name;
            Address = address;
            Medias = new List<Media>();
            Members = new List<Member>();
        }
        
        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void AddMedia(Media media)
        {
            Medias.Add(media);
        }

        public void AddStock(Media media, int number)
        {
            int mediaIndex = Medias.FindIndex(m => m.Id == media.Id);
            if (mediaIndex == -1)
            {
                Console.WriteLine("Ce media est introuvable dans cette bibliothèque");
            } else
            {
                Medias[mediaIndex].Stock += number;
            }
        }

        public void BorrowMedia(Media media, Member member)
        {
            int mediaIndex = Medias.FindIndex(m => m.Id == media.Id);

            if (mediaIndex != -1)
            {
                if (member.Medias.Count < 3)
                {
                    if (media.Stock > 0)
                    {
                        //trouver le putain de membre et modifier ses trucs
                        int memberIndex = Members.FindIndex(m => m.Id == member.Id);

                        if (memberIndex != -1)
                        {
                            Members[memberIndex].AddMedia(media);
                            Medias[mediaIndex].Stock--;
                        }
                        else
                        {
                            Console.WriteLine("Le membre n'est pas dans la liste");
                        }
                    }
                    else
                    {
                        Console.WriteLine("A pu faut commander");
                    }
                }
                else
                {
                    Console.WriteLine("Le client " + member.FirstName + " " + member.LastName + " ne peut plus emprunter");
                }
            }
            else
            {
                Console.WriteLine("Le membre est introuvable dans la liste");
            }

        }
    }
}
