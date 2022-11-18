using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class Conta : Identificador
    {
        public string Nome { get; set; }
        public string? Banco { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; } = 0M;
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
