using Microsoft.EntityFrameworkCore;
using ProjetoCurso.Models;

namespace ProjetoCurso.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :  base(options)
        {
        }

        protected ApplicationDbContext()
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
