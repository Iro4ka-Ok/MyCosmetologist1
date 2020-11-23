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

        /*private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }*/

        // GET: Category/Create
        public ActionResult CreateCategoryProcedure()
        {
            ProcedureCategoryViewModel viewModel = new ProcedureCategoryViewModel();
            return View(viewModel);
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCategoryProcedure([Bind("Id,Name,Description")] ProcedureCategoryViewModel categoryViewModel)
        {
            if (ModelState.IsValid)
            {
                ProcedureCategory category = new ProcedureCategory()
                {
                    Id = categoryViewModel.Id,
                    Name = categoryViewModel.Name,
                    Description = categoryViewModel.Description
                };

                db.ProcedureCategories.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryViewModel);
        }
    }
}