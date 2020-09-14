using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotSistemiMvc.Models.EntityFramework;

namespace OgrenciNotSistemiMvc.Controllers
{
    public class SinavNotlariController : Controller
    {
        // GET: SinavNotlari
        MvcOkulEntities1 db=new MvcOkulEntities1();
        public ActionResult Index()
        {
            var sinavnotlari = db.tblNotlar.ToList();
            return View(sinavnotlari);
        }
        [HttpGet]
        public ActionResult YeniSinavEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniSinavEkle(tblNotlar p)
        {
            db.tblNotlar.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}