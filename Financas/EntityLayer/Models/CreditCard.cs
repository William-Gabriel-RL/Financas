using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class CreditCard : Identifier
    {
        public string Flag { get; set; }
        public string Issuer { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Closure { get; set; }
        public decimal Total { get; set; } = 0M;
        public decimal Limit { get; set; } = 0M;
        public int IdAccount { get; set; }
        public virtual Account Account { get; set; }
    }
}
