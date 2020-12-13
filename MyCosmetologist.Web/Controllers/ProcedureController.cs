using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCosmetologist.Services.Services.Interfaces;
using MyCosmetologist.Web.Mappers;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Controllers
{
    public class ProcedureController : Controller
    {
        private readonly IProcedureService _procedureService;
        private readonly IProcedureCategoryService _procedureCategoryService;

        public ProcedureController(IProcedureService procedureService,
            IProcedureCategoryService procedureCategoryService)
        {
            _procedureService = procedureService;
            _procedureCategoryService = procedureCategoryService;
        }

       // GET: Procedures
       public ActionResult Index()
        {
            return View();
        }

        // GET: Procedure/Details
        public async Task<ActionResult> Details(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _procedureService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // GET: Procedure/Create
        public ActionResult Create()
        {
            var procedureCategories = _procedureCategoryService.GetItems();
            ViewBag.ProcedureCategoryId = new SelectList(procedureCategories, "Id", "Name");

            return View();
        }

        // POST: Procedure/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProcedureViewModel procedureViewModel)
        {
            if (ModelState.IsValid)
            {
                await _procedureService.Add(procedureViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            var procedureCategories = _procedureCategoryService.GetItems();
            ViewBag.ProcedureCategoryId = new SelectList(procedureCategories, "Id", "Name", procedureViewModel.ProcedureCategoryId);
            
            return View(procedureViewModel);
        }

        // GET: Procedures/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _procedureService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }
            
            var procedureCategories = _procedureCategoryService.GetItems();
            ViewBag.ProcedureCategoryId = new SelectList(procedureCategories, "Id", "Name", dto.ProcedureCategoryId);
            
            return View(dto.MapToViewModel());
        }

        // POST: Animals/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProcedureViewModel procedureViewModel)
        {
            if (ModelState.IsValid)
            {
                await _procedureService.Edit(procedureViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            var procedureCategories = _procedureCategoryService.GetItems();
            ViewBag.ProcedureCategoryId = new SelectList(procedureCategories, "Id", "Name", procedureViewModel.ProcedureCategoryId);
            
            return View(procedureViewModel);
        }

        // GET: Procedures/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (!id.HasValue)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return NotFound();
            }

            var dto = await _procedureService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // POST: Procedures/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            await _procedureService.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: Procedures/Delete/5
        //[HttpPost]
        //public async Task Delete(int id)
        //{
        //    await _procedureService.Delete(id);
        //}

        public ActionResult GetItems(string search)
        {
            var items = _procedureService.GetItems(search).Select(g => g.MapToViewModel()).ToList();
            var model = new ProceduresViewModel
            {
                Items = items
            };
            
            return PartialView("_Items", model);
        }
    }
}