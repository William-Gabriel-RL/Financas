using BusinessLayer.DTO.ReceitaDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Interfaces;
using RepoLayer.Repos;
using RepoLayer.Context;

namespace BusinessLayer.Services
{
    public class ReceitaService : IReceitaService
    {
        private readonly IReceitaRepo _receitaRepo;
        public ReceitaService()
        {
            _receitaRepo = new ReceitaRepo(new FinancasContext());
        }
        public void AtualizarReceita(AtualizarReceitaDTO receita)
        {
            Receita receitaAtualizada = new()
            {
                Id = receita.Id,
                Descricao = receita.Descricao,
                Valor = receita.Valor,
                DataPagamento = receita.DataPagamento,
                Categoria = receita.Categoria,
                Foto = receita.Foto,
                IdConta = receita.IdConta,
                Recebido = receita.Recebido,
            };
            _receitaRepo.AtualizarReceita(receitaAtualizada);
        }

        public void CriarReceita(CriarReceitaDTO receita)
        {
            Receita receitaCriada = new()
            {
                Descricao = receita.Descricao,
                Valor = receita.Valor,
                DataPagamento = receita.DataPagamento,
                Categoria = receita.Categoria,
                Foto = receita.Foto,
                IdConta = receita.IdConta,
                Recebido = receita.Recebido,
            };
            _receitaRepo.CriarReceita(receitaCriada);
        }

        public void DeletarReceita(int id)
        {
            _receitaRepo.DeletarReceita(id);
        }

        public Receita? ObterReceita(int id)
        {
            return _receitaRepo.ObterReceita(id);
        }

        public IEnumerable<Receita> ObterReceitaPorConta(int idConta)
        {
            return _receitaRepo.ObterReceitaPorConta(idConta);
        }
    }
}
