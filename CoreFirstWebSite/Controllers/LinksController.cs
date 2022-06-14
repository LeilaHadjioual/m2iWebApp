using CoreFirstWebSite.Models.Links;
using m2iWebApp.Models;
using m2iWebApp.Repository.Links;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreFirstWebSite.Controllers
{
    public class LinksController : Controller
    {
        public IActionResult Index()
        {
            //j'appelle mon modèle de domaine - je créé une liste de liens
            List<LinkModel> allLinks = LinksRepository.getAllLinks();
                
            //ancienne version
                /**new List<LinkModel>()
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
            ;**/

            //ajout pour pouvoir l'utiliser dans la vue, je transforme mon modèle de domaine en modèle de vue
            LinksListViewModel vm = new LinksListViewModel
            {
                AllLinks = allLinks
            };

            //j'inclus mon modèle dans la vue
            return View(vm);
        }
    }
}
