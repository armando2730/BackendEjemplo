using BackendEjemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackendEjemplo.Controllers
{
    public class calculosController : Controller
    {
        // GET: calculos
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Suma(string n1, string n2)
        {
            int res = 0;
            res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            ViewBag.res = res;
            
            return View();
        }
        public ActionResult Operacion()
        {
            operasbas op = new operasbas();
            return View(op);
        }
        [HttpPost]
        public ActionResult Operacion(operasbas op)
        {
            op.Suma();
            return View(op);
        }
        public ActionResult Resta(operasbas op)
        {
            op.Resta();
            return View(op);
        }
    }
}