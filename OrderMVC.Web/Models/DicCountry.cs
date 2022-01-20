namespace OrderMVC.Web.Models;
public class DicCountry
{
    [DisplayName("Symbol")]
    public string Id { get; set; }
    [DisplayName("Państwo")]
    public string Name { get; set; }
    [DisplayName("Czy Unia Europejska")]
    public bool UE { get; set; } = true;

    public IQueryable<Contractor> Customer { get; set; }
}