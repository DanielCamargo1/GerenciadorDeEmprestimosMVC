using EmprestimoDeLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoDeLivros.Data
{
    public class EmprestimoDbContext : DbContext
    {
        public EmprestimoDbContext(DbContextOptions<EmprestimoDbContext>options) : base(options)
        {
                    
        }

        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }   
}
