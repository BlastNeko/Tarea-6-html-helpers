using Tarea6_html_helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace html_helper.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Persona obj = new Persona();
            obj.Cedula = Convert.ToInt32(Request.Form["Cedula"]);
            obj.Nombre = (Request.Form["Nombre"]).ToString();
            obj.Apellido = (Request.Form["Apellido"]).ToString();
            obj.Edad = Convert.ToInt32(Request.Form["Edad"]);
            obj.Telefono = Convert.ToInt32(Request.Form["Telefono"]);
            obj.Correo = (Request.Form["Correo"]).ToString();
            obj.Genero = (Request.Form["Genero"]).ToString();
            obj.EstadoCivil = (Request.Form["EstadoCivil"]).ToString();
            obj.Hobbys = (Request.Form["Hobbys"]).ToString();
            return View(obj);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}