using CoreFirstWebSite.Models.Users;
using m2iWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreFirstWebSite.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            //instancie une liste d'utilisateurs
            List<UserModel> allUsers = new List<UserModel>()
            {
                new UserModel()
                {
                    Id = 1,
                    Name = "DURAND",
                    Firstname = "Toto",
                    Mail = "toto.durand@yopmail.com"
                },
                new UserModel()
                {
                    Id = 2,
                    Name = "DUPONT",
                    Firstname = "Titi",
                    Mail = "titi.dupont@yopmail.com"
                },
            };

            UsersListViewModel vm = new UsersListViewModel
            {
                AllUsers = allUsers
            };

            return View(vm);
        }
    }
}
