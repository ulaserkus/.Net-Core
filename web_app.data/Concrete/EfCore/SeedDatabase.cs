﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using web_app.entity;

namespace web_app.data.Concrete.EfCore
{
    public static class SeedDatabase
    {

        public static void Seed()
        {


            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count()==0)
            {

                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(categories);
                }


                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }

            }

            context.SaveChanges();
        }

        private static Category[] categories =
        {
            new Category{Name="Telefon",Url="telefon"},
            new Category{Name="Bilgisayar",Url="bilgisayar"},
            new Category{Name="Elektronik",Url ="elektronik"},
            




        };

        private static Product[] Products =
        {
          new Product{Name="Samsung S5",Price=3000,ImageUrl="1.png",IsApproved=true,Description="Eski telefon"},
          new Product{Name="Samsung S6",Price=4000,ImageUrl="1.png",IsApproved=true,Description="idare eder telefon"},
          new Product{Name="Samsung S7",Price=5000,ImageUrl="1.png",IsApproved=true,Description="iyi telefon"},
          new Product{Name="Samsung S8",Price=6000,ImageUrl="1.png",IsApproved=true,Description="güzel telefon"},
          new Product{Name="Samsung S9",Price=7000,ImageUrl="1.png",IsApproved=true,Description="çok iyi telefon"}


        };
      

    }
}
