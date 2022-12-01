using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class Expense : IncomeExpenseBase
    {
        public bool Paid { get; set; } = false;
        public DateTime DueDate { get; set; }
        public int? IdCreditCard { get; set; }
        public virtual CreditCard? CreditCard { get; set; }
    }
}
