using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class CartaoDeCredito : Identificador
    {
        public string Bandeira { get; set; }
        public string Emissor { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Fechamento { get; set; }
        public decimal Total { get; set; } = 0M;
        public decimal Limite { get; set; } = 0M;
        public int IdConta { get; set; }
        public virtual Conta conta { get; set; }
    }
}
