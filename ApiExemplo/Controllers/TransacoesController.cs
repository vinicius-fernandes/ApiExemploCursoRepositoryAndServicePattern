using ApiExemplo.Models;
using ApiExemplo.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransacoesController : ControllerBase
    {
        private readonly ITransacaoService _transacaoService;


        public TransacoesController(ITransacaoService transacaoService)
        {
            _transacaoService = transacaoService;
        }



        // POST api/<TransacoesController>
        [HttpPost]
        public Transacao Post([FromBody] Transacao value)
        {
            return _transacaoService.Create(value);
        }

        [HttpGet("media")]

        public int Media(int idEmpresa)
        {
            return _transacaoService.Media(idEmpresa);
        }


    }
}
