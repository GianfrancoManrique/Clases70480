using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejemplo01.Models;//Referencia a EDM

namespace Ejemplo01.Controllers
{
    public class UbigeoController : Controller
    {
        // GET: Ubigeo
        public ActionResult Listado()
        {
            using (var context = new EjemplosEntidades())//Contexto que usaremos
            {
                ViewBag.departamentos = context.Departamento.ToList();//Traigo todos los departamentos
                ViewBag.provincias = context.Provincia.ToList();//Traigo todos las provincias
                ViewBag.distritos = context.Distrito.ToList();//Traigo  todos los distritos
                List<Ubigeo> ubigeos = context.Ubigeo.ToList();//Traigo todos los ubigeos

                return View(ubigeos);
            }
        }

        //Enviar un json como resultado
        public JsonResult ConsultarProvsPorDpto(string dpto)
        {
            IEnumerable<Provincia> data = ObtenerProvsPorDpto(dpto);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private IEnumerable<Provincia> ObtenerProvsPorDpto(string dpto)
        {
            using (var context = new EjemplosEntidades())
            {
                IEnumerable<Provincia> data = context.Provincia.ToList();

                if (dpto != "00")
                {
                    data = (from prov in context.Provincia
                            join ubigeo in context.Ubigeo on prov.idprovincia equals ubigeo.idprovincia
                            where ubigeo.iddepartamento == dpto
                            select prov).Distinct().ToList();
                }
                return data;
            }
        }

        public JsonResult ConsultarDstosPorProv(string prov)
        {
            IEnumerable<Distrito> data = ObtenerDstosPorProv(prov);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private IEnumerable<Distrito> ObtenerDstosPorProv(string prov)
        {
            using (var context = new EjemplosEntidades())
            {
                IEnumerable<Distrito> data = context.Distrito.ToList();

                if (prov != "")
                {
                    data = (from dist in context.Distrito
                            join ubigeo in context.Ubigeo on dist.iddistrito equals ubigeo.iddistrito
                            where ubigeo.idprovincia == prov
                            select dist).Distinct().ToList();
                }
                return data;
            }
        }

        public JsonResult ConsultarIdPorDistrito()
        {
            string _dsto = Request.Form["dsto"];//Consultar dsto en POST
            Distrito data = ObtenerIdPorDistrito(_dsto);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private Distrito ObtenerIdPorDistrito(string dsto)
        {
            using (var context = new EjemplosEntidades())
            {
                Distrito data = null;

                if (dsto != "00")
                {
                    //Primer resultado
                    data = context.Distrito.First(d => d.iddistrito == dsto);//Where d.iddistrito == dsto

                }
                return data;
            }
        }
    }
}