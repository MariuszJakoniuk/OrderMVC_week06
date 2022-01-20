namespace OrderMVC.Web.Models;
    public class SaleStatus : BaseEntity
    {
        public string Name { get; set; }
        public byte Sort { get; set; } = 99;
        public bool End { get; set; } = false;
        public bool Canceled { get; set; } = false;

        public IQueryable<Sale> Sale { get; set; }
    }