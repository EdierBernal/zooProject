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
    public ActionResult Uml()
    {
      //ViewBag.Message = "Diagramas de Usos UML";

      return View();
    }

    public ActionResult Arquitect()
    {
      ViewBag.Message = "Arquitectura Datacentric (Centrada en datos)";

      return View();
    }
    public ActionResult Metodology()
    {
      ViewBag.Message = "Scrum + Kanban";

      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Descripción del problema";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Datos del Estudiante";

      return View();
    }
  }
}