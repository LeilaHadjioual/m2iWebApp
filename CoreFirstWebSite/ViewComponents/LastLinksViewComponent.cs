using CoreFirstWebSite.Models.Links;
using m2iWebApp.Repository.Links;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreFirstWebSite
{
    public class LastLinksViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //On récupère tous les liens 
            var allLinks = LinksRepository.GetAllLinks();

            var vm = new CategoryListViewModel
            {
                AllLinks = allLinks
            };

            //Ici on peut passer un modèle à la vue
            return View("LastLinks", vm);
        }
    }
}
