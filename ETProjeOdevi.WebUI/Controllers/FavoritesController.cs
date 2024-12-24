using Et.Core.Entities;
using Et.Data;
using ETProjeOdevi.WebUI.ExtensionMethods;
using Microsoft.AspNetCore.Mvc;

namespace ETProjeOdevi.WebUI.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly DatabaseContext _context;

        public FavoritesController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var favoriler = GetFavorites();
            return View(favoriler);
        }

        private List<Product> GetFavorites()
        {
            return HttpContext.Session.GetJson<List<Product>>("GetFavorilerim") ?? [];
        }
        public IActionResult Add(int ProductId)
        {
            var favoriler = GetFavorites();
            var product = _context.Products.Find(ProductId);
            if (product != null && !favoriler.Any(p => p.Id == ProductId))
            {
               favoriler.Add(product);
                HttpContext.Session.Setjson("GetFavorites",favoriler);
            }
            return RedirectToAction("Index");
        } public IActionResult Remove(int ProductId)
        {
            var favoriler = GetFavorites();
            var product = _context.Products.Find(ProductId);
            if (product != null && favoriler.Any(p => p.Id == ProductId))
            {
               favoriler.RemoveAll(i =>i.Id == product.Id);
                HttpContext.Session.Setjson("GetFavorites",favoriler);
            }
            return RedirectToAction("Index");
        }
    }
}
