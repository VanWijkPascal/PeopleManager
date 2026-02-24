using Microsoft.AspNetCore.Mvc;
using PeopleManager.Ui.Mvc.Views.People;

namespace PeopleManager.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        private IList<Person> GetPeople2() 
        {
            var person = new Person() { FirstName = "e", LastName = "a", Email= "sports@itsinthegame"};

            var people = new List<Person>() { };
            people.Add(person);
            return people;


        }

        //refines into this
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
