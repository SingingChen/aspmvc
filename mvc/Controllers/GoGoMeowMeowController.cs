using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class GoGoMeowMeowController : Controller
    {
        // GET: GoGoMeowMeow
        public ActionResult Index()
        {
            UserViewModel nV1 = new UserViewModel();
            nV1.Name = "Singing";
            nV1.Phone = "0932934738";
            nV1.Address = "no.55 xinde st ";
            nV1.IsShow = true;

            UserViewModel nV2 = new UserViewModel();
            nV2.Name = "Cleo";
            nV2.Phone = "0932934738";
            nV2.Address = "taiwan";
            nV2.IsShow = true;

            List<UserViewModel> nlist1 = new List<UserViewModel>();
            nlist1.Add(nV1);
            nlist1.Add(nV2);

            return View(nlist1);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Grooming()
        {
            return View();
        }
        public ActionResult Stay()
        {
            return View();
        }
        
    }
    public class UserViewModel
    {
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public bool IsShow { set; get; }

    }
}