using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Services.Services.Interfaces;
using MyCosmetologist.Web.Mappers;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Controllers
{
    public class RecordController : Controller
    {
        private readonly IRecordService _recordService;
        private readonly IClientService _clientService;
        private readonly IProcedureService _procedureService;
        private readonly IProductService _productService;

        public RecordController(IRecordService recordService,
            IClientService clientService,
            IProcedureService procedureService,
            IProductService productService)
        {
            _recordService = recordService;
            _clientService = clientService;
            _procedureService = procedureService;
            _productService = productService;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Records/Details
        public async Task<ActionResult> Details(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _recordService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // GET: Records/Create
        public ActionResult Create()
        {
            var clients = _clientService.GetItems();
            ViewBag.ClientId = new SelectList(clients, "Id", "Name"); 

            var procedures = _procedureService.GetItems();
            ViewBag.ProcedureId = new SelectList(procedures, "Id", "Name");

            var products = _productService.GetItems();
            ViewBag.ProductId = new SelectList(products, "Id", "Name");

            return View();
        }

        // POST: Records/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RecordViewModel recordViewModel)
        {
            if (ModelState.IsValid)
            {
                await _recordService.Add(recordViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            var clients = _clientService.GetItems();
            ViewBag.ClientId = new SelectList(clients, "Id", "Name", recordViewModel.ClientId);

            var procedures = _procedureService.GetItems();
            ViewBag.ProcedureId = new SelectList(procedures, "Id", "Name", recordViewModel.ProcedureId);

            var products = _productService.GetItems();
            ViewBag.ProductId = new SelectList(products, "Id", "Name", recordViewModel.ProductId);

            return View(recordViewModel);
        }

        // GET: Records/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _recordService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            var clients = _clientService.GetItems();
            ViewBag.ClientId = new SelectList(clients, "Id", "Name", dto.ClientId);

            var procedures = _procedureService.GetItems();
            ViewBag.ProcedureId = new SelectList(procedures, "Id", "Name", dto.ProcedureId);

            var products = _procedureService.GetItems();
            ViewBag.ProductId = new SelectList(products, "Id", "Name", dto.ProductId);

            return View(dto.MapToViewModel());
        }

        // POST: Records/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(RecordViewModel recordViewModel)
        {
            if (ModelState.IsValid)
            {
                await _recordService.Edit(recordViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            var clients = _clientService.GetItems();
            ViewBag.ClientId = new SelectList(clients, "Id", "Name", recordViewModel.ClientId);

            var procedures = _procedureService.GetItems();
            ViewBag.ProcedureId = new SelectList(procedures, "Id", "Name", recordViewModel.ProcedureId);

            var products = _productService.GetItems();
            ViewBag.ProductId = new SelectList(products, "Id", "Name", recordViewModel.ProductId);

            return View(recordViewModel);
        }

        // GET: Records/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _recordService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // POST: Records/Delete/5
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            await _recordService.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult GetItems(int pageSize, int pageNumber, string search)
        {
            var dto = _recordService.GetItems(pageSize, pageNumber, search);

            return PartialView("_Items", dto.MapToViewModel()); 
        }
    }
}