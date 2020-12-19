using Microsoft.AspNetCore.Mvc;
using MyCosmetologist.Services.Services.Interfaces;
using MyCosmetologist.Web.Mappers;
using MyCosmetologist.Web.ViewModel;
using System.Linq;

namespace MyCosmetologist.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        //private readonly IProductCategoryService _productCategoryService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
            //_productCategoryService = productCategoryService;
        }
        public IActionResult Index()
        {
            return View();
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