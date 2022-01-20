namespace OrderMVC.Web;
public static class TestData
{
    public static List<Contractor> contractorList;
    public static List<DicCountry> countryList;
    public static List<Sale> saleList;
    public static List<SaleRregister> saleRregisterList;
    public static List<SaleStatus> saleStatusList;


    public static void Init()
    {
        contractorList = new List<Contractor>();
        contractorList.Add(new Contractor() { Id = 1, Symbol = "Kowalski Jan", Name = "Meble od Kowalskiego Sp. z o.o.", CountryID = "PL", City = "Warszawa", Address = "ul. Przekręt 15" });
        contractorList.Add(new Contractor() { Id = 2, Symbol = "Nowak Jolanta", Name = "Nowak Jolanta", CountryID = "PL", City = "Białystok", Address = "ul. Bajkowa 3" });

        countryList = new List<DicCountry>();
        countryList.Add(new DicCountry() { Id = "PL", Name = "Polska", UE = true });
        countryList.Add(new DicCountry() { Id = "DE", Name = "Niemcy", UE = true });
        countryList.Add(new DicCountry() { Id = "UA", Name = "Ukraina", UE = false });
        countryList.Add(new DicCountry() { Id = "RU", Name = "Rosja", UE = false });

        saleRregisterList = new List<SaleRregister>();
        saleRregisterList.Add(new SaleRregister() { Id = "I", Name = "Indywidualny" });
        saleRregisterList.Add(new SaleRregister() { Id = "H", Name = "Hurtowy", Brutto = false });

        saleStatusList = new List<SaleStatus>();
        saleStatusList.Add(new SaleStatus() { Id = 1, Name = "Nowe", Sort = 10 });
        saleStatusList.Add(new SaleStatus() { Id = 2, Name = "W realizacji", Sort = 20 });
        saleStatusList.Add(new SaleStatus() { Id = 3, Name = "Dostawa/Montaż", Sort = 30 });
        saleStatusList.Add(new SaleStatus() { Id = 4, Name = "Zrealizowane", Sort = 90, End = true });
        saleStatusList.Add(new SaleStatus() { Id = 5, Name = "Anulowane", Sort = 95, End = true, Canceled = true });

        saleList = new List<Sale>();
        saleList.Add(new Sale()
        {
            Id = 1,
            RregisterId = "I",
            Year = (short)DateTime.Now.Year,
            Month = (byte)DateTime.Now.Month,
            Number = 1,
            NumberFull = "ZO/" + "I  /" + DateTime.Now.Year.ToString("0000") + "/" + DateTime.Now.Month.ToString("00") + "/" + (1).ToString("0000"),
            NumberShrot = "I/" + DateTime.Now.ToString("yy") + "/" + 1,
            SaleData = DateTime.Now,
            Name = "Kuchnia Pani Joli",
            ContractorId = 2,
            DateSigning = DateTime.Now.AddDays(-1),
            Deadline = DateTime.Now.AddDays(7 * 8),
            StatusID = 1,
        });
        saleList.Add(new Sale()
        {
            Id = 2,
            RregisterId = "H",
            Year = (short)DateTime.Now.Year,
            Month = (byte)DateTime.Now.Month,
            Number = 1,
            NumberFull = "ZO/" + "H  /" + DateTime.Now.Year.ToString("0000") + "/" + DateTime.Now.Month.ToString("00") + "/" + (1).ToString("0000"),
            NumberShrot = "H/" + DateTime.Now.ToString("yy") + "/" + 1,
            SaleData = DateTime.Now,
            Name = "68/25 sypialnia nowak",
            ContractorId = 1,
            DateSigning = DateTime.Now.AddDays(-1),
            Deadline = DateTime.Now.AddDays(7 * 6),
            StatusID = 1,
        });


    }
}