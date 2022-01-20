namespace OrderMVC.Web.Controllers;
public class SupplyController : Controller
{
    private readonly ILogger<SupplyController> _logger;

    public SupplyController(ILogger<SupplyController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
}
