namespace EmprestimoDeLivros.Models
{
    public class EmprestimoModel
    {
        public int id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string NomeLivro { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;

    }
}
