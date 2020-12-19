using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCosmetologist.Services.Services.Interfaces;
using MyCosmetologist.Web.Mappers;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Controllers
{
    public class ProcedureCategoryController : Controller
    {
        private readonly IProcedureCategoryService _procedureCategoryService;

        public ProcedureCategoryController(IProcedureCategoryService procedureCategoryService)
        {
            _procedureCategoryService = procedureCategoryService;
        }

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        // GET: Category/Details
        public async Task<ActionResult> Details(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _procedureCategoryService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProcedureCategoryViewModel procedureCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                await _procedureCategoryService.Add(procedureCategoryViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            return View(procedureCategoryViewModel);
        }

        // GET: Categories/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _procedureCategoryService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProcedureCategoryViewModel procedureCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                await _procedureCategoryService.Edit(procedureCategoryViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            return View(procedureCategoryViewModel);
        }

        // GET: Categories/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _procedureCategoryService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // Delete: Categories/Delete/5
        [HttpDelete]
        //[ValidateAntiForgeryToken]
        public async Task Delete(int id)
        {
            await _procedureCategoryService.Delete(id);
        }

        public ActionResult GetItems(string search)
        {
            var items = _procedureCategoryService.GetItems(search).Select(g => g.MapToViewModel()).ToList();
            var model = new ProcedureCategoriesViewModel
            {
                Items = items
            };

            return PartialView("_Items", model);
        }
    }
}