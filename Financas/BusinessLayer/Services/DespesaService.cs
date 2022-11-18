using BusinessLayer.DTO.DespesaDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Interfaces;
using RepoLayer.Repos;
using RepoLayer.Context;

namespace BusinessLayer.Services
{
    public class DespesaService : IDespesaService
    {
        private readonly IDespesaRepo _despesaRepo;
        public DespesaService()
        {
            _despesaRepo = new DespesaRepo(new FinancasContext());
        }
        public void AtualizarDespesa(AtualizarDespesaDTO despesa)
        {
            Despesa despesaAtualizada = new()
            {
                Id = despesa.Id,
                Descricao = despesa.Descricao,
                Valor = despesa.Valor,
                DataPagamento = despesa.DataPagamento,
                Categoria = despesa.Categoria,
                Foto = despesa.Foto,
                IdConta = despesa.IdConta,
                Pago = despesa.Pago,
                Vencimento = despesa.Vencimento,
                IdCartaoDeCredito = despesa.IdCartaoDeCredito,
            };
            _despesaRepo.AtualizarDespesa(despesaAtualizada);
        }

        public void CriarDespesa(CriarDespesaDTO despesa)
        {
            Despesa despesaCriada = new()
            {
                Descricao = despesa.Descricao,
                Valor = despesa.Valor,
                DataPagamento = despesa.DataPagamento,
                Categoria = despesa.Categoria,
                Foto = despesa.Foto,
                IdConta = despesa.IdConta,
                Pago = despesa.Pago,
                Vencimento = despesa.Vencimento,
                IdCartaoDeCredito = despesa.IdCartaoDeCredito,
            };
            _despesaRepo.CriarDespesa(despesaCriada);
        }

        public void DeletarDespesa(int id)
        {
            _despesaRepo.DeletarDespesa(id);
        }

        public Despesa? ObterDespesa(int id)
        {
            return _despesaRepo.ObterDespesa(id);
        }

        public IEnumerable<Despesa> ObterDespesaPorConta(int idConta)
        {
            return _despesaRepo.ObterDespesaPorConta(idConta);
        }
    }
}
