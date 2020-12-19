using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCosmetologist.Services.Services.Interfaces;
using MyCosmetologist.Web.Mappers;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: Clients
        public ActionResult Index()
        {
            
            return View();
        }

        // GET: Clients/Details
        public async Task<ActionResult> Details(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _clientService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                await _clientService.Add(clientViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            return View(clientViewModel);
        }

        // GET: Clients/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _clientService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        //// POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ClientViewModel clientViewModel)
        {
            if (ModelState.IsValid)
            {
                await _clientService.Edit(clientViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            return View(clientViewModel);
        }

        // GET: Clients/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _clientService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // POST: Clients/Delete/5

        [HttpDelete]
        //[ValidateAntiForgeryToken]
        public async Task Delete(int id)
        {
            await _clientService.Delete(id);
        }

        public ActionResult GetItems(string search)
        {
            var items = _clientService.GetItems(search).Select(g => g.MapToViewModel()).ToList();
            var model = new ClientsViewModel
            {
                Items = items
            };

            return PartialView("_Items", model);
        }
    }
}