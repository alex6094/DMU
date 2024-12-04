using Microsoft.AspNetCore.Mvc;
using TemplateMVC.Models;

namespace TemplateMVC.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;
        //
        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page1()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }

        [HttpGet]
        public ViewResult TemplateView()
        {
            return View();
        }

        [HttpPost]
        public ViewResult TemplateView(InputResponse inputResponse)
        {
            if(ModelState.IsValid)
            {
                Repository.AddResponse(inputResponse);
                return View("Thanks", inputResponse);  
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses);
        }
 
    }
}
