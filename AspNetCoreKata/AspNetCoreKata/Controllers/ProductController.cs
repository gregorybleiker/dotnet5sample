using AspNetCoreKata.ProductRepository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreKata.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _repo;
        
        public ProductController(IProductRepo repo) => _repo = repo;
        
        // GET: /Products
        public IActionResult Index() => View(_repo.GetAllProducts());

        // GET: /Products/Edit/{id}
        public ActionResult Edit(int id) => View(_repo.GetProductWithId(id));
    }
}