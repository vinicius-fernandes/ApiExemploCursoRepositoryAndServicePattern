using ApiExemplo.Models;

namespace ApiExemplo.Repositories
{
    public interface ITransacaoRepository
    {
       Transacao Create(Transacao transacao);

        List<Transacao> GetAll();

        List<Transacao> GetTransacoesEmpresa(int id);
    }
}
