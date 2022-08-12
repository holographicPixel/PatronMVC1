using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatronMVC1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index()
        {
            return "<html><body><h1>Prueba</h1></body></html>";
        }
    }
}