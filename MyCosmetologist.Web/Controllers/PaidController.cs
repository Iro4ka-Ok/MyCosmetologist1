using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Web.Controllers
{
    public class PaidController : Controller
    {
        // GET: Paids
        public ActionResult Index()
        {
            return View();
        }
    }
}
