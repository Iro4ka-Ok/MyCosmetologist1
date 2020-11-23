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
       public ActionResult Index()
        {
            ViewBag.ProcedureCategoryId = new SelectList(db.ProcedureCategories, "Id", "Name");
            var procedures = db?.Procedures?.Include(a => a.ProcedureCategory).AsEnumerable().
                Select(s => new ProcedureViewModel(s)).ToList() ?? new List<ProcedureViewModel>();

            return View(procedures);
        }

        // GET: Procedure/Details
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }
            Procedure procedure = db.Procedures.Find(id);
            if(procedure == null)
            {
                return NotFound();
            }
            ProcedureViewModel viewModel = new ProcedureViewModel()
            {
                Id = procedure.Id,
                Name = procedure.Name,
                Preparat = procedure.Preparat,
                Price = procedure.Price,
                ProcedureCategoryId = procedure.ProcedureCategoryId
            };
            return View(viewModel);
        }

        // GET: Procedure/Create
        public ActionResult CreateProcedure()
        {
            ViewBag.ProcedureCategoryId = new SelectList(db.ProcedureCategories, "Id", "Name");
            ProcedureViewModel viewModel = new ProcedureViewModel();
            return View(viewModel);
        }
        // POST: Procedure/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProcedure([Bind("Id,Name,Preparat,Price,ProcedureCategoryId")] ProcedureViewModel procedureViewModel)
        {
            Procedure procedure = null;
            if (ModelState.IsValid)
            {
                procedure = new Procedure()
                {
                    Id = procedureViewModel.Id,
                    Name = procedureViewModel.Name,
                    Preparat = procedureViewModel.Preparat,
                    Price = procedureViewModel.Price,
                    ProcedureCategoryId = procedureViewModel.ProcedureCategoryId
                };

                db.Procedures.Add(procedure);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProcedureCategoryId = new SelectList(db.ProcedureCategories, "Id", "Name", procedure.ProcedureCategoryId);
            return View(procedureViewModel);
        }

    }
}