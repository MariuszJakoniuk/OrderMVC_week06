namespace OrderMVC.Web.Controllers;
public class ContractorController : Controller
{
    private readonly ILogger<ContractorController> _logger;

    public ContractorController(ILogger<ContractorController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        return View(TestData.contractorList);
    }

    public IActionResult DetailsContractor(int id)
    {
        return View(TestData.contractorList.FirstOrDefault(s => s.Id == id));
    }
}