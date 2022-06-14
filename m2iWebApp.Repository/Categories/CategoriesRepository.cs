using m2iWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace m2iWebApp.Repository.Categories
{
    public class CategoriesRepository
    {
        public static List<CategoryModel> getAllCategories()
        {
            return new List<CategoryModel>()
            {
                 new CategoryModel()
                {
                    Id = 1,
                    Name = "catégorie 1",
                    Color ="red"
                    
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "catégorie 2",
                    Color = "blue"
                    
                },
                 new CategoryModel()
                {
                    Id = 3,
                    Name = "catégorie 3",
                    Color = "noir"

                },
            };

        }
    }
}
