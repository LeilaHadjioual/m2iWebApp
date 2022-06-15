using CoreFirstWebSite.Models.Users;
using m2iWebApp.Models;
using m2iWebApp.Repository.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreFirstWebSite.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            //instancie une liste d'utilisateurs
            List<UserModel> allUsers = UsersRepository.getAllUsers();


            /**{
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
            };**/

            UsersListViewModel vm = new UsersListViewModel
            {
                AllUsers = allUsers
            };

            return View(vm);
        }


        public IActionResult GetUser(int idUser)
        {
            List<UserModel> allUsers = UsersRepository.getAllUsers();

            UserModel myUser = null;
            foreach (var user in allUsers)
            {
                if (user.Id == idUser)
                {
                    myUser = user;
                }
            }

            //si je n'ai pas trouvé de renvoie 404
            if (myUser == null)
            {
                return NotFound();
            }
            else //sinon je renvoie ma vue
            {
                return View(myUser);
            }
        }

        public IActionResult UsersAjax()
        {
            return View();
        }
    }
}
