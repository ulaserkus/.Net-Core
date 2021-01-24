using Microsoft.AspNetCore.Mvc;
using App.webui.Models;
using System.Collections.Generic;

namespace App.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            //Model

            var product = new Product();
            product.Name = "Iphone X";
            product.Price = 10000;
            product.Description = "çok iyi telefon";

            //ViewData
            /*ViewData["Product"]=product;
            ViewData["Category"]="Telefonlar";*/

            //ViewBag
            ViewBag.Category = "Telefonlar";
            //ViewBag.Product = product;

            return View(product);
        }
        public IActionResult List()
        {
            var products = new List<Product>(){

              new Product {Name = "Iphone 8",Price=4000,Description="Güzel"},
              new Product {Name = "Iphone 6s",Price=2000,Description="Güzel",IsApproved=true},
              new Product {Name = "Iphone 7",Price=3000,Description="Güzel",IsApproved=true},
              new Product {Name = "Iphone X",Price=7000,Description="Güzel"}



           };
     
           
              //view models
            var productViewModel = new ProductViewModel(){
                Products = products,
                
            };

            return View(productViewModel);
        }
        //localhost:5000/product/details/3
        public IActionResult Details(int id)
        {

            // name : "Samsung s6"
            //price : 3000
            // description : "iyi telefon"
            var p = new Product();
            p.Name = "Samsung s10";
            p.Price = 7000;
            p.Description = "iyi telefon";


            return View(p);
        }


    }
}