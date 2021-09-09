using Denis_Wilfredo_Lopez_Ortega.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Denis_Wilfredo_Lopez_Ortega.Controllers
{
    public class CajeroController : Controller
    {
        
        // GET: Cajero
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Permitido()
        {

            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Comprobacion(CajeroViewModel cajero)
        {
            if (cajero.Monto%5==0)
            {
                
                return RedirectToAction("Permitido");
            }
            else
            {
                return RedirectToAction("Error");
            }
            
        }
    }
}