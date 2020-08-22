using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication_trining.Models;
using System.IO;

namespace WebApplication_trining.Controllers
{
    [Authorize(Users = "بلال الحلفي")]
    public class tbl_newsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: tbl_news
        public ActionResult Index()
        {
            return View(db.tbl_news.ToList());
        }

        // GET: tbl_news/Details/5 
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_news tbl_news = db.tbl_news.Find(id);
            if (tbl_news == null)
            {
                return HttpNotFound();
            }
            return View(tbl_news);
        }

        // GET: tbl_news/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_news/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tbl_news tbl_news,HttpPostedFileBase upload1, HttpPostedFileBase upload2, HttpPostedFileBase upload3, HttpPostedFileBase upload4)
        {   
            if (ModelState.IsValid)
            {

            
                //الصورة الاولى
                string path1 = Path.Combine(Server.MapPath("~/Uploads"), upload1.FileName);
                upload1.SaveAs(path1);
                tbl_news.news_img1 = upload1.FileName;
                //الصورة الثانية

                string path2 = Path.Combine(Server.MapPath("~/Uploads"), upload2.FileName);
                upload2.SaveAs(path2);
                tbl_news.news_img2 = upload2.FileName;


                //الصورة الثالثة

                string path3 = Path.Combine(Server.MapPath("~/Uploads"), upload3.FileName);
                upload3.SaveAs(path3);
                tbl_news.news_img3 = upload3.FileName;

                //الصورة الرابعة

                string path4 = Path.Combine(Server.MapPath("~/Uploads"), upload4.FileName);
                upload4.SaveAs(path4);
                tbl_news.news_img4 = upload4.FileName;

                db.tbl_news.Add(tbl_news);


                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_news);
        }

        // GET: tbl_news/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_news tbl_news = db.tbl_news.Find(id);
            if (tbl_news == null)
            {
                return HttpNotFound();
            }
            return View(tbl_news);
        }

        // POST: tbl_news/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(tbl_news tbl_news, HttpPostedFileBase upload1, HttpPostedFileBase upload2, HttpPostedFileBase upload3, HttpPostedFileBase upload4)
        {
            if (ModelState.IsValid)
            {

                //الصورة الاولى
                string path1 = Path.Combine(Server.MapPath("~/Uploads"), upload1.FileName);
                upload1.SaveAs(path1);
                tbl_news.news_img1 = upload1.FileName;
                //الصورة الثانية

                string path2 = Path.Combine(Server.MapPath("~/Uploads"), upload2.FileName);
                upload2.SaveAs(path2);
                tbl_news.news_img2 = upload2.FileName;


                //الصورة الثالثة

                string path3 = Path.Combine(Server.MapPath("~/Uploads"), upload3.FileName);
                upload3.SaveAs(path3);
                tbl_news.news_img3 = upload3.FileName;

                //الصورة الرابعة

                string path4 = Path.Combine(Server.MapPath("~/Uploads"), upload4.FileName);
                upload4.SaveAs(path4);
                tbl_news.news_img4 = upload4.FileName;

                db.Entry(tbl_news).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_news);
        }

        // GET: tbl_news/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_news tbl_news = db.tbl_news.Find(id);
            if (tbl_news == null)
            {
                return HttpNotFound();
            }
            return View(tbl_news);
        }

        // POST: tbl_news/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_news tbl_news = db.tbl_news.Find(id);
            db.tbl_news.Remove(tbl_news);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
