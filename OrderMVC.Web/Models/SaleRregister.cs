namespace OrderMVC.Web.Models;
public class SaleRregister
{
    public string Id { get; set; }
    public string Name { get; set; }
    public bool Brutto { get; set; } = true;

    public IQueryable<Sale> Sale { get; set; }
}