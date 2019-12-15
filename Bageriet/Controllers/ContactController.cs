using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
{
    public class ContactController : Controller
    {
        // GET: /<controller>/
        public ViewResult Index()
        {
            //var _contact = new Contact("Bageriet", "+46 070 567 42", "bageriet@hotmail.nu", new Adress("Nöbbelövsvägen", 34, 29156, "Kristianstad", "www.bageriet.com"));
            ViewBag.Message = "Våra kontaktuppgifter:";
            ViewBag.AdressStreet = "Nöbbelövsvägen 34";
            ViewBag.AdressPostCodeTown = "29145 Kristianstad";
            ViewBag.Telephone = "+46 070 567 42";
            ViewBag.Email = "bageriet@hotmail.nu";

            return View();
        }
    }
}
