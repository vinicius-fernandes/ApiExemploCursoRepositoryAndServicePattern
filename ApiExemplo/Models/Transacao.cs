namespace ApiExemplo.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public int EmpresaId { get; set; }
        public Empresa? Empresa { get; set; }

    }
}
