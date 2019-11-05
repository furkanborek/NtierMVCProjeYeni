using Project.Bll.DesignPatterns.SinglettonPattern;
using Project.Dal.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class HomeController : Controller
    {
        MyContext db;
        public HomeController()
        {
            db = DBTool.DBInstance;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}