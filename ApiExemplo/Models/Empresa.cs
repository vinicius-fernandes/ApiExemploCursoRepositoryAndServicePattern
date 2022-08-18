namespace ApiExemplo.Models
{
    public class Empresa
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public virtual IEnumerable<Transacao>? Transacoes { get; set; }

    }
}
