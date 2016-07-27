using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Ejemplo01
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              name: "UbigeoInicio",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Ubigeo", action = "Listado", id = UrlParameter.Optional }
          );

            //Ruta con 3 parametros
            routes.MapRoute(
               name: "ConsultarProvsPorDptoAjax",
               url: "{controller}/{action}/{dpto}",
               defaults: new { controller = "Ubigeo", action = "ConsultarProvsPorDpto", dpto = "" }
            );

            routes.MapRoute(
             name: "ConsultarDstosPorProvAjax",
             url: "{controller}/{action}/{dpto}",
             defaults: new { controller = "Ubigeo", action = "ConsultarDstosPorProv", prov = "" }
            );

            routes.MapRoute(
             name: "ConsultarIdPorDistritoAjax",
             url: "{controller}/{action}",
             defaults: new { controller = "Ubigeo", action = "ConsultarIdPorDistrito" }
            );


        }
    }
}
