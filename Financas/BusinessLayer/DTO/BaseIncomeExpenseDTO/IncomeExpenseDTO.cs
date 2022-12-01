namespace BusinessLayer.DTO.BaseIncomeExpenseDTO
{
    public class IncomeExpenseDTO
    {
        public string Description { get; set; }
        public decimal Amount { get; set; } = 0M;
        public DateTime PayDay { get; set; }
        public string Category { get; set; }
        public string? Photo { get; set; }
        public int IdAccount { get; set; }
    }
}
