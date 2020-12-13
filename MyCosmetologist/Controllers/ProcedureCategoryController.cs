using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Context;
using MyCosmetologist.Models;
using MyCosmetologist.ViewModel;

namespace MyCosmetologist.Controllers
{
    public class ProcedureCategoryController : Controller
    {
        private readonly DatabaseContext db;

        public ProcedureCategoryController(DatabaseContext context)
        {
            db = context;
        }

        // GET: category
        public IActionResult Index()
        {
            var categories = db?.ProcedureCategories?.AsEnumerable().Select(s => new ProcedureCategoryViewModel(s)).ToList() ?? new List<ProcedureCategoryViewModel>();
            return View(categories);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }
            ProcedureCategory category = db.ProcedureCategories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            ProcedureCategoryViewModel viewModel = new ProcedureCategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Procedures = category.Procedures
            };
            return View(viewModel);
        }


        // GET: Category/Create
        public ActionResult Create()
        {
            ProcedureCategoryViewModel viewModel = new ProcedureCategoryViewModel();
            return View(viewModel);
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProcedureCategoryViewModel categoryViewModel)
        {
            ProcedureCategory category = null;
            if (ModelState.IsValid)
            {
                category = new ProcedureCategory()
                {
                    Name = categoryViewModel.Name,
                    Description = categoryViewModel.Description
                };

                db.ProcedureCategories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryViewModel);
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProcedureCategory category = db.ProcedureCategories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            ProcedureCategoryViewModel viewModel = new ProcedureCategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description
            };

            return View(viewModel);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProcedureCategoryViewModel categoryViewModel)
        {
            ProcedureCategory category = null;
            if (ModelState.IsValid)
            {
                category = new ProcedureCategory()
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description
                };

                db.Entry(category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryViewModel);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProcedureCategory category = db.ProcedureCategories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProcedureCategory category = db.ProcedureCategories.Find(id);
            db.ProcedureCategories.Remove(category);
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
    }
}