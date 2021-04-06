using Microsoft.AspNetCore.Mvc;
using nauseous.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace nauseous.Controllers
{
    public class CardsController : Controller
    {
        [Route("cards/{id}")]
        public IActionResult card1(int id)
        {

            switch (id)
            {
                case 1:
                    
                    ViewBag.Clothes = new Clothes { Id = 1, Name = "X-RAY", Price = 750, ImgPath = "/images/hood.jpg" };
                    break;

                case 2:
                    
                    ViewBag.Clothes = new Clothes { Id = 2, Name = "Ali", Price = 500, ImgPath = "/images/tshirt.jpg" };
                    break;

                case 3:
                    ViewBag.Clothes = new Clothes { Id = 3, Name = "Life is Nauseous", Price = 500, ImgPath = "/images/cap.jpg" }; 
                    break;


                default:
                    break;

            }
        

            return View();
        }



    }
}
