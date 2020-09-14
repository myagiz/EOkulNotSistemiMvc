using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotSistemiMvc.Models.EntityFramework;


namespace OgrenciNotSistemiMvc.Controllers
{
    public class OgrenciListesiController : Controller
    {
        // GET: OgrenciListesi
        
        MvcOkulEntities1 db=new MvcOkulEntities1();
        public ActionResult Index()
        {
            var ogrencilistesi = db.tblOgrenciler.ToList();
            return View(ogrencilistesi);
        }

        [HttpGet]
        public ActionResult YeniOgrenciEkle()
        {
            //List<SelectListItem> degerler = (from i in db.tblKulupler.ToList()
            //    select new SelectListItem
            //    {
            //        Text = i.KulupAd,
            //        Value = i.KulupId.ToString()
            //    }).ToList();
            //ViewBag.dgr = degerler;
                    
            return View();
        }

        [HttpPost]
        public ActionResult YeniOgrenciEkle(tblOgrenciler p)
        {
            //var klp = db.tblKulupler.Where(m => m.KulupId == p.tblKulupler.KulupId).FirstOrDefault(); //Dropdown
            //p.tblKulupler = klp;
            db.tblOgrenciler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult Sil(int Id)
        {
            var ogrencilistesi = db.tblOgrenciler.Find(Id);
            db.tblOgrenciler.Remove(ogrencilistesi);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult OgrenciListesiGetir(int Id)
        {
            var ogrencigetir = db.tblOgrenciler.Find(Id);
            return View("OgrenciListesiGetir", ogrencigetir);
        }

        public ActionResult OgrenciGetir(int Id)
        {
            var ogrenci = db.tblOgrenciler.Find(Id);
            return View();
        }
    }
}