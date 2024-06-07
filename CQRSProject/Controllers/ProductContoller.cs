using CQRSProject.CQRS.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    public class ProductContoller : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;

        public ProductContoller(GetProductQueryHandler getProductQueryHandler)
        {
            _getProductQueryHandler = getProductQueryHandler;
        }

        public IActionResult ProductList()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
    }
}
