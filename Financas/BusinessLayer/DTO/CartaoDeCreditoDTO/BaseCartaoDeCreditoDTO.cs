namespace BusinessLayer.DTO.CartaoDeCreditoDTO
{
    public class BaseCartaoDeCreditoDTO
    {
        public string Bandeira { get; set; }
        public string Emissor { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Fechamento { get; set; }
        public decimal Limite { get; set; } = 0M;
        public int IdConta { get; set; }
    }
}
