using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
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
        public ActionResult Create()
        {
            ViewBag.ProcedureCategoryId = new SelectList(db.ProcedureCategories, "Id", "Name");
            ProcedureViewModel viewModel = new ProcedureViewModel();
            return View(viewModel);
        }
        // POST: Procedure/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProcedureViewModel procedureViewModel)
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
            ViewBag.ProcedureCategoryId = new SelectList(db.ProcedureCategories, "Id", "Name", procedureViewModel.ProcedureCategoryId);
            return View(procedureViewModel);
        }

        // GET: Procedures/Edit/5
        public ActionResult Edit(int? id)
        {
            Procedure procedure = null;
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }
            procedure = db.Procedures.Find(id);
            if (procedure == null)
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
            ViewBag.ProcedureCategoryId = new SelectList(db.ProcedureCategories, "Id", "Name", procedure.ProcedureCategoryId);
            return View(viewModel);
        }

        // POST: Animals/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProcedureViewModel procedureViewModel)
        {
            Procedure procedure = null;
            if (ModelState.IsValid)
            {
                procedure = new Procedure()
                {
                    Id = procedure.Id,
                    Name = procedure.Name,
                    Preparat = procedure.Preparat,
                    Price = procedure.Price,
                    ProcedureCategoryId = procedure.ProcedureCategoryId

                };
                db.Entry(procedure).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProcedureCategoryId = new SelectList(db.ProcedureCategories, "Id", "Name", procedure.ProcedureCategoryId);
            return View(procedureViewModel);
        }

        // GET: Procedures/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }
            Procedure procedure = db.Procedures.Find(id);
            if (procedure == null)
            {
                return NotFound();
            }
            return View(procedure);
        }

        // POST: Procedures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Procedure procedure = db.Procedures.Find(id);
            db.Procedures.Remove(procedure);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult GetItems(string search)
        {
            var model = new ProceduresViewModel();
            var query = (IQueryable<Procedure>)db?.Procedures;
            
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(g => g.Name.ToUpper().Contains(search.ToUpper()));
            }
            var procedures = query.Include(a => a.ProcedureCategory).ToList().
                Select(s => new ProcedureViewModel(s)).ToList() ?? new List<ProcedureViewModel>();
            
            model.Items = procedures;

            return PartialView("_Items", model);
        }
    }
}