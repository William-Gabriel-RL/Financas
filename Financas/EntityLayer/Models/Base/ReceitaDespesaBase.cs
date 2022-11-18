namespace EntityLayer.Models.Base
{
    public class ReceitaDespesaBase : Identificador
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; } = 0M;
        public DateTime DataPagamento { get; set; }
        public string Categoria { get; set; }
        public string? Foto { get; set; }
        public int IdConta { get; set; }
        public virtual Conta conta { get; set; }
    }
}
