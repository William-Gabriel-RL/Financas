using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class Despesa : ReceitaDespesaBase
    {
        public bool Pago { get; set; } = false;
        public DateTime Vencimento { get; set; }
        public int? IdCartaoDeCredito { get; set; }
    }
}
