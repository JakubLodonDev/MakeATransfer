using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationForTests.Models;

namespace WebApplicationForTests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [Authorize]
        public IActionResult MakeATransfer()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult MakeATransfer(MakeATransferModel model)
        {
            string message = "";
           
            if (ModelState.IsValid)
            {
                message = "Przelew o tytule " + model.Title + " kwota " + model.Amount + " do odbiorcy " + model.RecipientAccountNumber + " został wysłany";
            }
            else
            {
                message = "Nie udało się złożyć przelewu";
            }
            
            return Content(message);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}