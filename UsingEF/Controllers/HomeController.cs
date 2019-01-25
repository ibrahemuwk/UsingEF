using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsingEF.DAL;
using UsingEF.Models;

namespace UsingEF.Controllers
{
    public class HomeController : Controller
    {
        private UserContext _context;

        public HomeController()
        {
            _context=new UserContext();
        }
        // GET: Home
        public ActionResult Index()
        {
            //var users = new List<User>()
            //{
            //    new User()
            //    {
            //        Name = "k",
            //        Country = "H"
            //    },
            //    new User()
            //    {
            //        Name = "Q",
            //        Country = "W"
            //    }
            //};
            

            var users = _context.Users.ToList();

            var user =new ViewModel()
            {
                uers = users
            };
            return View(user);
        }

        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
;            return RedirectToAction("Index");
        }
    }
}