using ApiExemplo.Models;

namespace ApiExemplo.Services
{
    public interface ITransacaoService
    {
        Transacao Create(Transacao transacao);

        int Media(int idEmpresa);
    }
}
