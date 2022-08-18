using ApiExemplo.Data;
using ApiExemplo.Models;

namespace ApiExemplo.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {

        private readonly ApplicationDbContext _context;

        public EmpresaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Empresa Create(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();

            return empresa;

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Empresa Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Empresa> GetAll()
        {
            throw new NotImplementedException();
        }

        public Empresa GetWithTransacoes(int id)
        {
            throw new NotImplementedException();
        }

        public Empresa Update(Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
