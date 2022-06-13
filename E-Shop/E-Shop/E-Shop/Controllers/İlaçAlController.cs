using DataAccessLayer.Context;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace E_Shop.Controllers
{
    public class İlaçAlController : Controller
    {
        DataContext db = new DataContext();
        // GET: İlaçAl
        public ActionResult Index(int sayfa = 1)
        {
            return View();
        }
    }
}