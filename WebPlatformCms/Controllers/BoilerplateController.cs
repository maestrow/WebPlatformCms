using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebPlatformCms.Controllers
{
    [RoutePrefix("Boilerplate")]
    public class BoilerplateController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [Route("{viewName}")]
        public ActionResult Show(string viewName)
        {
            return View(viewName);
        }
    }
}