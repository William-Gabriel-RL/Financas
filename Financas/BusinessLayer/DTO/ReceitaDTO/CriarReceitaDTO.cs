using BusinessLayer.DTO.BaseReceitaDespesaDTO;

namespace BusinessLayer.DTO.ReceitaDTO
{
    public class CriarReceitaDTO : ReceitaDespesaDTO
    {
        public bool Recebido { get; set; } = false;
    }
}
