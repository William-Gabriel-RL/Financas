using BusinessLayer.DTO.BaseIncomeExpenseDTO;

namespace BusinessLayer.DTO.ExpenseDTO
{
    public class CreateExpenseDTO : IncomeExpenseDTO
    {
        public bool Paid { get; set; } = false;
        public DateTime DueDate { get; set; }
        public int? IdCreditCard { get; set; }
    }
}
