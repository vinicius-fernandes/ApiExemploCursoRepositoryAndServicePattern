using ApiExemplo.Models;

namespace ApiExemplo.Repositories
{
    public interface IEmpresaRepository
    {
        List<Empresa> GetAll();
        Empresa GetWithTransacoes(int id);
        Empresa Get(int id);
        Empresa Create(Empresa empresa);
        Empresa Update(Empresa empresa);
        void Delete(int id);


    }
}
