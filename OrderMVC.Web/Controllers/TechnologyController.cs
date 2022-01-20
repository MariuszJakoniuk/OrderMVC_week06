namespace OrderMVC.Web.Controllers;
public class TechnologyController : Controller
{
    private readonly ILogger<TechnologyController> _logger;

    public TechnologyController(ILogger<TechnologyController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }
}
