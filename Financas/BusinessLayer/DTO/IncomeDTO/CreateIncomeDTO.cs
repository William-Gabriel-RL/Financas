using BusinessLayer.DTO.BaseIncomeExpenseDTO;

namespace BusinessLayer.DTO.IncomeDTO
{
    public class CreateIncomeDTO : IncomeExpenseDTO
    {
        public bool Received { get; set; } = false;
    }
}
