using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sirket.Controllers
{
    public class SirketHomeController : Controller
    {
        // GET: SirketHome
        SirketEntities db = new SirketEntities();
        
        public ActionResult Index()
        {
            List<Personel> personelList = db.Personels.ToList();
            return View(personelList);
        }
    }
}