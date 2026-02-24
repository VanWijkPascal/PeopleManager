using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Models;
using PeopleManager.Ui.Mvc.Views.People;
using System.Diagnostics;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private IList<Person> GetPeople()
        {
            return new List<Person>
            {
                new () { FirstName = "e2", LastName ="a2", Email = "sports@itsinthegame2"},
                new () { FirstName = "E", LastName ="E", Email = ""}
            };


        }
    }
}
