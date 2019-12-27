using NetFrameWeb_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFrameWeb_App.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Ken", LastName = "Dulin", Age = 69 });
            people.Add(new PersonModel { FirstName = "Steve", LastName = "Henry", Age = 32 });
            people.Add(new PersonModel { FirstName = "Mary", LastName = "Steam", Age = 32 });

            return View(people);

        }
           
    }
}