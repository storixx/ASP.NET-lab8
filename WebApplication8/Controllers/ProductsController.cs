namespace WebApplication8.Controllers;

using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using System.Collections.Generic;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product { ID = 1, Name = "Product 1", Price = 111, CreatedDate = DateTime.Now },
            new Product { ID = 2, Name = "Product 2", Price = 222, CreatedDate = DateTime.Now },
        };

        return View(products);
    }
}
