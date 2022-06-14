using CoreFirstWebSite.Models.Links;
using m2iWebApp.Models;
using m2iWebApp.Repository.Links;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CoreFirstWebSite.Controllers
{
    public class LinksController : Controller
    {
        //[Route("/AfficheMoiLesLienMonCoco")]
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

            //j'instancie pour pouvoir l'utiliser dans la vue, je transforme mon modèle de domaine en modèle de vue
            CategoryListViewModel vm = new CategoryListViewModel
            {
                AllLinks = allLinks
            };

            //j'inclus mon modèle dans la vue
            return View(vm);
        }

        public IActionResult Link(int idLien)
        {
            //on récupère tous les liens
            List<LinkModel> allLinks = LinksRepository.getAllLinks();

            //utilisant linq à la place de foreach
            //var leLien = allLinks.FirstOrDefault(monLien => monLien.Id == idLien);

            //on parcours tous les liens et assigne l'id du lien au paramètre de la methode
            LinkModel monLien = null;
            foreach(var lien in allLinks)
            {
                if(lien.Id == idLien)
                {
                    monLien = lien;
                }
            }

            //si je n'ai pas trouvé l'id, je renvoie une erreur 404
            if(monLien == null)
            {
                return NotFound();
            }
            else //sinon je renvoie ma vue
            {
                return View(monLien);
            }
        }
    }
}
