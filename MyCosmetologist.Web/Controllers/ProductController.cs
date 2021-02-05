using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCosmetologist.Services.Services.Interfaces;
using MyCosmetologist.Web.Mappers;
using MyCosmetologist.Web.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;

        public ProductController(IProductService productService, IProductCategoryService productCategoryService)
        {
            _productService = productService;
            _productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            return View();
        }

        // GET: Product/Details
        public async Task<ActionResult> Details(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound();
            }

            var dto = await _productService.Get(id.Value);
            if (dto == null)
            {
                return NotFound();
            }

            return View(dto.MapToViewModel());
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                await _productService.Add(productViewModel.MapToDto());
                return RedirectToAction("Index");
            }

            var productCategories = _productCategoryService.GetItems();
            ViewBag.ProcedureCategoryId = new SelectList(productCategories, "Id", "Name", productViewModel.ProductCategoryId);

            return View(productViewModel);
        }

        public ActionResult GetItems(string search)
        {
            var items = _productService.GetItems(search).Select(g => g.MapToViewModel()).ToList();
            var model = new ProductsViewModel
            {
                Items = items
            };

            return PartialView("_Items", model);
        }
    }
}