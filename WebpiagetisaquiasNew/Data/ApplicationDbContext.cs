using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebpiagetisaquiasNew.Models;

namespace WebpiagetisaquiasNew.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<WebpiagetisaquiasNew.Models.Aluno> Aluno { get; set; } = default!;
}
