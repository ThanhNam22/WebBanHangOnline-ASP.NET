using BanHangOnline.Models;
using BanHangOnline.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanHangOnline.Areas.Admin.Controllers
{
    public class NewsController : Controller
    {
        // GET: Admin/News
        private ApplicationDbContext db =new ApplicationDbContext();
        public ActionResult Index()
        {
            var items = db.News.OrderByDescending(x=>x.Id).ToList();
            return View(items);
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(News model)
        {
            if(ModelState.IsValid)
            {
                
                model.CreateDate= DateTime.Now;
                model.CategoryId = 7;
                model.ModifiedDate = DateTime.Now;
                model.Alias = BanHangOnline.Models.Common.Filter.FilterChar(model.Title);
                db.News.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}