namespace OrderMVC.Web.Controllers;
public class SaleController : Controller
{
    private readonly ILogger<SaleController> _logger;

    public SaleController(ILogger<SaleController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(TestData.saleList);
    }

    [HttpGet]
    public IActionResult ViewOrder(int id)
    {
        return View(TestData.saleList.FirstOrDefault(x => x.Id == id));
    }
}