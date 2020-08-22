using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
     
            return View(db.tbl_news.ToList());
        }


        //الجزء الخاص بعرض التفاصيل
        public ActionResult Details(int newsid)
        {
            var news = db.tbl_news.Find(newsid);

            if (news == null)
            {
                return HttpNotFound();
            }

            return View(news);
        }

        //الجزء الخاص بعرض التفاصيل

        public ActionResult About()
        {
            ViewBag.Message = "هي احدى تشكيلات وكالة الوزارة للشؤون الادارية والمالية.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}