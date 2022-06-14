using CoreFirstWebSite.Models.Category;
using m2iWebApp.Models;
using m2iWebApp.Repository.Categories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreFirstWebSite.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            List<CategoryModel> allCategories = CategoriesRepository.getAllCategories();
            CategoriesListViewModel vm = new CategoriesListViewModel
            {
                AllCategories = allCategories
            };
            return View(vm);
        }
    }
}
