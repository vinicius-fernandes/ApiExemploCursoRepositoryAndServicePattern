using ApiExemplo.Data;
using ApiExemplo.Models;

namespace ApiExemplo.Repositories
{
    public class TransacaoRepository : ITransacaoRepository
    {

        private readonly ApplicationDbContext _context;

        public TransacaoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Transacao Create(Transacao transacao)
        {

            //var empresa = _context.Empresas.Find(transacao.EmpresaId);
            //transacao.Empresa = empresa;
            _context.Transacoes.Add(transacao);
            _context.SaveChanges();

            return transacao;
        }

        public List<Transacao> GetAll()
        {
            return _context.Transacoes.ToList();
        }

        public List<Transacao> GetTransacoesEmpresa(int id)
        {
            return _context.Transacoes.Where(c => c.EmpresaId == id).ToList();
        }
    }
}
