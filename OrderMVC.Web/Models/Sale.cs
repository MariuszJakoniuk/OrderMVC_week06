namespace OrderMVC.Web.Models;
public class Sale : BaseEntity
{
    [DisplayName("Rejestr")]
    public string RregisterId { get; set; }
    public SaleRregister Rregister { get; set; }
    [DisplayName("Rok")]
    public short Year { get; set; } = (short)DateTime.Now.Year;
    [DisplayName("Miesiąc")]
    public byte Month { get; set; } = (byte)DateTime.Now.Month;
    [DisplayName("Numer")]
    public int Number { get; set; }
    [DisplayName("Symbol pełny")]
    public string NumberFull { get; set; }
    [DisplayName("Symbol uproszczony")]
    public string NumberShort { get; set; }
    [DisplayName("Data rejestracji")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime SaleData { get; set; }
    [DisplayName("Nazwa")]
    public string Name { get; set; }
    [DisplayName("Klient")]
    public int ContractorId { get; set; }
    public Contractor Contractor { get; set; }
    [DisplayName("Data podpisania")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime DateSigning { get; set; }
    [DisplayName("Termin realizacji")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime? Deadline { get; set; }
    [DisplayName("Data zakończenia")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
    public DateTime? End { get; set; }
    [DisplayName("Status")]
    public int StatusID { get; set; }
    public SaleStatus Status { get; set; }
    public decimal Brutto { get; set; } = 0;
    public decimal Netto { get; set; } = 0;
    public decimal Vat { get; set; } = 0;
    [DisplayName("Opłacono")]
    public decimal Paid { get; set; } = 0;
    [DisplayName("Do zapłaty")]
    public decimal LeftToPay { get; set; } = 0;

}