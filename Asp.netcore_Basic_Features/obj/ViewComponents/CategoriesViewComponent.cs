using Microsoft.AspNetCore.Mvc;
using App.webui.Models;
using System.Collections.Generic;

namespace App.webui.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>(){
                new Category{Name="Telefonlar",Description="Telefon Kategorisi"},
                new Category{Name="Bilgisayar",Description="Telefon Kategorisi"},
                new Category{Name="Elektronik",Description="Telefon Kategorisi"}
            };

            return View(categories);
        }
    }
}