using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotSistemiMvc.Models.EntityFramework;

namespace OgrenciNotSistemiMvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
       
        public ActionResult Index()
        {
            
            
            
            return View();
        }
    }
}