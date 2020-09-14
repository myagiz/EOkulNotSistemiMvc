using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciNotSistemiMvc.Controllers
{
    public class HesapMakinesiController : Controller
    {
        // GET: HesapMakinesi
        public ActionResult Index(int sayi1=0, int sayi2=0, int sayi3=0)
        {
            int sonuc = sayi1 + sayi2 + sayi3;
            ViewBag.snc = sonuc;
            return View();
        }
    }
}