using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class Receita : ReceitaDespesaBase
    {
        public bool Recebido { get; set; } = false;
    }
}
