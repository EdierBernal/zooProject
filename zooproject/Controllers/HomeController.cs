using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace zooproject.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Descripción del proyecto";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Datos del Estudiante";

      return View();
    }
  }
}