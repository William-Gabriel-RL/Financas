using BusinessLayer.DTO.ContaDTO;
using BusinessLayer.Interfaces;
using EntityLayer.Models;
using RepoLayer.Context;
using RepoLayer.Interfaces;
using RepoLayer.Repos;

namespace BusinessLayer.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepo _contaRepo;
        public ContaService()
        {
            _contaRepo = new ContaRepo(new FinancasContext());
        }
        public void AtualizarConta(AtualizarContaDTO conta)
        {
            Conta contaModificada = new()
            {
                Id = conta.Id,
                Nome = conta.Nome,
                Banco = conta.Banco,
                Tipo = conta.Tipo,
                IdUsuario = conta.IdUsuario,
            };
            try
            {
                _contaRepo.AtualizarConta(contaModificada);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao atualizar conta");
            }
        }

        public void CriarConta(BaseContaDTO conta)
        {
            Conta novaConta = new()
            {
                Nome = conta.Nome,
                Banco = conta.Banco,
                Tipo = conta.Tipo,
                IdUsuario = conta.IdUsuario,
            };
            try
            {
                _contaRepo.CriarConta(novaConta);
            }
            catch (Exception)
            {
                throw new Exception("Erro ao criar conta");
            }
        }

        public void DeletarConta(int id)
        {
            _contaRepo.DeletarConta(id);
        }

        public Conta? ObterConta(int id)
        {
            if (id != 0)
            {
                return _contaRepo.ObterConta(id);
            }
            return null;
        }

        public IEnumerable<Conta> ObterContasPorUsuario(int idUsuario)
        {
            return _contaRepo.ObterContasPorUsuario(idUsuario);
        }
    }
}
