using MVCDemo.Models;
using MVCDemo2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            // End user should only see HTML / CSS / JAVASCRIPT 
            // Can be handle by adding     <customErrors mode="On"> </customErrors> to the Web.config file betwen the <system.web> tag
            // This will display a friendly web pad
            // On or RemoteOnly
            return View();
        }


        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
 

            people.Add(new PersonModel { FirstName = "Riley", LastName = "Baptiste", Age = 40 });
            people.Add(new PersonModel { FirstName = "Joe", LastName = "Smith", Age = 56 });
            people.Add(new PersonModel { FirstName = "Sara", LastName = "Conner", Age = 25 });
            people.Add(new PersonModel { FirstName = "John", LastName = "Wall", Age = 15 });
 

            return View(people);
        }
    }
}