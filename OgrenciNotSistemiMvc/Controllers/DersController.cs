using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotSistemiMvc.Models.EntityFramework;

namespace OgrenciNotSistemiMvc.Controllers
{
    public class DersController : Controller
    {
        // GET: Ders
        
        MvcOkulEntities1 db=new MvcOkulEntities1();
        public ActionResult Index()
        {
            var ders = db.tblDersler.ToList();
            
            return View(ders);
        }

        [HttpGet]
        public ActionResult YeniDersEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniDersEkle(tblDersler p)
        {
            db.tblDersler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int Id)
        {
            var ders = db.tblDersler.Find(Id);
            db.tblDersler.Remove(ders);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DersGetir()
        {
            //var dersgetir = db.tblDersler.Find(Id);
            //return View("DersGetir",dersgetir);
            return View();
        }
    }
}