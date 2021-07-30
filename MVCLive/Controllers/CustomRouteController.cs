using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLive.Controllers
{
    public class CustomRouteController : Controller
    {
        // GET: CustomRoute
        public string GetUserSecData(string Name)
        {
            return Name + "From Custom route";
        }
    }
}