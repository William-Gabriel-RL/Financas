using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class Income : IncomeExpenseBase
    {
        public bool Received { get; set; } = false;
    }
}
