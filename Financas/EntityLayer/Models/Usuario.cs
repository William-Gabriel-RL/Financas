using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class Usuario : Identificador
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
