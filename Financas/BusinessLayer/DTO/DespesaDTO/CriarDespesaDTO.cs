using BusinessLayer.DTO.BaseReceitaDespesaDTO;

namespace BusinessLayer.DTO.DespesaDTO
{
    public class CriarDespesaDTO : ReceitaDespesaDTO
    {
        public bool Pago { get; set; } = false;
        public DateTime Vencimento { get; set; }
        public int? IdCartaoDeCredito { get; set; }
    }
}
