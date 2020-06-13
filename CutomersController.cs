using SumerRaj.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SumerRaj.Controllers
{
    public class CutomersController : Controller
    {
        // GET: Cutomers
        public ActionResult Index()
        {
            var getcustomers = GetCustomers();
            return View(getcustomers);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{ Id=1,Name="Sumer"},
                new Customer{Id=2,Name="Nitin"},
                new Customer{Id=3,Name="Bhanu"},
                new Customer{Id=4,Name="Suraj"},
                new Customer{Id=5,Name="Aditya"}
           };
        }

        public ActionResult Details(int id)
        {
            var customers = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customers == null)
                return HttpNotFound();
            return View(customers);
        }
    }
}
