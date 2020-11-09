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
    public class CategoryProcedyreController : Controller
    {
        private readonly DatabaseContext db;

        public CategoryProcedyreController(DatabaseContext context)
        {
            db = context;
        }

        // GET: category
        public IActionResult Index()
        {
            var categories = db?.CategoriesProcedure?.AsEnumerable().Select(s => new CategoryProcedyreViewModel(s)).ToList() ?? new List<CategoryProcedyreViewModel>();
            return View(categories);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }
            CategoryProcedyre category = db.CategoriesProcedure.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            CategoryProcedyreViewModel viewModel = new CategoryProcedyreViewModel()
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
            CategoryProcedyreViewModel viewModel = new CategoryProcedyreViewModel();
            return View(viewModel);
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCategoryProcedure([Bind("Id,Name,Description")] CategoryProcedyreViewModel categoryViewModel)
        {
            CategoryProcedyre category = null;
            if (ModelState.IsValid)
            {
                category = new CategoryProcedyre()
                {
                    Id = categoryViewModel.Id,
                    Name = categoryViewModel.Name,
                    Description = categoryViewModel.Description
                };

                db.CategoriesProcedure.Add(category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryViewModel);
        }
    }
}