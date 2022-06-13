using m2iWebApp.Models;
using System.Collections.Generic;

namespace CoreFirstWebSite.Models.Links
{
    public class LinksListViewModel
    {
        public List<LinkModel> AllLinks { get; set; }
        //ajouter ici si besoin d'utilisation d'un autre model par exemple user et modifier le controleur
    }
}
