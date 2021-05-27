using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shopping.Models;
namespace Shopping.Controllers
{
    public class ProductsController : Controller
    {
        List<ProductModel> products = new List<ProductModel>()
        {
                           new ProductModel {Id = 1 , Title ="Algorithms Book",Price=150,Image ="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSQh8C2q-e64bw4UffkwWyRh_LtcsRhoISaTQ&usqp=CAU"},
                           new ProductModel{Id = 2 , Title ="Web Technologies Book",Price=180, Image ="https://khajuribazar.s3.amazonaws.com/__sized__/products/13-thumbnail-510x510-70.JPG"},
                           new ProductModel {Id = 3 , Title ="The Computer Science Book",Price=137,Image = "https://thecomputersciencebook.com/images/cover-new.jpg"},
                           new ProductModel {Id = 4 , Title ="Core Computer Science Book",Price=137,Image = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1487540839l/34341338._SX318_.jpg"}
        };
        public IActionResult Index()
        {
            ViewData["products"] = products;
            return View();
        }
        public IActionResult Details(int? id)
        {
            ProductModel product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return Content("Not found");
            }
            else
            {
                ViewData["products"] = product;
                return View();
            }
        }
    }
}
