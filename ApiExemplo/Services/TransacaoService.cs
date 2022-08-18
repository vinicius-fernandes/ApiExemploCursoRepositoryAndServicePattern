using ApiExemplo.Models;
using ApiExemplo.Repositories;

namespace ApiExemplo.Services
{
    public class TransacaoService : ITransacaoService
    {
        private readonly ITransacaoRepository _transacaoRepository;

        public TransacaoService(ITransacaoRepository transacaoRepository)
        {
            _transacaoRepository = transacaoRepository;
        }

        public Transacao Create(Transacao transacao)
        {
            if (transacao.Valor < 0)
            {
                transacao.Valor = transacao.Valor * -1;
            }

            return _transacaoRepository.Create(transacao);

        }

        public int Media(int idEmpresa)
        {
            var transacoes = _transacaoRepository.GetTransacoesEmpresa(idEmpresa);

            if (transacoes.Count() == 0)
            {
                return 0;
            }

            var soma = transacoes.Sum(c => c.Valor);

            return soma / transacoes.Count();
        }
    }
}
