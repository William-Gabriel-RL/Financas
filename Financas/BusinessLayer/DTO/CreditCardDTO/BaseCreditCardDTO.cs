namespace BusinessLayer.DTO.CreditCardDTO
{
    public class BaseCreditCardDTO
    {
        public string Flag { get; set; }
        public string Issuer { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Closure { get; set; }
        public decimal Limit { get; set; } = 0M;
        public int IdAccount { get; set; }
    }
}
