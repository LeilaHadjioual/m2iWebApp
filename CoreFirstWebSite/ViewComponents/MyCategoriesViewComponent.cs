using CoreFirstWebSite.Models.Category;
using m2iWebApp.Repository.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreFirstWebSite
{
    public class MyCategoriesViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //Mettre du code C#
            var allCategories = CategoriesRepository.getAllCategories();

            var vm = new CategoriesListViewModel
            {
                AllCategories = allCategories
            };

            //Ici on peut passer un modèle à la vue
            return View("MyCategories", vm);
        }
    }
}
