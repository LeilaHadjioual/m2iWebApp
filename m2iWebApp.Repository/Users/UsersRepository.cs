using m2iWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace m2iWebApp.Repository.Users
{
    public class UsersRepository
    {

        public static List<UserModel> getAllUsers(){

            return new List<UserModel>()
            {
                new UserModel()
                {
                    Id = 1,
                    Name = "DURAND",
                    Firstname = "Toto",
                    Mail = "toto.durand@gmail.com"
                },
                new UserModel()
                {
                    Id = 2,
                    Name = "DUPONT",
                    Firstname = "Titi",
                    Mail = "titi.dupont@gmail.com"
                },
            };
        }
    }
}
