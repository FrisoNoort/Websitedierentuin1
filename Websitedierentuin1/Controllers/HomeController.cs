using Microsoft.AspNetCore.Mvc;
using Websitedierentuin1.Database;
using System.Diagnostics;
using Websitedierentuin1.Models;
using MySql.Data;

namespace Websitedierentuin1.Controllers
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
            // alle producten ophalen
            var rows = DatabaseConnector.GetRows("select * from dier");

            // lijst maken om alle namen in te stoppen
            List<string> names = new List<string>();

            foreach (var row in rows)
            {
                // elke naam toevoegen aan de lijst met namen
                names.Add(row["naam"].ToString());
            }

            // de lijst met namen in de html stoppen
            return View(names);
        }

        [Route("Kaartjes")]
        public IActionResult Kaartjes()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        [Route("Contact")]
        public IActionResult Contact(Person person)
        {
            // check of alles goed is ingevuld.
            if (ModelState.IsValid)
                return Redirect("/succes");
            
            //niet goed, dan worden de gegevens doorgestuurd naar die view zodat we de fouten kunnen tonen
            return View(person);
        }

        [Route("Dieren")]
        public IActionResult Dieren()
        {
            return View();
        }

        [Route("Gorilla")]
        public IActionResult Gorilla()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}