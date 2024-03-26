using Microsoft.EntityFrameworkCore;
using WebAPI_Funcionarios.Models;

namespace WebAPI_Funcionarios.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }

}
