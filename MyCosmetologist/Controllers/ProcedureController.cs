using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Context;
using MyCosmetologist.Models;
using MyCosmetologist.ViewModel;

namespace MyCosmetologist.Controllers
{
    public class ProcedureController : Controller
    {
        private DatabaseContext db;

        public ProcedureController(DatabaseContext context)
        {
            db = context;
        }
        // GET: Procedures
       public IActionResult Index()
        {
            ViewBag.CategoryProcedyreId = new SelectList(db.CategoriesProcedure, "Id", "Name");
            var procedures = db?.Procedures?.
                Include(a => a.CategoryProcedyre_).AsEnumerable().
                Select(s => new ProcedureViewModel(s)).ToList() ?? new List<ProcedureViewModel>();

            return View(procedures);
        }
        /*public async Task<IActionResult> Index()
        {
            return View(await db.Procedures.ToListAsync());
        }*/

        // GET: Procedure/Create
        public ActionResult CreateProcedure()
        {
            ViewBag.CategoryProcedyreId = new SelectList(db.CategoriesProcedure, "Id", "Name");
            ProcedureViewModel viewModel = new ProcedureViewModel();
            return View(viewModel);
        }
        // POST: Procedure/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProcedure([Bind("Id,NameProcedure,Preparation,Price,CategoryProcedyreId")] ProcedureViewModel procedureViewModel)
        {
            Procedure procedure = null;
            if (ModelState.IsValid)
            {
                procedure = new Procedure()
                {
                    Id = procedureViewModel.Id,
                    NameProcedure = procedureViewModel.NameProcedure,
                    Preparation = procedureViewModel.Preparation,
                    Price = procedureViewModel.Price,
                    CategoryProcedyreId = procedureViewModel.CategoryProcedyreId
                };

                db.Procedures.Add(procedure);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryProcedyreId = new SelectList(db.CategoriesProcedure, "Id", "Name");
            return View(procedureViewModel);
        }

    }
}