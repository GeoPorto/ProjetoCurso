namespace ProjetoCurso.Models
{
    public class Aluno
    {
        public Aluno()
        { 
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Prontuario { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
