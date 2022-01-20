namespace OrderMVC.Web.Models;
public class Contractor : BaseEntity
{
    [DisplayName("Symbol")]
    public string Symbol { get; set; }
    [DisplayName("Kontrahent")]
    public string? Name { get; set; }
    [DisplayName("Symbol Państwa")]
    public string? CountryID { get; set; }
    public DicCountry Country { get; set; }
    public string? NIP { get; set; }
    public string? Pesel { get; set; }
    [DisplayName("Miejscowość")]
    public string? City { get; set; }
    [DisplayName("Adres")]
    public string? Address { get; set; }
    [DisplayName("Kod pocztowy")]
    public string? ZipCode { get; set; }
    [DisplayName("Poczta")]
    public string? PostOffice { get; set; }

    public IQueryable<Sale> SaleOrders { get; set; }
}