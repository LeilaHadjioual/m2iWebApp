using m2iWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace m2iWebApp.Repository.Links
{
    public static class LinksRepository
    {
        public static List<LinkModel> GetAllLinks()
        {   //on créé une liste de liens
            return new List<LinkModel>()
            {
                 new LinkModel()
                {
                    Id = 1,
                    Name = "Code My UI",
                    Description = "Site avec des Liens pour le dev",
                    Url = "https://codemyui.com"
                },
                new LinkModel()
                {
                    Id = 2,
                    Name = "Exercism",
                    Description = "Site avec des exos pour le dev",
                    Url = "https://exercism.com"
                },
            };

        }

    }
}
