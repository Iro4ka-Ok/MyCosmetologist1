using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCosmetologist.Models;

namespace MyCosmetologist.Controllers
{
    public class ProcedureController : Controller
    {
        private ProcedureContext db;

        public ProcedureController(ProcedureContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Procedures.ToList());
        }
        [HttpGet]
        public IActionResult Payment(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.ProcedureId = id;
            return View();
        }
        [HttpPost]
        public string Payment(Order order)
        {
            db.Orders.Add(order);
            // зберігаємо в базі всі зміни
            db.SaveChanges();
            return "Дякуємо, " + order.User + ", за візит!";
        }
    }
}