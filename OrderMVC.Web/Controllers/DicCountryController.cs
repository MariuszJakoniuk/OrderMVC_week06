using Microsoft.AspNetCore.Mvc;

namespace OrderMVC.Web.Controllers
{
    public class DicCountryController : Controller
    {
        private readonly ILogger<DicCountryController> _logger;

        public DicCountryController(ILogger<DicCountryController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(TestData.countryList);
        }
        public IActionResult EditItem(string Id)
        {
            return View(TestData.countryList.FirstOrDefault(x => x.Id == Id));
        }
    }
}
