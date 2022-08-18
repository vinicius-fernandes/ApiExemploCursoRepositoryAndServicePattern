using ApiExemplo.Models;
using ApiExemplo.Repositories;

namespace ApiExemplo.Services
{
    public class EmpresaService : IEmpresaService
    {

        private readonly IEmpresaRepository _empresaRepository;

        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _empresaRepository = empresaRepository;
        }

        public Empresa Create(Empresa empresa)
        {
            empresa.Nome = String.IsNullOrEmpty(empresa.Nome)?"Nome não identificado".ToUpper():empresa.Nome.ToUpper();

            return _empresaRepository.Create(empresa);
        }

    }
}
