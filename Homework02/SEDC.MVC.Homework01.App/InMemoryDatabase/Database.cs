using SEDC.MVC.Homework01.App.Models.Domain;
using SEDC.MVC.Homework01.App.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MVC.Homework01.App.InMemoryDatabase
{
    public static class Database
    {
        public static List<User> Users;
        public static List<Product> Products;

        static Database()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "Bob",
                    LastName = "Bobsky",
                    Address = "Bobsky street",
                    Phone = 078555333
                },
                new User()
                {
                    Id = 2,
                    Name = "Dante",
                    LastName = "Dantevski",
                    Address = "No name street",
                    Phone = 078223305
                }


            };

            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Superman",
                    Price = 2.55,
                    Description = "A Superman figurine, for kids above 4 years",
                    Category = Category.Toys

                },
                new Product()
                {
                    Id = 2,
                    Name = "Tootbrush",
                    Price = 15.00,
                    Description = "An electric toothbrush.",
                    Category = Category.Electronics
                },
                new Product()
                {
                    Id = 3,
                    Name = "The Secret",
                    Price = 8.99,
                    Description = "The Secret - Book from Rhonda Byrne",
                    Category = Category.Books
                },
                 new Product()
                {
                    Id = 4,
                    Name = "Tires",
                    Price = 25.00,
                    Description = "Four Car tires - 205/55/16(Used)",
                    Category = Category.Other
                },
                 new Product()
                {
                    Id = 5,
                    Name = "Honey",
                    Price = 12.5,
                    Description = "Natural Honey - From mountain Kozuf",
                    Category = Category.Foods
                },
            };
        }

    }
}
