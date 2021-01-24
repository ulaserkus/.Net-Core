using System;
using Microsoft.AspNetCore.Mvc;
using App.webui.Models;
using System.Collections.Generic;

namespace App.webui.Controllers
{   //localhost:5000/home
    public class HomeController : Controller
    {
        //Index action
        public IActionResult Index()
        {
            var products = new List<Product>(){

              new Product {Name = "Iphone 8",Price=4000,Description="Güzel"},
              new Product {Name = "Iphone 6s",Price=2000,Description="Güzel",IsApproved=true},
              new Product {Name = "Iphone 7",Price=3000,Description="Güzel",IsApproved=true},
              new Product {Name = "Iphone X",Price=7000,Description="Güzel"}



           };
         
              //view models
            var productViewModel = new ProductViewModel(){
                Products = products
            };

            return View(productViewModel);
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {

            return View("MyView");
        }

    }
}