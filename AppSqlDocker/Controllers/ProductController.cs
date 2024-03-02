using Microsoft.AspNetCore.Mvc;
using Contract.Dto;
using Bussiness.ProductManager;

namespace AppSqlDocker.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager _productManager;

        public ProductController(IProductManager productManager)
        {
			_productManager = productManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product(int? id)
        {
            var model = id.HasValue ? _productManager.GetById(id.Value) : null;
            return View(model);
        }

        public IActionResult CreateProduct(ProductDto product)
        {
            if (product.id == 0)
				_productManager.Add(product);
            else
				_productManager.Update(product);

            return RedirectToAction("ProductList");
        }

		public IActionResult DeleteProduct(int id)
		{
			_productManager.Delete(id);
			return RedirectToAction("ProductList");
		}

		public ActionResult ProductList(string condition)
        {
			var productList = _productManager.GetAll().Where(o => string.IsNullOrEmpty(condition) || o.name.Contains(condition)).ToList();
			return View(productList);
        }
    }
}