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
            _context.Users.Add(new User() {Name = "Mostafa Hosny", Country = "Tunas"});
            _context.Users.Add(new User() { Name = "Ahmed Zaki", Country = "Menoufa" });
            _context.SaveChanges();
            var users = _context.Users.ToList();

            var user =new ViewModel()
            {
                uers = users
            };
            return View(user);
        }
    }
}