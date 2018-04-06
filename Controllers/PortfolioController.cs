using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {

	    [HttpGet]
        [Route("")]
        [Route("Home")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Projects")]
        public IActionResult Projects()
        {
            return View();
        }

        [HttpGet]
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("SubmitMessage")]
        public IActionResult SubmitMessage(string name, string surname, int phone, string message)
        {
            Console.WriteLine($"First Name: {name}");
            Console.WriteLine($"Last Name: {surname}");
            Console.WriteLine($"Phone Number: {phone}");
            Console.WriteLine($"Message: {message}");
            return Redirect("Index");
        }
    }
}