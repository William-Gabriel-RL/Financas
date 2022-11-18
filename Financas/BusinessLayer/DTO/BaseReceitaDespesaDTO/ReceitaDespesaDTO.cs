namespace BusinessLayer.DTO.BaseReceitaDespesaDTO
{
    public class ReceitaDespesaDTO
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; } = 0M;
        public DateTime DataPagamento { get; set; }
        public string Categoria { get; set; }
        public string? Foto { get; set; }
        public int IdConta { get; set; }
    }
}
