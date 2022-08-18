using ApiExemplo.Models;
using ApiExemplo.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;

        public EmpresasController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;

        }

        // POST api/<EmpresasController>
        [HttpPost]
        public Empresa Post([FromBody] Empresa value)
        {
            return _empresaService.Create(value);
        }



    }
}
